using ClassicCars.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Configurations
{
    public class ImageGalleryConfiguration : IEntityTypeConfiguration<ImageGallery>
    {
        public void Configure(EntityTypeBuilder<ImageGallery> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.Tumbnail).IsRequired(true);
            builder.Property(i => i.Tumbnail).HasMaxLength(250);
            builder.ToTable("ImageGalleries");
            builder.HasData(
                new ImageGallery
                {
                    Id = 1,
                    Tumbnail = "gallery-car-1.jpg",
                    IsActive = true
                },
                new ImageGallery
                {
                    Id = 2,
                    Tumbnail = "gallery-car-2.jpg",
                    IsActive = true
                },
                new ImageGallery
                {
                    Id = 3,
                    Tumbnail = "gallery-car-3.jpg",
                    IsActive = true
                },
                new ImageGallery
                {
                    Id = 4,
                    Tumbnail = "gallery-car-4.jpg",
                    IsActive = true
                },
                new ImageGallery
                {
                    Id = 5,
                    Tumbnail = "gallery-car-5.jpg",
                    IsActive = true
                },
                new ImageGallery
                {
                    Id = 6,
                    Tumbnail = "gallery-car-6.jpg",
                    IsActive = true
                });
        }
    }
}
