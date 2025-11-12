namespace WinFormsMVC.Views
{
    partial class FormStatistik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

                #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpJumlah = new System.Windows.Forms.GroupBox();
            this.dgvJumlah = new System.Windows.Forms.DataGridView();
            this.grpIPK = new System.Windows.Forms.GroupBox();
            this.dgvIPK = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.grpJumlah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJumlah)).BeginInit();
            this.grpIPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(684, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(185, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STATISTIK DATA MAHASISWA";
            // 
            // grpJumlah
            // 
            this.grpJumlah.Controls.Add(this.dgvJumlah);
            this.grpJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJumlah.Location = new System.Drawing.Point(12, 75);
            this.grpJumlah.Name = "grpJumlah";
            this.grpJumlah.Size = new System.Drawing.Size(660, 200);
            this.grpJumlah.TabIndex = 1;
            this.grpJumlah.TabStop = false;
            this.grpJumlah.Text = "Jumlah Mahasiswa Per Jurusan";
            // 
            // dgvJumlah
            // 
            this.dgvJumlah.AllowUserToAddRows = false;
            this.dgvJumlah.AllowUserToDeleteRows = false;
            this.dgvJumlah.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJumlah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJumlah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJumlah.Location = new System.Drawing.Point(3, 17);
            this.dgvJumlah.Name = "dgvJumlah";
            this.dgvJumlah.ReadOnly = true;
            this.dgvJumlah.Size = new System.Drawing.Size(654, 180);
            this.dgvJumlah.TabIndex = 0;
            // 
            // grpIPK
            // 
            this.grpIPK.Controls.Add(this.dgvIPK);
            this.grpIPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIPK.Location = new System.Drawing.Point(12, 285);
            this.grpIPK.Name = "grpIPK";
            this.grpIPK.Size = new System.Drawing.Size(660, 200);
            this.grpIPK.TabIndex = 2;
            this.grpIPK.TabStop = false;
            this.grpIPK.Text = "Rata-rata IPK Per Jurusan";
            // 
            // dgvIPK
            // 
            this.dgvIPK.AllowUserToAddRows = false;
            this.dgvIPK.AllowUserToDeleteRows = false;
            this.dgvIPK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIPK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIPK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIPK.Location = new System.Drawing.Point(3, 17);
            this.dgvIPK.Name = "dgvIPK";
            this.dgvIPK.ReadOnly = true;
            this.dgvIPK.Size = new System.Drawing.Size(654, 180);
            this.dgvIPK.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(277, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Tutup";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormStatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 541);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpIPK);
            this.Controls.Add(this.grpJumlah);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistik Mahasiswa - FASILKOM UNEJ";
            this.Load += new System.EventHandler(this.FormStatistik_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.grpJumlah.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJumlah)).EndInit();
            this.grpIPK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpJumlah;
        private System.Windows.Forms.DataGridView dgvJumlah;
        private System.Windows.Forms.GroupBox grpIPK;
        private System.Windows.Forms.DataGridView dgvIPK;
        private System.Windows.Forms.Button btnClose;
    }
}