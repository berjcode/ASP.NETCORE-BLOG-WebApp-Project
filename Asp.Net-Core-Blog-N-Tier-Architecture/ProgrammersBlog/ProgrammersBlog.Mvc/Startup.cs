using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProgrammersBlog.Services.AutoMapper.Profiles;
using ProgrammersBlog.Services.Extensions;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using ProgrammersBlog.Mvc.AutoMapper.Profiles;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Mvc.Helpers;

namespace ProgrammersBlog.Mvc
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(options =>
            {
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(value => "bu alan bo� ge�ilmemelidir.");
            }).AddRazorRuntimeCompilation().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); //json format�nda g�nderiyoruz.
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; //i� i�e olan objelerde bir birine referans ederse bir sorun ya�amayacakt�r. Nested
            }).AddNToastNotifyToastr(); //js library
            services.AddSession();
            services.AddAutoMapper(typeof(CategoryProfile),typeof(ArticleProfile),typeof(UserProfile),typeof(ViewModelsProfile),typeof(CommentProfile));
            services.LoadMyServices();
			services.AddScoped<IImageHelper, ImageHelper>();
            
            //Identity Cookie konfig�rasyon ayarlar�
			services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Admin/Auth/Login"); //Login sayfas� yolu
                options.LogoutPath = new PathString("/Admin/Auth/Logout"); //Logout sayfas� yolu
                options.Cookie = new CookieBuilder
                {
                    Name = "ProgrammersBlog",  //Cookie �smi
                    HttpOnly = true, //frontend taraf�nda cookie bilgisine eri�im engellenir. XSS sald�r�lar�
                    SameSite = SameSiteMode.Strict,  //CSRF Sald�r�sn�n� �nlemek i�indir. oturum a�m�� kullan�c�n�n cookie bilgileri ile yap�lan i�lemlerdir. cookie cal�n�r ve i�lem yap�l�r.
                    SecurePolicy = CookieSecurePolicy.SameAsRequest  //Politika de�eri, cookie'nin g�venlik de�eri. request ne �zerinden gelirse d�n�� yapar. http, https
                };
                options.SlidingExpiration = true; //kullan�c� sisteme giri� s�resi tan�nmas�
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7);  //cookie ya�am s�resi 7 g�n.
                options.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); //yetkisiz giri� sayfas� yolu 
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            app.UseSession(); // oturum 
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication(); //kimlik do�rulama i�lemidir.
            app.UseAuthorization(); //yetki kontrol�n� yap�lmas� 
            app.UseNToastNotify();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
