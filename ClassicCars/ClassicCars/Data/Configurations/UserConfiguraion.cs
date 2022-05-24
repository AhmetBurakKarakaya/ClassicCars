using ClassicCars.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Configurations
{
    public class UserConfiguraion : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Name).HasMaxLength(100);
            builder.Property(u => u.Name).IsRequired(true);
            builder.Property(u => u.LastName).HasMaxLength(100);
            builder.Property(u => u.LastName).IsRequired(true);
            builder.Property(u => u.Tumbnail).IsRequired(true);
            builder.Property(u => u.Tumbnail).HasMaxLength(300);
            builder.Property(u => u.Email).IsRequired(true);
            builder.Property(u => u.Parola).IsRequired(true);
            builder.Property(u => u.createDate).HasDefaultValueSql("getdate()");
            builder.Property(u => u.Role).IsRequired(true);
            builder.Property(u => u.Role).HasDefaultValue(0);
            builder.ToTable("Users");
            builder.HasData(new Users { 
                Id=1,
                Name = "Ahmet Burak",
                LastName = "Karakaya",
                Email = "ahmet.karakaya99@erzurum.edu.tr",
                Parola = "123456",
                Role = 1,
                Tumbnail = "~/Content/images/etulogo1.png"
            },
            new Users
            {
                Id = 2,
                Name = "Melih",
                LastName = "Karakaya",
                Email = "melih.karakaya@example.com.tr",
                Parola = "123456",
                Role = 1,
                Tumbnail = "~/Content/images/etulogo1.png"
            },
            new Users
            {
                Id = 3,
                Name = "Zeynep",
                LastName = "Karakaya",
                Email = "zeynep.karakaya@example.com.tr",
                Parola = "123456",
                Role = 1,
                Tumbnail = "~/Content/images/etulogo1.png"
            });
        }
    }
}
