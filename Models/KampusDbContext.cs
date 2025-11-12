using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    // DbContext adalah class utama untuk berinteraksi dengan database
    public class KampusDbContext : DbContext
    {
        // DbSet merepresentasikan tabel di database
        public DbSet<Mahasiswa> Mahasiswa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string untuk PostgreSQL
            optionsBuilder.UseNpgsql(
                "Host=localhost;Database=kampus_db;Username=postgres;Password=postgres"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfigurasi tambahan jika diperlukan
            // PostgreSQL case-sensitive untuk nama tabel, jadi kita set lowercase
            modelBuilder.Entity<Mahasiswa>().ToTable("mahasiswa");
        }
    }
}
