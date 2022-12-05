using BeautyHouseAM.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeautyHouseAM.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<NailTechnicon> NailTechnicons { get; set; }
        public DbSet<NailTechLevel> NailTechLevels { get; set; }
        public DbSet<Manicure> Manicures { get; set; }
        public DbSet<Pedicure> Pedicures { get; set; }
        public DbSet<AMBeautyHouseCourse> AMBeautyHouseCourses { get; set; }

    }
}