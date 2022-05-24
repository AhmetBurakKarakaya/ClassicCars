using ClassicCars.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClassicCars.Data.Configurations
{
    public class PopularCarsConfiguration : IEntityTypeConfiguration<PopularCars>
    {
        public void Configure(EntityTypeBuilder<PopularCars> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(30);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Price).HasColumnType("MONEY");
            builder.Property(p => p.Tumbnail).IsRequired();
            builder.Property(p => p.Tumbnail).HasMaxLength(250);
            builder.ToTable("PopularCars");
            builder.HasData(
                new PopularCars
                {
                    Id = 1,
                    Name = "CAR NAME",
                    Price = 200,
                    Tumbnail = "car-1.jpg",
                    IsActive = true
                },
                new PopularCars
                {
                    Id = 2,
                    Name = "CAR NAME",
                    Price = 100,
                    Tumbnail = "car-2.jpg",
                    IsActive = true
                },
                new PopularCars
                {
                    Id = 3,
                    Name = "CAR NAME",
                    Price = 150,
                    Tumbnail = "car-3.jpg",
                    IsActive = true
                });
        }
    }
}
