using Microsoft.EntityFrameworkCore;
using ULO.Models.Entities;

namespace ULO
{
    public class ULODbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ULODbContext(DbContextOptions<ULODbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
