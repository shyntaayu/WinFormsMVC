namespace WinFormsMVC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cboJurusan;
        private System.Windows.Forms.TextBox txtIPK;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBerprestasi;
        private System.Windows.Forms.Button btnStatistik;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.Label lblIPK;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox grpAksi;

        private void InitializeComponent()
        {
            dgvMahasiswa = new DataGridView();
            txtNIM = new TextBox();
            txtNama = new TextBox();
            cboJurusan = new ComboBox();
            txtIPK = new TextBox();
            cboStatus = new ComboBox();
            txtCari = new TextBox();
            btnTambah = new Button();
            btnUpdate = new Button();
            btnHapus = new Button();
            btnCari = new Button();
            btnRefresh = new Button();
            btnBerprestasi = new Button();
            btnStatistik = new Button();
            btnClear = new Button();
            lblNIM = new Label();
            lblNama = new Label();
            lblJurusan = new Label();
            lblIPK = new Label();
            lblStatus = new Label();
            grpData = new GroupBox();
            grpAksi = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMahasiswa).BeginInit();
            grpData.SuspendLayout();
            grpAksi.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMahasiswa
            // 
            dgvMahasiswa.AllowUserToAddRows = false;
            dgvMahasiswa.AllowUserToDeleteRows = false;
            dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMahasiswa.Location = new Point(20, 436);
            dgvMahasiswa.Margin = new Padding(5, 6, 5, 6);
            dgvMahasiswa.Name = "dgvMahasiswa";
            dgvMahasiswa.ReadOnly = true;
            dgvMahasiswa.RowHeadersWidth = 62;
            dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMahasiswa.Size = new Size(1293, 253);
            dgvMahasiswa.TabIndex = 0;
            dgvMahasiswa.CellClick += dgvMahasiswa_CellClick;
            // 
            // txtNIM
            // 
            txtNIM.Location = new Point(167, 52);
            txtNIM.Margin = new Padding(5, 6, 5, 6);
            txtNIM.Name = "txtNIM";
            txtNIM.Size = new Size(631, 31);
            txtNIM.TabIndex = 0;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(167, 110);
            txtNama.Margin = new Padding(5, 6, 5, 6);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(631, 31);
            txtNama.TabIndex = 1;
            // 
            // cboJurusan
            // 
            cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJurusan.FormattingEnabled = true;
            cboJurusan.Items.AddRange(new object[] { "Informatika", "Sistem Informasi", "Teknologi Informasi" });
            cboJurusan.Location = new Point(167, 167);
            cboJurusan.Margin = new Padding(5, 6, 5, 6);
            cboJurusan.Name = "cboJurusan";
            cboJurusan.Size = new Size(631, 33);
            cboJurusan.TabIndex = 2;
            // 
            // txtIPK
            // 
            txtIPK.Location = new Point(167, 225);
            txtIPK.Margin = new Padding(5, 6, 5, 6);
            txtIPK.Name = "txtIPK";
            txtIPK.Size = new Size(631, 31);
            txtIPK.TabIndex = 3;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Aktif", "Cuti", "Lulus", "Keluar" });
            cboStatus.Location = new Point(167, 283);
            cboStatus.Margin = new Padding(5, 6, 5, 6);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(631, 33);
            cboStatus.TabIndex = 4;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(26, 720);
            txtCari.Margin = new Padding(5, 6, 5, 6);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(997, 31);
            txtCari.TabIndex = 3;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(33, 52);
            btnTambah.Margin = new Padding(5, 6, 5, 6);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(380, 44);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(33, 110);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(380, 44);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(33, 167);
            btnHapus.Margin = new Padding(5, 6, 5, 6);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(380, 44);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(1039, 716);
            btnCari.Margin = new Padding(5, 6, 5, 6);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(133, 44);
            btnCari.TabIndex = 4;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1186, 716);
            btnRefresh.Margin = new Padding(5, 6, 5, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 44);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBerprestasi
            // 
            btnBerprestasi.Location = new Point(33, 225);
            btnBerprestasi.Margin = new Padding(5, 6, 5, 6);
            btnBerprestasi.Name = "btnBerprestasi";
            btnBerprestasi.Size = new Size(380, 44);
            btnBerprestasi.TabIndex = 3;
            btnBerprestasi.Text = "Mahasiswa Berprestasi";
            btnBerprestasi.UseVisualStyleBackColor = true;
            btnBerprestasi.Click += btnBerprestasi_Click;
            // 
            // btnStatistik
            // 
            btnStatistik.Location = new Point(33, 283);
            btnStatistik.Margin = new Padding(5, 6, 5, 6);
            btnStatistik.Name = "btnStatistik";
            btnStatistik.Size = new Size(380, 44);
            btnStatistik.TabIndex = 4;
            btnStatistik.Text = "Lihat Statistik";
            btnStatistik.UseVisualStyleBackColor = true;
            btnStatistik.Click += btnStatistik_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(33, 341);
            btnClear.Margin = new Padding(5, 6, 5, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(380, 44);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += ClearForm_Click;
            // 
            // lblNIM
            // 
            lblNIM.AutoSize = true;
            lblNIM.Location = new Point(33, 58);
            lblNIM.Margin = new Padding(5, 0, 5, 0);
            lblNIM.Name = "lblNIM";
            lblNIM.Size = new Size(50, 25);
            lblNIM.TabIndex = 0;
            lblNIM.Text = "NIM:";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(33, 115);
            lblNama.Margin = new Padding(5, 0, 5, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(63, 25);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama:";
            // 
            // lblJurusan
            // 
            lblJurusan.AutoSize = true;
            lblJurusan.Location = new Point(33, 173);
            lblJurusan.Margin = new Padding(5, 0, 5, 0);
            lblJurusan.Name = "lblJurusan";
            lblJurusan.Size = new Size(75, 25);
            lblJurusan.TabIndex = 2;
            lblJurusan.Text = "Jurusan:";
            // 
            // lblIPK
            // 
            lblIPK.AutoSize = true;
            lblIPK.Location = new Point(33, 231);
            lblIPK.Margin = new Padding(5, 0, 5, 0);
            lblIPK.Name = "lblIPK";
            lblIPK.Size = new Size(41, 25);
            lblIPK.TabIndex = 3;
            lblIPK.Text = "IPK:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(33, 288);
            lblStatus.Margin = new Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // grpData
            // 
            grpData.Controls.Add(lblNIM);
            grpData.Controls.Add(txtNIM);
            grpData.Controls.Add(lblNama);
            grpData.Controls.Add(txtNama);
            grpData.Controls.Add(lblJurusan);
            grpData.Controls.Add(cboJurusan);
            grpData.Controls.Add(lblIPK);
            grpData.Controls.Add(txtIPK);
            grpData.Controls.Add(lblStatus);
            grpData.Controls.Add(cboStatus);
            grpData.Location = new Point(20, 23);
            grpData.Margin = new Padding(5, 6, 5, 6);
            grpData.Name = "grpData";
            grpData.Padding = new Padding(5, 6, 5, 6);
            grpData.Size = new Size(833, 401);
            grpData.TabIndex = 1;
            grpData.TabStop = false;
            grpData.Text = "Data Mahasiswa";
            // 
            // grpAksi
            // 
            grpAksi.Controls.Add(btnTambah);
            grpAksi.Controls.Add(btnUpdate);
            grpAksi.Controls.Add(btnHapus);
            grpAksi.Controls.Add(btnBerprestasi);
            grpAksi.Controls.Add(btnStatistik);
            grpAksi.Controls.Add(btnClear);
            grpAksi.Location = new Point(867, 23);
            grpAksi.Margin = new Padding(5, 6, 5, 6);
            grpAksi.Name = "grpAksi";
            grpAksi.Padding = new Padding(5, 6, 5, 6);
            grpAksi.Size = new Size(447, 401);
            grpAksi.TabIndex = 2;
            grpAksi.TabStop = false;
            grpAksi.Text = "Aksi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 779);
            Controls.Add(btnRefresh);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(grpAksi);
            Controls.Add(grpData);
            Controls.Add(dgvMahasiswa);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Data Mahasiswa - FASILKOM UNEJ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMahasiswa).EndInit();
            grpData.ResumeLayout(false);
            grpData.PerformLayout();
            grpAksi.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
