using Microsoft.EntityFrameworkCore;
using SolorFrontAndBack.Models;

namespace SolorFrontAndBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> sliders { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Services> Services{ get; set; }
        public DbSet<Team> Team{ get; set; }
        public DbSet<Team2> Team2{ get; set; }
    }
}
