using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    public class MahasiswaService
    {
        // CREATE - Tambah mahasiswa baru
        public bool TambahMahasiswa(Mahasiswa mhs)
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    context.Mahasiswa.Add(mhs);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menambah mahasiswa: {ex.Message}");
            }
        }

        // READ - Ambil semua mahasiswa
        public List<Mahasiswa> GetAllMahasiswa()
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    return context.Mahasiswa.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        // READ - Ambil mahasiswa by ID
        public Mahasiswa GetMahasiswaById(int id)
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    return context.Mahasiswa.Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        // READ - Cari mahasiswa by NIM
        public Mahasiswa GetMahasiswaByNIM(string nim)
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    return context.Mahasiswa.FirstOrDefault(m => m.NIM == nim);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mencari mahasiswa: {ex.Message}");
            }
        }

        // UPDATE - Update mahasiswa
        public bool UpdateMahasiswa(Mahasiswa mhs)
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    context.Mahasiswa.Update(mhs);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal update mahasiswa: {ex.Message}");
            }
        }

        // DELETE - Hapus mahasiswa
        public bool HapusMahasiswa(int id)
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    var mhs = context.Mahasiswa.Find(id);
                    if (mhs != null)
                    {
                        context.Mahasiswa.Remove(mhs);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menghapus mahasiswa: {ex.Message}");
            }
        }

        // Cari mahasiswa berprestasi (IPK >= 3.0)
        public List<Mahasiswa> GetMahasiswaBerprestasi()
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    return context.Mahasiswa
                                  .Where(m => m.Status == "Aktif" && m.IPK >= 3.0)
                                  .OrderByDescending(m => m.IPK)
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        // Filter by jurusan
        public List<Mahasiswa> GetMahasiswaByJurusan(string jurusan)
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    return context.Mahasiswa
                                  .Where(m => m.Jurusan == jurusan)
                                  .OrderBy(m => m.Nama)
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        // Cari mahasiswa (search)
        public List<Mahasiswa> CariMahasiswa(string keyword)
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    return context.Mahasiswa
                                  .Where(m => m.NIM.Contains(keyword) ||
                                             m.Nama.Contains(keyword) ||
                                             m.Jurusan.Contains(keyword))
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mencari data: {ex.Message}");
            }
        }

        // Logika bisnis: Cek kelulusan
        public bool CekKelulusan(Mahasiswa mhs)
        {
            return mhs.IPK >= 2.75;
        }

        // Statistik per jurusan
        public Dictionary<string, int> GetStatistikPerJurusan()
        {
            try
            {
                using (var context = new KampusDbContext())
                {
                    return context.Mahasiswa
                                  .GroupBy(m => m.Jurusan)
                                  .ToDictionary(g => g.Key, g => g.Count());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil statistik: {ex.Message}");
            }
        }
    }
}
