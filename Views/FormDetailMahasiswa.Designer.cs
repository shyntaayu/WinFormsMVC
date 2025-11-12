namespace WinFormsMVC.Views
{
    partial class FormDetailMahasiswa
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

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.lblBadge = new System.Windows.Forms.Label();
            this.panelGrade = new System.Windows.Forms.Panel();
            this.lblGradeValue = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.panelKelulusan = new System.Windows.Forms.Panel();
            this.lblKelulusanValue = new System.Windows.Forms.Label();
            this.lblKelulusan = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblIPK = new System.Windows.Forms.Label();
            this.lblIPKValue = new System.Windows.Forms.Label();
            this.lblJurusan = new System.Windows.Forms.Label();
            this.lblJurusanValue = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNamaValue = new System.Windows.Forms.Label();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblNIMValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.panelGrade.SuspendLayout();
            this.panelKelulusan.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(90, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DETAIL DATA MAHASISWA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.lblBadge);
            this.grpDetail.Controls.Add(this.panelGrade);
            this.grpDetail.Controls.Add(this.panelKelulusan);
            this.grpDetail.Controls.Add(this.lblStatus);
            this.grpDetail.Controls.Add(this.lblStatusValue);
            this.grpDetail.Controls.Add(this.lblIPK);
            this.grpDetail.Controls.Add(this.lblIPKValue);
            this.grpDetail.Controls.Add(this.lblJurusan);
            this.grpDetail.Controls.Add(this.lblJurusanValue);
            this.grpDetail.Controls.Add(this.lblNama);
            this.grpDetail.Controls.Add(this.lblNamaValue);
            this.grpDetail.Controls.Add(this.lblNIM);
            this.grpDetail.Controls.Add(this.lblNIMValue);
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetail.Location = new System.Drawing.Point(12, 85);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(476, 420);
            this.grpDetail.TabIndex = 1;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Informasi Mahasiswa";
            // 
            // lblBadge
            // 
            this.lblBadge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBadge.AutoSize = true;
            this.lblBadge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadge.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBadge.Location = new System.Drawing.Point(70, 375);
            this.lblBadge.Name = "lblBadge";
            this.lblBadge.Size = new System.Drawing.Size(336, 25);
            this.lblBadge.TabIndex = 12;
            this.lblBadge.Text = "⭐ MAHASISWA BERPRESTASI";
            this.lblBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBadge.Visible = false;
            // 
            // panelGrade
            // 
            this.panelGrade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrade.Controls.Add(this.lblGradeValue);
            this.panelGrade.Controls.Add(this.lblGrade);
            this.panelGrade.Location = new System.Drawing.Point(30, 310);
            this.panelGrade.Name = "panelGrade";
            this.panelGrade.Size = new System.Drawing.Size(416, 50);
            this.panelGrade.TabIndex = 11;
            // 
            // lblGradeValue
            // 
            this.lblGradeValue.AutoSize = true;
            this.lblGradeValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeValue.Location = new System.Drawing.Point(150, 14);
            this.lblGradeValue.Name = "lblGradeValue";
            this.lblGradeValue.Size = new System.Drawing.Size(15, 19);
            this.lblGradeValue.TabIndex = 1;
            this.lblGradeValue.Text = "-";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(10, 14);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(50, 19);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Grade";
            // 
            // panelKelulusan
            // 
            this.panelKelulusan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelKelulusan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKelulusan.Controls.Add(this.lblKelulusanValue);
            this.panelKelulusan.Controls.Add(this.lblKelulusan);
            this.panelKelulusan.Location = new System.Drawing.Point(30, 250);
            this.panelKelulusan.Name = "panelKelulusan";
            this.panelKelulusan.Size = new System.Drawing.Size(416, 50);
            this.panelKelulusan.TabIndex = 10;
            // 
            // lblKelulusanValue
            // 
            this.lblKelulusanValue.AutoSize = true;
            this.lblKelulusanValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelulusanValue.Location = new System.Drawing.Point(150, 14);
            this.lblKelulusanValue.Name = "lblKelulusanValue";
            this.lblKelulusanValue.Size = new System.Drawing.Size(15, 19);
            this.lblKelulusanValue.TabIndex = 1;
            this.lblKelulusanValue.Text = "-";
            // 
            // lblKelulusan
            // 
            this.lblKelulusan.AutoSize = true;
            this.lblKelulusan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelulusan.Location = new System.Drawing.Point(10, 14);
            this.lblKelulusan.Name = "lblKelulusan";
            this.lblKelulusan.Size = new System.Drawing.Size(123, 19);
            this.lblKelulusan.TabIndex = 0;
            this.lblKelulusan.Text = "Status Kelulusan";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(30, 210);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 19);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusValue.Location = new System.Drawing.Point(200, 210);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(15, 19);
            this.lblStatusValue.TabIndex = 9;
            this.lblStatusValue.Text = "-";
            // 
            // lblIPK
            // 
            this.lblIPK.AutoSize = true;
            this.lblIPK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPK.Location = new System.Drawing.Point(30, 170);
            this.lblIPK.Name = "lblIPK";
            this.lblIPK.Size = new System.Drawing.Size(33, 19);
            this.lblIPK.TabIndex = 6;
            this.lblIPK.Text = "IPK";
            // 
            // lblIPKValue
            // 
            this.lblIPKValue.AutoSize = true;
            this.lblIPKValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPKValue.Location = new System.Drawing.Point(200, 170);
            this.lblIPKValue.Name = "lblIPKValue";
            this.lblIPKValue.Size = new System.Drawing.Size(15, 19);
            this.lblIPKValue.TabIndex = 7;
            this.lblIPKValue.Text = "-";
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurusan.Location = new System.Drawing.Point(30, 130);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(63, 19);
            this.lblJurusan.TabIndex = 4;
            this.lblJurusan.Text = "Jurusan";
            // 
            // lblJurusanValue
            // 
            this.lblJurusanValue.AutoSize = true;
            this.lblJurusanValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurusanValue.Location = new System.Drawing.Point(200, 130);
            this.lblJurusanValue.Name = "lblJurusanValue";
            this.lblJurusanValue.Size = new System.Drawing.Size(15, 19);
            this.lblJurusanValue.TabIndex = 5;
            this.lblJurusanValue.Text = "-";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(30, 90);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(50, 19);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama";
            // 
            // lblNamaValue
            // 
            this.lblNamaValue.AutoSize = true;
            this.lblNamaValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaValue.Location = new System.Drawing.Point(200, 90);
            this.lblNamaValue.Name = "lblNamaValue";
            this.lblNamaValue.Size = new System.Drawing.Size(15, 19);
            this.lblNamaValue.TabIndex = 3;
            this.lblNamaValue.Text = "-";
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIM.Location = new System.Drawing.Point(30, 50);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(38, 19);
            this.lblNIM.TabIndex = 0;
            this.lblNIM.Text = "NIM";
            // 
            // lblNIMValue
            // 
            this.lblNIMValue.AutoSize = true;
            this.lblNIMValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIMValue.Location = new System.Drawing.Point(200, 50);
            this.lblNIMValue.Name = "lblNIMValue";
            this.lblNIMValue.Size = new System.Drawing.Size(15, 19);
            this.lblNIMValue.TabIndex = 1;
            this.lblNIMValue.Text = "-";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(175, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "TUTUP";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 515);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(500, 65);
            this.panelFooter.TabIndex = 2;
            // 
            // FormDetailMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetailMahasiswa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Mahasiswa - FASILKOM UNEJ";
            this.Load += new System.EventHandler(this.FormDetailMahasiswa_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.panelGrade.ResumeLayout(false);
            this.panelGrade.PerformLayout();
            this.panelKelulusan.ResumeLayout(false);
            this.panelKelulusan.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblNIMValue;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNamaValue;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.Label lblJurusanValue;
        private System.Windows.Forms.Label lblIPK;
        private System.Windows.Forms.Label lblIPKValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Panel panelKelulusan;
        private System.Windows.Forms.Label lblKelulusanValue;
        private System.Windows.Forms.Label lblKelulusan;
        private System.Windows.Forms.Panel panelGrade;
        private System.Windows.Forms.Label lblGradeValue;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblBadge;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelFooter;
    }
}