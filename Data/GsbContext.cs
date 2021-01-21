using GsbApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GsbApp.Data
{
    public class GsbContext : DbContext
    {
        public GsbContext(DbContextOptions<GsbContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<ExpenceReport>().HasKey(table => new { table.IdFlateRate, table.IdCommercial });
        //}

        public DbSet<Commercial> Commercials { get; set; }
        public DbSet<ExpenceReport> ExpenceReport { get; set; }
        public DbSet<FlateRateCategory> FlateRateCategory { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
