using WinFormsMVC.Controllers;
using WinFormsMVC.Models;
using WinFormsMVC.Views;

namespace WinFormsMVC
{
    public partial class Form1 : BaseForm
    {
        private readonly MahasiswaController _controller;
        private int _selectedId = 0;

        public Form1()
        {
            InitializeComponent();
            _controller = new MahasiswaController();
            FormTitle = "Aplikasi Data Mahasiswa";
        }

        // Override abstract method dari BaseForm (Polymorphism)
        protected override void LoadData()
        {
            var result = _controller.GetAllMahasiswa();
            if (result.IsSuccess)
            {
                dgvMahasiswa.DataSource = result.Data;
                FormatDataGridView();
            }
            else
            {
                ShowError(result.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = FormTitle;
            InitializeControls();
            LoadData();
        }

        private void InitializeControls()
        {
            cboJurusan.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }

        private void FormatDataGridView()
        {
            if (dgvMahasiswa.Columns.Count > 0)
            {
                dgvMahasiswa.Columns["Id"].Width = 50;
                dgvMahasiswa.Columns["NIM"].Width = 120;
                dgvMahasiswa.Columns["Nama"].Width = 200;
                dgvMahasiswa.Columns["Jurusan"].Width = 150;
                dgvMahasiswa.Columns["IPK"].Width = 80;
                dgvMahasiswa.Columns["IPK"].DefaultCellStyle.Format = "F2";
                dgvMahasiswa.Columns["Status"].Width = 100;
            }
        }

        // Gunakan method dari BaseForm
        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Validasi menggunakan base method
            if (!ValidateNotEmpty(txtNIM, "NIM")) return;
            if (!ValidateNotEmpty(txtNama, "Nama")) return;
            if (!ValidateNumeric(txtIPK, "IPK", out double ipk)) return;
            if (!ValidateRange(ipk, 0, 4, "IPK")) return;

            var result = _controller.TambahMahasiswa(
                txtNIM.Text, txtNama.Text, cboJurusan.Text, ipk);

            if (result.IsSuccess)
            {
                ShowSuccess(result.Message);
                LoadData();
                ClearForm();
            }
            else
            {
                ShowError(result.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                ShowWarning("Silakan pilih data yang akan diupdate!");
                return;
            }

            if (!ValidateNotEmpty(txtNama, "Nama")) return;
            if (!ValidateNumeric(txtIPK, "IPK", out double ipk)) return;
            if (!ValidateRange(ipk, 0, 4, "IPK")) return;

            if (ShowConfirmation("Apakah Anda yakin ingin mengupdate data ini?") == DialogResult.Yes)
            {
                var result = _controller.UpdateMahasiswa(
                    _selectedId, txtNIM.Text, txtNama.Text,
                    cboJurusan.Text, ipk, cboStatus.Text);

                if (result.IsSuccess)
                {
                    ShowSuccess(result.Message);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    ShowError(result.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                ShowWarning("Silakan pilih data yang akan dihapus!");
                return;
            }

            if (ShowConfirmation($"Apakah Anda yakin ingin menghapus data {txtNama.Text}?") == DialogResult.Yes)
            {
                var result = _controller.HapusMahasiswa(_selectedId);

                if (result.IsSuccess)
                {
                    ShowSuccess(result.Message);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    ShowError(result.Message);
                }
            }
        }

        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMahasiswa.Rows[e.RowIndex];
                _selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNIM.Text = row.Cells["NIM"].Value.ToString();
                txtNama.Text = row.Cells["Nama"].Value.ToString();
                cboJurusan.Text = row.Cells["Jurusan"].Value.ToString();
                txtIPK.Text = row.Cells["IPK"].Value.ToString();
                cboStatus.Text = row.Cells["Status"].Value.ToString();
                txtNIM.Enabled = false;
            }
        }

        // Event handler: Tombol Mahasiswa Berprestasi
        private void btnBerprestasi_Click(object sender, EventArgs e)
        {
            var result = _controller.GetMahasiswaBerprestasi();
            HandleResult(result, data =>
            {
                dgvMahasiswa.DataSource = data;
                FormatDataGridView();
                ShowSuccess($"Ditemukan {data.Count} mahasiswa berprestasi (IPK ≥ 3.0)");
            });
        }

        // Event handler: Tombol Statistik
        private void btnStatistik_Click(object sender, EventArgs e)
        {
            // Buka form statistik
            using (FormStatistik formStat = new FormStatistik())
            {
                formStat.ShowDialog();
            }
        }

        // Event handler: Tombol Cari
        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();

            var result = _controller.CariMahasiswa(keyword);
            HandleResult(result, data =>
            {
                dgvMahasiswa.DataSource = data;
                FormatDataGridView();

                if (data.Count == 0)
                {
                    ShowWarning("Data tidak ditemukan!");
                }
                else
                {
                    ShowSuccess($"Ditemukan {data.Count} data");
                }
            });
        }

        // Event handler: Tombol Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllData();
            ClearFields();
            txtCari.Clear();
        }

        // Load all data
        private void LoadAllData()
        {
            var result = _controller.GetAllMahasiswa();
            HandleResult(result, data =>
            {
                dgvMahasiswa.DataSource = data;
                FormatDataGridView();
            });
        }


        // Clear all input fields
        private void ClearFields()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtIPK.Clear();
            cboJurusan.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            _selectedId = 0;
            txtNIM.Enabled = true;
            txtNIM.Focus();
        }

        protected override void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtIPK.Clear();
            cboJurusan.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            _selectedId = 0;
            txtNIM.Enabled = true;
        }

        private void ClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}