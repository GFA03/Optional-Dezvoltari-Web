using Microsoft.EntityFrameworkCore;
using tema_lab4.Models.One_to_many;
using tema_lab4.Models.One_to_one;

namespace tema_lab4.Data
{
    public class TemaLab4Context : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Sponsor> Sponsors { get; set;}
        public DbSet<Car> Cars { get; set; }

        public DbSet<Pilot> Pilots { get; set; }

        public TemaLab4Context(DbContextOptions<TemaLab4Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                        .HasMany(t => t.Sponsors)
                        .WithOne(s => s.Team);

            modelBuilder.Entity<Team>()
                        .HasMany(t => t.Pilots)
                        .WithOne(p => p.Team);

            modelBuilder.Entity<Team>()
                        .HasOne(t => t.Car)
                        .WithOne(c => c.Team)
                        .HasForeignKey<Car>(c => c.TeamId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
