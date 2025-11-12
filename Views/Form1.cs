using WinFormsMVC.Controllers;

namespace WinFormsMVC
{
    public partial class Form1 : Form
    {
        private MahasiswaController controller;
        private int selectedId = 0;

        public Form1()
        {
            InitializeComponent();
            controller = new MahasiswaController();
        }

        // Event ketika form pertama kali dibuka
        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            LoadData();
            SetDefaultValues();
        }

        // Method untuk load data ke DataGridView
        private void LoadData()
        {
            try
            {
                var data = controller.GetAllMahasiswa();
                dgvMahasiswa.DataSource = data;

                // Atur lebar kolom
                dgvMahasiswa.Columns["Id"].Width = 50;
                dgvMahasiswa.Columns["NIM"].Width = 120;
                dgvMahasiswa.Columns["Nama"].Width = 200;
                dgvMahasiswa.Columns["Jurusan"].Width = 150;
                dgvMahasiswa.Columns["IPK"].Width = 80;
                dgvMahasiswa.Columns["Status"].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Set nilai default untuk input
        private void SetDefaultValues()
        {
            cboJurusan.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            selectedId = 0;
        }

        // Clear semua input field
        private void ClearFields()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtIPK.Clear();
            cboJurusan.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            selectedId = 0;
            txtNIM.Enabled = true; // Enable NIM untuk input baru
        }

        // Event tombol Tambah
        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi IPK harus angka
                if (!double.TryParse(txtIPK.Text, out double ipk))
                {
                    MessageBox.Show("IPK harus berupa angka!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Panggil controller untuk tambah data
                bool success = controller.TambahMahasiswa(
                    txtNIM.Text,
                    txtNama.Text,
                    cboJurusan.Text,
                    ipk
                );

                if (success)
                {
                    MessageBox.Show("Data mahasiswa berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event tombol Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == 0)
                {
                    MessageBox.Show("Silakan pilih data yang akan diupdate!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi IPK
                if (!double.TryParse(txtIPK.Text, out double ipk))
                {
                    MessageBox.Show("IPK harus berupa angka!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Konfirmasi update
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin mengupdate data ini?",
                    "Konfirmasi Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    bool success = controller.UpdateMahasiswa(
                        selectedId,
                        txtNIM.Text,
                        txtNama.Text,
                        cboJurusan.Text,
                        ipk,
                        cboStatus.Text
                    );

                    if (success)
                    {
                        MessageBox.Show("Data mahasiswa berhasil diupdate!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event tombol Hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == 0)
                {
                    MessageBox.Show("Silakan pilih data yang akan dihapus!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Konfirmasi hapus
                DialogResult result = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus data {txtNama.Text}?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    bool success = controller.HapusMahasiswa(selectedId);

                    if (success)
                    {
                        MessageBox.Show("Data mahasiswa berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event tombol Cari
        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtCari.Text;
                var data = controller.CariMahasiswa(keyword);
                dgvMahasiswa.DataSource = data;

                if (data.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event tombol Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
            txtCari.Clear();
        }

        // Event tombol Mahasiswa Berprestasi
        private void btnBerprestasi_Click(object sender, EventArgs e)
        {
            try
            {
                var data = controller.GetMahasiswaBerprestasi();
                dgvMahasiswa.DataSource = data;

                MessageBox.Show($"Ditemukan {data.Count} mahasiswa berprestasi (IPK ? 3.0)",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event tombol Statistik
        private void btnStatistik_Click(object sender, EventArgs e)
        {
            try
            {
                var statistik = controller.GetStatistik();

                string message = "STATISTIK MAHASISWA PER JURUSAN\n\n";
                foreach (var item in statistik)
                {
                    message += $"{item.Key}: {item.Value} mahasiswa\n";
                }

                MessageBox.Show(message, "Statistik",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event ketika user klik pada row di DataGridView
        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvMahasiswa.Rows[e.RowIndex];

                    selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                    txtNIM.Text = row.Cells["NIM"].Value.ToString();
                    txtNama.Text = row.Cells["Nama"].Value.ToString();
                    cboJurusan.Text = row.Cells["Jurusan"].Value.ToString();
                    txtIPK.Text = row.Cells["IPK"].Value.ToString();
                    cboStatus.Text = row.Cells["Status"].Value.ToString();

                    txtNIM.Enabled = false; // Disable NIM saat edit
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
