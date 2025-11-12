using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    [Table("mahasiswa")]
    public class Mahasiswa
    {
        // Properties dengan backing field untuk encapsulation
        private int _id;
        private string _nim;
        private string _nama;
        private string _jurusan;
        private double _ipk;
        private string _status;

        [Key]
        [Column("id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Column("nim")]
        [MaxLength(20)]
        [Required(ErrorMessage = "NIM wajib diisi")]
        public string NIM
        {
            get { return _nim; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("NIM tidak boleh kosong");
                _nim = value.Trim();
            }
        }

        [Column("nama")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Nama wajib diisi")]
        public string Nama
        {
            get { return _nama; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama tidak boleh kosong");
                _nama = value.Trim();
            }
        }

        [Column("jurusan")]
        [MaxLength(50)]
        public string Jurusan
        {
            get { return _jurusan; }
            set { _jurusan = value?.Trim(); }
        }

        [Column("ipk")]
        public double IPK
        {
            get { return _ipk; }
            set
            {
                if (value < 0 || value > 4)
                    throw new ArgumentException("IPK harus antara 0 - 4");
                _ipk = value;
            }
        }

        [Column("status")]
        [MaxLength(20)]
        public string Status
        {
            get { return _status; }
            set { _status = value ?? "Aktif"; }
        }

        // Constructor default
        public Mahasiswa()
        {
            _status = "Aktif";
        }

        // Constructor dengan parameter (Constructor Overloading)
        public Mahasiswa(string nim, string nama, string jurusan, double ipk)
        {
            NIM = nim;
            Nama = nama;
            Jurusan = jurusan;
            IPK = ipk;
            Status = "Aktif";
        }

        // Method untuk cek kelulusan (Encapsulation - Logic dalam class)
        public bool IsLulus()
        {
            return _ipk >= 2.75;
        }

        // Method untuk get status kelulusan
        public string GetStatusKelulusan()
        {
            return IsLulus() ? "LULUS" : "TIDAK LULUS";
        }

        // Method untuk cek mahasiswa berprestasi
        public bool IsBerprestasi()
        {
            return _ipk >= 3.0 && _status == "Aktif";
        }

        // Method untuk get grade berdasarkan IPK
        public string GetGrade()
        {
            if (_ipk >= 3.5) return "A (Cum Laude)";
            if (_ipk >= 3.0) return "B (Sangat Memuaskan)";
            if (_ipk >= 2.75) return "C (Memuaskan)";
            return "D (Kurang Memuaskan)";
        }

        // Override ToString untuk debugging
        public override string ToString()
        {
            return $"{NIM} - {Nama} - {Jurusan} - IPK: {IPK:F2}";
        }

        // Method untuk validasi data lengkap
        public bool IsValid(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(NIM))
            {
                errorMessage = "NIM tidak boleh kosong";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Nama))
            {
                errorMessage = "Nama tidak boleh kosong";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Jurusan))
            {
                errorMessage = "Jurusan tidak boleh kosong";
                return false;
            }

            if (IPK < 0 || IPK > 4)
            {
                errorMessage = "IPK harus antara 0 - 4";
                return false;
            }

            return true;
        }
    }
}