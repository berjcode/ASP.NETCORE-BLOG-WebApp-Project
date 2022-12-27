using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Concrete;

namespace ProgrammersBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ProgrammersBlogContext>();
            serviceCollection.AddIdentity<User, Role>(options =>
            {
                // User Password Options
                options.Password.RequireDigit = false;  // şifrelerimizde rakam olmalı mı?
                options.Password.RequiredLength = 5;   //Şifrenin karakter uzunluğu
                options.Password.RequiredUniqueChars = 0; // uniq karakterlerden kac tane olmalı 
                options.Password.RequireNonAlphanumeric = false; // @ !? gibi ifadelerin kullanılmasını sağlar.
                options.Password.RequireLowercase = false; // kücük harf olmalı
                options.Password.RequireUppercase = false; // büyük harf olmalı
                // User Username and Email Options
                options.User.AllowedUserNameCharacters= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+$"; //bu karakterler olabilir.
                options.User.RequireUniqueEmail = true; //email uniq olmalı başka birinde olmamalı
            }).AddEntityFrameworkStores<ProgrammersBlogContext>(); 
            serviceCollection.Configure<SecurityStampValidatorOptions>(options =>{
                options.ValidationInterval = TimeSpan.FromMinutes(30);// TimeSpan.Zero 0 zamanda  yani  döngüde sistem kontrol ediliyor. Role gibi atamalarda  logout yapar. TimeSpan.FromMinutes(30) 30dk
            });
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            return serviceCollection;
        }
    }
}
