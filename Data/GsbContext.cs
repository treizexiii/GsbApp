using GsbApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GsbApp.Data
{
    public class GsbContext : DbContext
    {
        public GsbContext(DbContextOptions<GsbContext> options) : base(options)
        {
        }

        public DbSet<Commercial> Commercials { get; set; }
    }
}