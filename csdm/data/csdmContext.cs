using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using csdm.Models;

namespace csdm.Data
{
    public class csdmContext : DbContext
    {
        public csdmContext (DbContextOptions<csdmContext> options)
            : base(options)
        {
        }

        public DbSet<csdm.Models.Root> Root { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Root>()
                .HasMany(r => r.players)
                .WithOne()
                .HasForeignKey(p => p.matchChecksum)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Root>()
                .HasMany(r => r.rounds)
                .WithOne()
                .HasForeignKey(r => r.matchChecksum)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Root>()
                .HasOne(r => r.teamA)
                .WithOne()
                .HasForeignKey<TeamA>(t => t.matchChecksum)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Root>()
                .HasOne(r => r.teamB)
                .WithOne()
                .HasForeignKey<TeamB>(t => t.matchChecksum)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<csdm.Models.Player> Player { get; set; } = default!;
    }
}
