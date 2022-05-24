using ClassicCars.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Configurations
{
    public class VideoGalleryConfiguration : IEntityTypeConfiguration<VideoGallery>
    {
        public void Configure(EntityTypeBuilder<VideoGallery> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Id).ValueGeneratedOnAdd();
            builder.Property(v => v.VideoUrl).IsRequired(true);
            builder.Property(v => v.VideoUrl).HasMaxLength(250);
            builder.ToTable("VideoGalleries");
            builder.HasData(
                new VideoGallery
                {
                    Id = 1,
                    VideoUrl = "car-video-1.mp4",
                    IsActive = true
                },
                new VideoGallery
                {
                    Id = 2,
                    VideoUrl = "car-video-2.mp4",
                    IsActive = true
                },
                new VideoGallery
                {
                    Id = 3,
                    VideoUrl = "car-video-3.mp4",
                    IsActive = true
                },
                new VideoGallery
                {
                    Id = 4,
                    VideoUrl = "car-video-4.mp4",
                    IsActive = true
                },
                new VideoGallery
                {
                    Id = 5,
                    VideoUrl = "car-video-5.mp4",
                    IsActive = true
                },
                new VideoGallery
                {
                    Id = 6,
                    VideoUrl = "car-video-6.mp4",
                    IsActive = true
                });
        }
    }
}
