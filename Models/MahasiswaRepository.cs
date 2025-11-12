using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    // Concrete Repository - Inherit dari BaseRepository (Inheritance)
    // Repository dengan Abstraction
    public class MahasiswaRepository : BaseRepository<Mahasiswa>
    {
        // Constructor
        public MahasiswaRepository() : base()
        {
        }

        // Override method untuk custom logic (Polymorphism)
        public override bool Add(Mahasiswa entity)
        {
            // Validasi sebelum insert
            if (!entity.IsValid(out string errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }

            // Cek duplikasi NIM
            var existing = GetByNIM(entity.NIM);
            if (existing != null)
            {
                throw new ArgumentException("NIM sudah terdaftar");
            }

            return base.Add(entity);
        }

        // Custom method spesifik untuk Mahasiswa
        public Mahasiswa GetByNIM(string nim)
        {
            try
            {
                return FirstOrDefault(m => m.NIM == nim);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting mahasiswa by NIM: {ex.Message}");
            }
        }

        public List<Mahasiswa> GetMahasiswaBerprestasi()
        {
            try
            {
                return Find(m => m.Status == "Aktif" && m.IPK >= 3.0)
                       .OrderByDescending(m => m.IPK)
                       .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting mahasiswa berprestasi: {ex.Message}");
            }
        }

        public List<Mahasiswa> GetByJurusan(string jurusan)
        {
            try
            {
                return Find(m => m.Jurusan == jurusan)
                       .OrderBy(m => m.Nama)
                       .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting mahasiswa by jurusan: {ex.Message}");
            }
        }

        public List<Mahasiswa> GetByStatus(string status)
        {
            try
            {
                return Find(m => m.Status == status)
                       .OrderBy(m => m.Nama)
                       .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting mahasiswa by status: {ex.Message}");
            }
        }

        public List<Mahasiswa> Search(string keyword)
        {
            try
            {
                keyword = keyword?.ToLower() ?? "";
                return Find(m =>
                    m.NIM.ToLower().Contains(keyword) ||
                    m.Nama.ToLower().Contains(keyword) ||
                    m.Jurusan.ToLower().Contains(keyword))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error searching mahasiswa: {ex.Message}");
            }
        }

        // Method untuk statistik
        public Dictionary<string, int> GetStatistikPerJurusan()
        {
            try
            {
                return GetAll()
                       .GroupBy(m => m.Jurusan)
                       .ToDictionary(g => g.Key, g => g.Count());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting statistik: {ex.Message}");
            }
        }

        public Dictionary<string, double> GetRataRataIPKPerJurusan()
        {
            try
            {
                return GetAll()
                       .GroupBy(m => m.Jurusan)
                       .ToDictionary(g => g.Key, g => Math.Round(g.Average(m => m.IPK), 2));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting rata-rata IPK: {ex.Message}");
            }
        }

        // Method untuk get mahasiswa yang tidak lulus
        public List<Mahasiswa> GetMahasiswaTidakLulus()
        {
            try
            {
                return Find(m => !m.IsLulus() && m.Status == "Aktif")
                       .OrderBy(m => m.IPK)
                       .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting mahasiswa tidak lulus: {ex.Message}");
            }
        }
    }
}