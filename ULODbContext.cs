using Microsoft.EntityFrameworkCore;
using ULO.Models.Entities;
using ULO.UI.Models.Entities;

namespace ULO
{
    public class ULODbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Aktualnosc> Aktualnosc { get; set; }
        public DbSet<TeamPoz> TeamPoz {  get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<Statute> Statute { get; set; }

        public ULODbContext(DbContextOptions<ULODbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
