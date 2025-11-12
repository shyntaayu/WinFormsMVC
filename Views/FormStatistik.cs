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

namespace WinFormsMVC.Views
{
    public partial class FormStatistik : Form
    {
        private readonly MahasiswaController _controller;

        public FormStatistik()
        {
            InitializeComponent();
            _controller = new MahasiswaController();
        }

        private void FormStatistik_Load(object sender, EventArgs e)
        {
            LoadStatistik();
        }

        private void LoadStatistik()
        {
            // Statistik jumlah per jurusan
            var resultJumlah = _controller.GetStatistik();
            if (resultJumlah.IsSuccess)
            {
                DisplayStatistikJumlah(resultJumlah.Data);
            }

            // Statistik rata-rata IPK per jurusan
            var resultIPK = _controller.GetRataRataIPK();
            if (resultIPK.IsSuccess)
            {
                DisplayStatistikIPK(resultIPK.Data);
            }
        }

        private void DisplayStatistikJumlah(Dictionary<string, int> data)
        {
            dgvJumlah.DataSource = null;
            dgvJumlah.Rows.Clear();
            dgvJumlah.Columns.Clear();

            dgvJumlah.Columns.Add("Jurusan", "Jurusan");
            dgvJumlah.Columns.Add("Jumlah", "Jumlah Mahasiswa");

            dgvJumlah.Columns["Jurusan"].Width = 200;
            dgvJumlah.Columns["Jumlah"].Width = 150;

            int totalMahasiswa = 0;
            foreach (var item in data)
            {
                dgvJumlah.Rows.Add(item.Key, item.Value);
                totalMahasiswa += item.Value;
            }

            // Add total row
            int totalRowIndex = dgvJumlah.Rows.Add("TOTAL", totalMahasiswa);
            dgvJumlah.Rows[totalRowIndex].DefaultCellStyle.Font =
                new Font(dgvJumlah.Font, FontStyle.Bold);
            dgvJumlah.Rows[totalRowIndex].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void DisplayStatistikIPK(Dictionary<string, double> data)
        {
            dgvIPK.DataSource = null;
            dgvIPK.Rows.Clear();
            dgvIPK.Columns.Clear();

            dgvIPK.Columns.Add("Jurusan", "Jurusan");
            dgvIPK.Columns.Add("RataRataIPK", "Rata-rata IPK");

            dgvIPK.Columns["Jurusan"].Width = 200;
            dgvIPK.Columns["RataRataIPK"].Width = 150;

            double totalIPK = 0;
            int count = 0;

            foreach (var item in data)
            {
                dgvIPK.Rows.Add(item.Key, item.Value.ToString("F2"));
                totalIPK += item.Value;
                count++;
            }

            // Add average row
            if (count > 0)
            {
                double avgIPK = totalIPK / count;
                int avgRowIndex = dgvIPK.Rows.Add("RATA-RATA KESELURUHAN", avgIPK.ToString("F2"));
                dgvIPK.Rows[avgRowIndex].DefaultCellStyle.Font =
                    new Font(dgvIPK.Font, FontStyle.Bold);
                dgvIPK.Rows[avgRowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        components?.Dispose();
        //        _controller?.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
