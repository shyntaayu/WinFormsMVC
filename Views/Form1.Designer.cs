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
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.Label lblIPK;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox grpAksi;

        private void InitializeComponent()
        {
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cboJurusan = new System.Windows.Forms.ComboBox();
            this.txtIPK = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBerprestasi = new System.Windows.Forms.Button();
            this.btnStatistik = new System.Windows.Forms.Button();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblJurusan = new System.Windows.Forms.Label();
            this.lblIPK = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.grpAksi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.grpData.SuspendLayout();
            this.grpAksi.SuspendLayout();
            this.SuspendLayout();

            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.AllowUserToAddRows = false;
            this.dgvMahasiswa.AllowUserToDeleteRows = false;
            this.dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(12, 200);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.ReadOnly = true;
            this.dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMahasiswa.Size = new System.Drawing.Size(776, 300);
            this.dgvMahasiswa.TabIndex = 0;
            this.dgvMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellClick);

            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.lblNIM);
            this.grpData.Controls.Add(this.txtNIM);
            this.grpData.Controls.Add(this.lblNama);
            this.grpData.Controls.Add(this.txtNama);
            this.grpData.Controls.Add(this.lblJurusan);
            this.grpData.Controls.Add(this.cboJurusan);
            this.grpData.Controls.Add(this.lblIPK);
            this.grpData.Controls.Add(this.txtIPK);
            this.grpData.Controls.Add(this.lblStatus);
            this.grpData.Controls.Add(this.cboStatus);
            this.grpData.Location = new System.Drawing.Point(12, 12);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(500, 180);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data Mahasiswa";

            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Location = new System.Drawing.Point(20, 30);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(31, 13);
            this.lblNIM.Text = "NIM:";

            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(100, 27);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(380, 20);
            this.txtNIM.TabIndex = 0;

            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(20, 60);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(38, 13);
            this.lblNama.Text = "Nama:";

            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(100, 57);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(380, 20);
            this.txtNama.TabIndex = 1;

            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(20, 90);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(50, 13);
            this.lblJurusan.Text = "Jurusan:";

            // 
            // cboJurusan
            // 
            this.cboJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJurusan.FormattingEnabled = true;
            this.cboJurusan.Items.AddRange(new object[] {
            "Informatika",
            "Sistem Informasi",
            "Teknologi Informasi"});
            this.cboJurusan.Location = new System.Drawing.Point(100, 87);
            this.cboJurusan.Name = "cboJurusan";
            this.cboJurusan.Size = new System.Drawing.Size(380, 21);
            this.cboJurusan.TabIndex = 2;

            // 
            // lblIPK
            // 
            this.lblIPK.AutoSize = true;
            this.lblIPK.Location = new System.Drawing.Point(20, 120);
            this.lblIPK.Name = "lblIPK";
            this.lblIPK.Size = new System.Drawing.Size(28, 13);
            this.lblIPK.Text = "IPK:";

            // 
            // txtIPK
            // 
            this.txtIPK.Location = new System.Drawing.Point(100, 117);
            this.txtIPK.Name = "txtIPK";
            this.txtIPK.Size = new System.Drawing.Size(380, 20);
            this.txtIPK.TabIndex = 3;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.Text = "Status:";

            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Aktif",
            "Cuti",
            "Lulus",
            "Keluar"});
            this.cboStatus.Location = new System.Drawing.Point(100, 147);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(380, 21);
            this.cboStatus.TabIndex = 4;

            // 
            // grpAksi
            // 
            this.grpAksi.Controls.Add(this.btnTambah);
            this.grpAksi.Controls.Add(this.btnUpdate);
            this.grpAksi.Controls.Add(this.btnHapus);
            this.grpAksi.Controls.Add(this.btnBerprestasi);
            this.grpAksi.Controls.Add(this.btnStatistik);
            this.grpAksi.Location = new System.Drawing.Point(520, 12);
            this.grpAksi.Name = "grpAksi";
            this.grpAksi.Size = new System.Drawing.Size(268, 180);
            this.grpAksi.TabIndex = 2;
            this.grpAksi.TabStop = false;
            this.grpAksi.Text = "Aksi";

            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(20, 27);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(228, 23);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(20, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(20, 87);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(228, 23);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // 
            // btnBerprestasi
            // 
            this.btnBerprestasi.Location = new System.Drawing.Point(20, 117);
            this.btnBerprestasi.Name = "btnBerprestasi";
            this.btnBerprestasi.Size = new System.Drawing.Size(228, 23);
            this.btnBerprestasi.TabIndex = 3;
            this.btnBerprestasi.Text = "Mahasiswa Berprestasi";
            this.btnBerprestasi.UseVisualStyleBackColor = true;
            this.btnBerprestasi.Click += new System.EventHandler(this.btnBerprestasi_Click);

            // 
            // btnStatistik
            // 
            this.btnStatistik.Location = new System.Drawing.Point(20, 147);
            this.btnStatistik.Name = "btnStatistik";
            this.btnStatistik.Size = new System.Drawing.Size(228, 23);
            this.btnStatistik.TabIndex = 4;
            this.btnStatistik.Text = "Lihat Statistik";
            this.btnStatistik.UseVisualStyleBackColor = true;
            this.btnStatistik.Click += new System.EventHandler(this.btnStatistik_Click);

            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(12, 510);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(600, 20);
            this.txtCari.TabIndex = 3;

            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(620, 508);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 23);
            this.btnCari.TabIndex = 4;
                this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);

            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(708, 508);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.grpAksi);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.dgvMahasiswa);
            this.Name = "FormMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Data Mahasiswa - FASILKOM UNEJ";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpAksi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
