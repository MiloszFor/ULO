using Microsoft.EntityFrameworkCore;
using ULO.Models.Entities;
using ULO.UI.Models.Entities;

namespace ULO
{
    public class ULODbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Aktualnosc> Aktualnosc { get; set; }

        public DbSet<Team> Team { get; set; }

        public ULODbContext(DbContextOptions<ULODbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
