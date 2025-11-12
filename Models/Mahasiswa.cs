using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    // Ini adalah class yang merepresentasikan tabel mahasiswa di PostgreSQL
    [Table("mahasiswa")] // Nama tabel di PostgreSQL (lowercase)
    public class Mahasiswa
    {
        [Key] // Primary Key
        [Column("id")]
        public int Id { get; set; }

        [Column("nim")]
        [MaxLength(20)]
        public string NIM { get; set; }

        [Column("nama")]
        [MaxLength(100)]
        public string Nama { get; set; }

        [Column("jurusan")]
        [MaxLength(50)]
        public string Jurusan { get; set; }

        [Column("ipk")]
        public double IPK { get; set; }

        [Column("status")]
        [MaxLength(20)]
        public string Status { get; set; } = "Aktif";
    }
}
