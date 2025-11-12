using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMVC.Models;

namespace WinFormsMVC.Controllers
{
    // Controller bertanggung jawab mengatur alur antara View dan Model
    public class MahasiswaController : IDisposable
    {
        private readonly MahasiswaService _service;

        // Constructor dengan Dependency Injection
        public MahasiswaController()
        {
            _service = new MahasiswaService();
        }

        public MahasiswaController(MahasiswaService service)
        {
            _service = service;
        }

        // CRUD Operations
        public OperationResult<bool> TambahMahasiswa(string nim, string nama, string jurusan, double ipk)
        {
            try
            {
                // Create new instance using constructor
                var mahasiswa = new Mahasiswa(nim, nama, jurusan, ipk);

                bool success = _service.TambahMahasiswa(mahasiswa);
                return OperationResult<bool>.Success(success, "Data mahasiswa berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.Failure(ex.Message);
            }
        }

        public OperationResult<bool> UpdateMahasiswa(int id, string nim, string nama, string jurusan, double ipk, string status)
        {
            try
            {
                var mahasiswa = new Mahasiswa
                {
                    Id = id,
                    NIM = nim,
                    Nama = nama,
                    Jurusan = jurusan,
                    IPK = ipk,
                    Status = status
                };

                bool success = _service.UpdateMahasiswa(mahasiswa);
                return OperationResult<bool>.Success(success, "Data mahasiswa berhasil diupdate");
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.Failure(ex.Message);
            }
        }

        public OperationResult<bool> HapusMahasiswa(int id)
        {
            try
            {
                bool success = _service.HapusMahasiswa(id);
                if (success)
                    return OperationResult<bool>.Success(true, "Data mahasiswa berhasil dihapus");
                else
                    return OperationResult<bool>.Failure("Mahasiswa tidak ditemukan");
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.Failure(ex.Message);
            }
        }

        public OperationResult<Mahasiswa> GetMahasiswaById(int id)
        {
            try
            {
                var mahasiswa = _service.GetMahasiswaById(id);
                if (mahasiswa != null)
                    return OperationResult<Mahasiswa>.Success(mahasiswa);
                else
                    return OperationResult<Mahasiswa>.Failure("Mahasiswa tidak ditemukan");
            }
            catch (Exception ex)
            {
                return OperationResult<Mahasiswa>.Failure(ex.Message);
            }
        }

        public OperationResult<List<Mahasiswa>> GetAllMahasiswa()
        {
            try
            {
                var data = _service.GetAllMahasiswa();
                return OperationResult<List<Mahasiswa>>.Success(data);
            }
            catch (Exception ex)
            {
                return OperationResult<List<Mahasiswa>>.Failure(ex.Message);
            }
        }

        public OperationResult<List<Mahasiswa>> CariMahasiswa(string keyword)
        {
            try
            {
                var data = _service.CariMahasiswa(keyword);
                return OperationResult<List<Mahasiswa>>.Success(data);
            }
            catch (Exception ex)
            {
                return OperationResult<List<Mahasiswa>>.Failure(ex.Message);
            }
        }

        public OperationResult<List<Mahasiswa>> GetMahasiswaBerprestasi()
        {
            try
            {
                var data = _service.GetMahasiswaBerprestasi();
                return OperationResult<List<Mahasiswa>>.Success(data);
            }
            catch (Exception ex)
            {
                return OperationResult<List<Mahasiswa>>.Failure(ex.Message);
            }
        }

        public OperationResult<List<Mahasiswa>> FilterByJurusan(string jurusan)
        {
            try
            {
                var data = _service.GetMahasiswaByJurusan(jurusan);
                return OperationResult<List<Mahasiswa>>.Success(data);
            }
            catch (Exception ex)
            {
                return OperationResult<List<Mahasiswa>>.Failure(ex.Message);
            }
        }

        public OperationResult<List<Mahasiswa>> FilterByStatus(string status)
        {
            try
            {
                var data = _service.GetMahasiswaByStatus(status);
                return OperationResult<List<Mahasiswa>>.Success(data);
            }
            catch (Exception ex)
            {
                return OperationResult<List<Mahasiswa>>.Failure(ex.Message);
            }
        }

        public OperationResult<Dictionary<string, int>> GetStatistik()
        {
            try
            {
                var data = _service.GetStatistikPerJurusan();
                return OperationResult<Dictionary<string, int>>.Success(data);
            }
            catch (Exception ex)
            {
                return OperationResult<Dictionary<string, int>>.Failure(ex.Message);
            }
        }

        public OperationResult<Dictionary<string, double>> GetRataRataIPK()
        {
            try
            {
                var data = _service.GetRataRataIPKPerJurusan();
                return OperationResult<Dictionary<string, double>>.Success(data);
            }
            catch (Exception ex)
            {
                return OperationResult<Dictionary<string, double>>.Failure(ex.Message);
            }
        }

        public string GetStatusKelulusan(Mahasiswa mahasiswa)
        {
            return mahasiswa.GetStatusKelulusan();
        }

        public string GetGrade(Mahasiswa mahasiswa)
        {
            return mahasiswa.GetGrade();
        }

        // Dispose pattern
        public void Dispose()
        {
            _service?.Dispose();
        }
    }

    // Helper class untuk result operation (Best Practice)
    public class OperationResult<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public static OperationResult<T> Success(T data, string message = "Operasi berhasil")
        {
            return new OperationResult<T>
            {
                IsSuccess = true,
                Message = message,
                Data = data
            };
        }

        public static OperationResult<T> Failure(string message)
        {
            return new OperationResult<T>
            {
                IsSuccess = false,
                Message = message,
                Data = default(T)
            };
        }
    }
}