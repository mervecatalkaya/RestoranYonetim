using Microsoft.EntityFrameworkCore;
using Models;

namespace DalLayer.Context
{
    public class RestoranDbContext : DbContext
    {
        public DbSet<Masa> Masalar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=MERVE;" +
                "Database=RestoranDb;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Masa - Siparis ilişkisi (1-N)
            modelBuilder.Entity<Siparis>()
                .HasOne(s => s.Masa)
                .WithMany(m => m.Siparisler)
                .HasForeignKey(s => s.MasaID)
                .OnDelete(DeleteBehavior.Restrict);

            // Urun - Siparis ilişkisi (1-N)
            modelBuilder.Entity<Siparis>()
                .HasOne(s => s.Urun)
                .WithMany(u => u.Siparisler)
                .HasForeignKey(s => s.UrunID)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}