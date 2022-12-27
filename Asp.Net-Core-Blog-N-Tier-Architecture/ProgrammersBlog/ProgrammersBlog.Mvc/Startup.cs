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
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(value => "bu alan boþ geçilmemelidir.");
            }).AddRazorRuntimeCompilation().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); //json formatýnda gönderiyoruz.
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; //iç içe olan objelerde bir birine referans ederse bir sorun yaþamayacaktýr. Nested
            }).AddNToastNotifyToastr(); //js library
            services.AddSession();
            services.AddAutoMapper(typeof(CategoryProfile),typeof(ArticleProfile),typeof(UserProfile),typeof(ViewModelsProfile),typeof(CommentProfile));
            services.LoadMyServices();
			services.AddScoped<IImageHelper, ImageHelper>();
            
            //Identity Cookie konfigürasyon ayarlarý
			services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Admin/Auth/Login"); //Login sayfasý yolu
                options.LogoutPath = new PathString("/Admin/Auth/Logout"); //Logout sayfasý yolu
                options.Cookie = new CookieBuilder
                {
                    Name = "ProgrammersBlog",  //Cookie Ýsmi
                    HttpOnly = true, //frontend tarafýnda cookie bilgisine eriþim engellenir. XSS saldýrýlarý
                    SameSite = SameSiteMode.Strict,  //CSRF Saldýrýsnýný önlemek içindir. oturum açmýþ kullanýcýnýn cookie bilgileri ile yapýlan iþlemlerdir. cookie calýnýr ve iþlem yapýlýr.
                    SecurePolicy = CookieSecurePolicy.SameAsRequest  //Politika deðeri, cookie'nin güvenlik deðeri. request ne üzerinden gelirse dönüþ yapar. http, https
                };
                options.SlidingExpiration = true; //kullanýcý sisteme giriþ süresi tanýnmasý
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7);  //cookie yaþam süresi 7 gün.
                options.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); //yetkisiz giriþ sayfasý yolu 
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
            app.UseAuthentication(); //kimlik doðrulama iþlemidir.
            app.UseAuthorization(); //yetki kontrolünü yapýlmasý 
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
