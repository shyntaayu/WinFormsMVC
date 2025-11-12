using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMVC.Controllers;
using WinFormsMVC.Models;

namespace WinFormsMVC.Views
{
    public partial class FormDetailMahasiswa : Form
    {
        private readonly Mahasiswa _mahasiswa;

        // Constructor dengan parameter (Dependency Injection)
        public FormDetailMahasiswa(Mahasiswa mahasiswa)
        {
            InitializeComponent();
            _mahasiswa = mahasiswa ?? throw new ArgumentNullException(nameof(mahasiswa));
        }

        private void FormDetailMahasiswa_Load(object sender, EventArgs e)
        {
            DisplayMahasiswaInfo();
        }

        // Method untuk display informasi mahasiswa (Encapsulation)
        private void DisplayMahasiswaInfo()
        {
            lblNIMValue.Text = _mahasiswa.NIM;
            lblNamaValue.Text = _mahasiswa.Nama;
            lblJurusanValue.Text = _mahasiswa.Jurusan;
            lblIPKValue.Text = _mahasiswa.IPK.ToString("F2");
            lblStatusValue.Text = _mahasiswa.Status;

            // Gunakan method dari class Mahasiswa (Encapsulation)
            string statusKelulusan = _mahasiswa.GetStatusKelulusan();
            lblKelulusanValue.Text = statusKelulusan;

            // Set color based on status
            if (_mahasiswa.IsLulus())
            {
                lblKelulusanValue.ForeColor = System.Drawing.Color.Green;
                lblKelulusanValue.Font = new System.Drawing.Font(lblKelulusanValue.Font, System.Drawing.FontStyle.Bold);
            }
            else
            {
                lblKelulusanValue.ForeColor = System.Drawing.Color.Red;
            }

            // Display grade
            string grade = _mahasiswa.GetGrade();
            lblGradeValue.Text = grade;

            // Display prestasi badge
            if (_mahasiswa.IsBerprestasi())
            {
                lblBadge.Text = "⭐ MAHASISWA BERPRESTASI";
                lblBadge.ForeColor = System.Drawing.Color.Gold;
                lblBadge.Visible = true;
            }
            else
            {
                lblBadge.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}