using Microsoft.EntityFrameworkCore;

namespace EvangelionDatabase.Models
{
    public class EVAContext : DbContext
    {
        public EVAContext (DbContextOptions<EVAContext> options)
            :base(options)
            {
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PilotEvangelions>().HasKey(e => new {e.EVAID, e.PilotID});
        }

        public DbSet<Pilot> Pilots {get; set;} = default!;
        public DbSet<Evangelion> Evangelions {get; set;} = default!;
    }
}