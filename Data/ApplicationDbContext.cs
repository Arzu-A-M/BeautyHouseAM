using BeautyHouseAM.Data.Entities;
using BeautyHouseAM.MappingTable;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeautyHouseAM.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<NailTechnician> NailTechnicons { get; set; }
        public DbSet<NailTechLevel> NailTechLevels { get; set; }
        public DbSet<Manicure> Manicures { get; set; }
        public DbSet<Pedicure> Pedicures { get; set; }
        public DbSet<AMBeautyHouseCourse> AMBeautyHouseCourses { get; set; }
        public DbSet<NailTechnicianImage> NailTechnicianImages { get; set; }
        public DbSet<ManicureImage> ManicureImages { get; set; }
        public DbSet<PedicureImage> PedicureImages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<ManicureImage>()
                .HasKey(x => new { x.ImageId, x.ManicureId });

            builder
                .Entity<PedicureImage>()
                .HasKey(x => new { x.PedicureId, x.ImageId });

            builder.Entity<NailTechnicianImage>()
                .HasKey(x => new { x.NailTechnicainId, x.ImageId });
            base.OnModelCreating(builder);
            
        }
    }
}