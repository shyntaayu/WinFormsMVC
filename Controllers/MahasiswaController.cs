using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMVC.Models;

namespace WinFormsMVC.Controllers
{
    public class MahasiswaController
    {
        private MahasiswaService service;

        public MahasiswaController()
        {
            service = new MahasiswaService();
        }

        // Ambil semua mahasiswa
        public List<Mahasiswa> GetAllMahasiswa()
        {
            return service.GetAllMahasiswa();
        }

        // Tambah mahasiswa
        public bool TambahMahasiswa(string nim, string nama, string jurusan, double ipk)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(nim))
                throw new ArgumentException("NIM tidak boleh kosong");

            if (string.IsNullOrWhiteSpace(nama))
                throw new ArgumentException("Nama tidak boleh kosong");

            if (string.IsNullOrWhiteSpace(jurusan))
                throw new ArgumentException("Jurusan tidak boleh kosong");

            if (ipk < 0 || ipk > 4)
                throw new ArgumentException("IPK harus antara 0 - 4");

            // Cek apakah NIM sudah ada
            var existing = service.GetMahasiswaByNIM(nim);
            if (existing != null)
                throw new ArgumentException("NIM sudah terdaftar");

            Mahasiswa mhs = new Mahasiswa
            {
                NIM = nim,
                Nama = nama,
                Jurusan = jurusan,
                IPK = ipk,
                Status = "Aktif"
            };

            return service.TambahMahasiswa(mhs);
        }

        // Update mahasiswa
        public bool UpdateMahasiswa(int id, string nim, string nama, string jurusan, double ipk, string status)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(nim))
                throw new ArgumentException("NIM tidak boleh kosong");

            if (string.IsNullOrWhiteSpace(nama))
                throw new ArgumentException("Nama tidak boleh kosong");

            if (ipk < 0 || ipk > 4)
                throw new ArgumentException("IPK harus antara 0 - 4");

            Mahasiswa mhs = new Mahasiswa
            {
                Id = id,
                NIM = nim,
                Nama = nama,
                Jurusan = jurusan,
                IPK = ipk,
                Status = status
            };

            return service.UpdateMahasiswa(mhs);
        }

        // Hapus mahasiswa
        public bool HapusMahasiswa(int id)
        {
            return service.HapusMahasiswa(id);
        }

        // Cari mahasiswa
        public List<Mahasiswa> CariMahasiswa(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return service.GetAllMahasiswa();

            return service.CariMahasiswa(keyword);
        }

        // Get mahasiswa by ID
        public Mahasiswa GetMahasiswaById(int id)
        {
            return service.GetMahasiswaById(id);
        }

        // Get mahasiswa berprestasi
        public List<Mahasiswa> GetMahasiswaBerprestasi()
        {
            return service.GetMahasiswaBerprestasi();
        }

        // Filter by jurusan
        public List<Mahasiswa> GetMahasiswaByJurusan(string jurusan)
        {
            return service.GetMahasiswaByJurusan(jurusan);
        }

        // Cek kelulusan
        public string CekKelulusan(Mahasiswa mhs)
        {
            bool lulus = service.CekKelulusan(mhs);
            return lulus ? "LULUS" : "TIDAK LULUS";
        }

        // Statistik
        public Dictionary<string, int> GetStatistik()
        {
            return service.GetStatistikPerJurusan();
        }
    }
}
