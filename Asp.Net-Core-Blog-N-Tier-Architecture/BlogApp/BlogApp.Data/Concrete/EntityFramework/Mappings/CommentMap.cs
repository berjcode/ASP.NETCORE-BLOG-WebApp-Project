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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();

            builder.Property(c => c.Text).HasMaxLength(1000);

            //bir yorumun makalesi vardır. bir maklenin birden fazla yorumu olabilir.
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);

            builder.Property(c => c.CreatedByName).IsRequired();

            builder.Property(c => c.CreatedByName).HasMaxLength(100);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(100);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();

            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);

            builder.ToTable("Comments");

            builder.HasData(new Comment
            {
                Id =1,
                ArticleId =1,
                Text="çOK GÜZEL BİR İÇERİK TEŞEKKÜRLER.",
                 IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitalCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,

                Note = ".net",

            }, new Comment
            {
                Id = 2,
                ArticleId = 2,
                Text = "DAHA İYİ OLABİLİRDİ",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitalCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,

                Note = ".net",

            });
        }
    }
}
