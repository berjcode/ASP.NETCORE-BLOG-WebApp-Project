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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u=> u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50);
            //Email sadece bir kez olmalı. Uniqe olmalı  
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.UserName).HasMaxLength(20);
            builder.HasIndex(u => u.UserName).IsUnique();

            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
           
            builder.Property(u => u.Description).HasMaxLength(500);
            builder.Property(u => u.FirstName).IsRequired();
            builder.Property(u => u.FirstName).HasMaxLength(30);
            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(30);
            builder.Property(u => u.Picture).IsRequired();

            builder.Property(u => u.Picture).HasMaxLength(250);

            builder.HasOne<Role>(u => u.Role).WithMany( r => r.Users).HasForeignKey( u => u.RoleId);


            builder.Property(u => u.CreatedByName).IsRequired();

            builder.Property(u => u.CreatedByName).HasMaxLength(100);
            builder.Property(u => u.ModifiedByName).IsRequired();
            builder.Property(u => u.ModifiedByName).HasMaxLength(100);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.ModifiedDate).IsRequired();

            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.Note).HasMaxLength(500);

            builder.ToTable("Users");



            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Abdullah",
                LastName = "Balıkçı",
                UserName = "abdblk",
                Email = "abdblk2525@gmail.com",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitalCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Description = "İlk Admin Kullanıcı",
                Note = "Admin Kullanıcısı",
                PasswordHash = Encoding.ASCII.GetBytes("e10adc3949ba59abbe56e057f20f883e"),
                Picture= "https://pps.whatsapp.net/v/t61.24694-24/310345921_1584798671933370_3049898836017126853_n.jpg?ccb=11-4&oh=01_AdRVV7N-xvbpEAsx3HqvrJORMB1Rw_dTBaOOEfE4XiqOwQ&oe=63B0084E"
            }) ; 
        }
    }
}
