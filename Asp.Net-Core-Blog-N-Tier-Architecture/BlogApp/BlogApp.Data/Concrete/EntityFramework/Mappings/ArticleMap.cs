using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);// primaryı key alanı var mı? Id Primary

            builder.Property(a =>a.Id).ValueGeneratedOnAdd(); //ID 1 1 artırsın.

            builder.Property(a => a.Title).HasMaxLength(100);

            builder.Property(a => a.Title).IsRequired();
            builder.Property(a =>a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)"); //Kolonun Tipi 
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(100);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoDescription).HasMaxLength(100);
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(100);
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);

            //ortak
            builder.Property(a => a.CreatedByName).IsRequired();

            builder.Property(a => a.CreatedByName).HasMaxLength(100);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(100);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);

            //ilişkiler
            // her makalenin bir kategorisi vardır.              kategorinin birden fazla makalesi vardır.  articles tarafındaki categoryid foreignkey olduğunu belirttik
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey( a => a.CategoryId);

            //userid
            //bir makalenin bir sahibi vardır. bir userın birden fazla makalesi olabilir.
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey( a => a.UserId);  

            builder.ToTable("Articles");


            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId=1,
                    Title= ".net Nedir?",
                    Content= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy " +
                    "text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a " +
                    "type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting," +
                    " remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing" +
                    " Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Thumbnail="default.jpg",
                    Description =".....",
                    SeoDescription =".net nedir ne işe yarar",
                    SeoTags =".net,efcore",
                    SeoAuthor="Abdullah Balıkçı",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitalCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    
                    Note = ".net",
                    UserId = 1,
                    ViewsCount=100,
                    CommentCount=1,

                }, new Article
                {
                    Id =2,
                    CategoryId = 2,
                    Title = "Donanım Nedir?",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy " +
                    "text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a " +
                    "type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting," +
                    " remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing" +
                    " Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Thumbnail = "default.jpg",
                    Description = ".....",
                    SeoDescription = "Donanım Nedir",
                    SeoTags = "Donanım,ram,gpu",
                    SeoAuthor = "Abdullah Balıkçı",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitalCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,

                    Note = ".net",
                    UserId = 1,
                    ViewsCount = 100,
                    CommentCount = 1,

                }



                );


        }
    }
}
