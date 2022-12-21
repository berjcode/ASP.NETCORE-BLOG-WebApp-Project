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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(60);
            builder.Property(c=>c.Description).HasMaxLength(500);



            builder.Property(c => c.CreatedByName).IsRequired();

            builder.Property(c => c.CreatedByName).HasMaxLength(100);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(100);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();

            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);

            builder.ToTable("Categories");

            builder.HasData(new Category
            {
                Id= 1,
                Name ="Yazılım",
                Description="Yazılım geleceğin anahtarıdır.",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitalCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Kategori Yazılım",

            },new Category
            {
                Id = 2,
                Name = "Donanım",
                Description = "Donanım Bilgisayarın yapıtaşıdır.",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitalCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Kategori Donanım",
            });



        }
    }
}
