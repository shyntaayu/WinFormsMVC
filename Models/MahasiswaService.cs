using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    // Service layer untuk business logic (Single Responsibility Principle)
    public class MahasiswaService : IDisposable
    {
        private readonly MahasiswaRepository _repository;

        // Dependency Injection via Constructor
        public MahasiswaService()
        {
            _repository = new MahasiswaRepository();
        }

        public MahasiswaService(MahasiswaRepository repository)
        {
            _repository = repository;
        }

        // CRUD Operations dengan business logic
        public bool TambahMahasiswa(Mahasiswa mahasiswa)
        {
            try
            {
                // Validasi business rules
                if (!mahasiswa.IsValid(out string errorMessage))
                {
                    throw new ArgumentException(errorMessage);
                }

                return _repository.Add(mahasiswa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menambah mahasiswa: {ex.Message}");
            }
        }

        public bool UpdateMahasiswa(Mahasiswa mahasiswa)
        {
            try
            {
                if (!mahasiswa.IsValid(out string errorMessage))
                {
                    throw new ArgumentException(errorMessage);
                }

                // Get existing data from database
                var existing = _repository.GetById(mahasiswa.Id);
                if (existing == null)
                {
                    throw new ArgumentException("Data mahasiswa tidak ditemukan");
                }

                // Update properties one by one
                existing.NIM = mahasiswa.NIM;
                existing.Nama = mahasiswa.Nama;
                existing.Jurusan = mahasiswa.Jurusan;
                existing.IPK = mahasiswa.IPK;
                existing.Status = mahasiswa.Status;

                return _repository.Update(existing);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal update mahasiswa: {ex.Message}");
            }
        }

        public bool HapusMahasiswa(int id)
        {
            try
            {
                return _repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menghapus mahasiswa: {ex.Message}");
            }
        }

        public Mahasiswa GetMahasiswaById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        public Mahasiswa GetMahasiswaByNIM(string nim)
        {
            try
            {
                return _repository.GetByNIM(nim);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        public List<Mahasiswa> GetAllMahasiswa()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        public List<Mahasiswa> CariMahasiswa(string keyword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(keyword))
                    return GetAllMahasiswa();

                return _repository.Search(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mencari data: {ex.Message}");
            }
        }

        public List<Mahasiswa> GetMahasiswaBerprestasi()
        {
            try
            {
                return _repository.GetMahasiswaBerprestasi();
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        public List<Mahasiswa> GetMahasiswaByJurusan(string jurusan)
        {
            try
            {
                return _repository.GetByJurusan(jurusan);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        public List<Mahasiswa> GetMahasiswaByStatus(string status)
        {
            try
            {
                return _repository.GetByStatus(status);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        public List<Mahasiswa> GetMahasiswaTidakLulus()
        {
            try
            {
                return _repository.GetMahasiswaTidakLulus();
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil data: {ex.Message}");
            }
        }

        // Business Logic Methods
        public bool ValidasiKelulusan(Mahasiswa mahasiswa)
        {
            return mahasiswa.IsLulus();
        }

        public string GetStatusKelulusan(Mahasiswa mahasiswa)
        {
            return mahasiswa.GetStatusKelulusan();
        }

        public bool UpdateIPK(int id, double ipkBaru)
        {
            try
            {
                var mahasiswa = _repository.GetById(id);
                if (mahasiswa == null)
                    throw new ArgumentException("Mahasiswa tidak ditemukan");

                mahasiswa.IPK = ipkBaru;
                return _repository.Update(mahasiswa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal update IPK: {ex.Message}");
            }
        }

        public bool UpdateStatus(int id, string statusBaru)
        {
            try
            {
                var mahasiswa = _repository.GetById(id);
                if (mahasiswa == null)
                    throw new ArgumentException("Mahasiswa tidak ditemukan");

                mahasiswa.Status = statusBaru;
                return _repository.Update(mahasiswa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal update status: {ex.Message}");
            }
        }

        // Statistik Methods
        public Dictionary<string, int> GetStatistikPerJurusan()
        {
            try
            {
                return _repository.GetStatistikPerJurusan();
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil statistik: {ex.Message}");
            }
        }

        public Dictionary<string, double> GetRataRataIPKPerJurusan()
        {
            try
            {
                return _repository.GetRataRataIPKPerJurusan();
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil rata-rata IPK: {ex.Message}");
            }
        }

        public int GetTotalMahasiswa()
        {
            try
            {
                return _repository.GetAll().Count;
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil total: {ex.Message}");
            }
        }

        public int GetTotalMahasiswaAktif()
        {
            try
            {
                return _repository.GetByStatus("Aktif").Count;
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil total: {ex.Message}");
            }
        }

        // Dispose pattern
        public void Dispose()
        {
            _repository?.Dispose();
        }
    }
}