using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    public class KampusDbContext : DbContext
    {
        public DbSet<Mahasiswa> Mahasiswa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Database=kampus_db;Username=postgres;Password=postgres"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mahasiswa>().ToTable("mahasiswa");
        }
    }
}
