using ClassicCars.Data.Configurations;
using ClassicCars.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Contexts
{
    public class ClassicCarsContext : DbContext
    {
        public ClassicCarsContext(DbContextOptions<ClassicCarsContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HeadCarsConfiguration());
            modelBuilder.ApplyConfiguration(new ImageGalleryConfiguration());
            modelBuilder.ApplyConfiguration(new VideoGalleryConfiguration());
            modelBuilder.ApplyConfiguration(new PopularCarsConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguraion());

        }
        public DbSet<HeadCars> HeadCars { get; set; }
        public DbSet<PopularCars> PopularCars { get; set; }
        public DbSet<VideoGallery> VideoGalleries { get; set; }
        public DbSet<ImageGallery> ImageGalleries { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NCQDMP0;Initial Catalog=CLASSICCARSDB;Integrated Security=True");
        }

    }
}
