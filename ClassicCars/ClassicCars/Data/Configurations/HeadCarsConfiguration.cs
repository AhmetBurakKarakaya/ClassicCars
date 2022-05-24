using ClassicCars.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Configurations
{
    public class HeadCarsConfiguration : IEntityTypeConfiguration<HeadCars>
    {
        public void Configure(EntityTypeBuilder<HeadCars> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(h => h.Id).ValueGeneratedOnAdd();
            builder.Property(h => h.Title).HasMaxLength(50);
            builder.Property(h => h.Title).IsRequired(true);
            builder.Property(h => h.Tumbnail).IsRequired(true);
            builder.ToTable("HeadCars");
            builder.HasData(
                new HeadCars
                {
                    Id = 1,
                    Title = "CLASSIC CARS",
                    Tumbnail = "car-section1.png",
                    IsActive = true
                });
        }
    }
}
