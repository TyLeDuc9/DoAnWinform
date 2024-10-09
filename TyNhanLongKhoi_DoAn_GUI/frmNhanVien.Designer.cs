namespace TyNhanLongKhoi_DoAn_GUI
{
    partial class frmNhanVien
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
            this.grbQuanLyDocGia = new System.Windows.Forms.GroupBox();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtEmailNhanVien = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDTNhanVien = new System.Windows.Forms.TextBox();
            this.txtHoTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaySinhDocGia = new System.Windows.Forms.Label();
            this.lblHoTenDocGia = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnCapNhatNhanVien = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.grbTimKiemSach = new System.Windows.Forms.GroupBox();
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.btnTimNhanVien = new System.Windows.Forms.Button();
            this.lblTimKiemSach = new System.Windows.Forms.Label();
            this.MDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyDocGia.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.grbTimKiemSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbQuanLyDocGia
            // 
            this.grbQuanLyDocGia.BackColor = System.Drawing.Color.LightBlue;
            this.grbQuanLyDocGia.Controls.Add(this.chkNu);
            this.grbQuanLyDocGia.Controls.Add(this.chkNam);
            this.grbQuanLyDocGia.Controls.Add(this.lblGioiTinh);
            this.grbQuanLyDocGia.Controls.Add(this.txtEmailNhanVien);
            this.grbQuanLyDocGia.Controls.Add(this.lblEmail);
            this.grbQuanLyDocGia.Controls.Add(this.dtpNgaySinh);
            this.grbQuanLyDocGia.Controls.Add(this.txtSDTNhanVien);
            this.grbQuanLyDocGia.Controls.Add(this.txtHoTenNhanVien);
            this.grbQuanLyDocGia.Controls.Add(this.txtMaNhanVien);
            this.grbQuanLyDocGia.Controls.Add(this.lblSDT);
            this.grbQuanLyDocGia.Controls.Add(this.lblNgaySinhDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblHoTenDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblMaDocGia);
            this.grbQuanLyDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyDocGia.Location = new System.Drawing.Point(1, 1);
            this.grbQuanLyDocGia.Name = "grbQuanLyDocGia";
            this.grbQuanLyDocGia.Size = new System.Drawing.Size(799, 205);
            this.grbQuanLyDocGia.TabIndex = 2;
            this.grbQuanLyDocGia.TabStop = false;
            this.grbQuanLyDocGia.Text = "Quản Lý  Nhân Viên";
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNu.Location = new System.Drawing.Point(649, 124);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(49, 21);
            this.chkNu.TabIndex = 5;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNam.Location = new System.Drawing.Point(558, 124);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(59, 21);
            this.chkNam.TabIndex = 4;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(417, 121);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(118, 27);
            this.lblGioiTinh.TabIndex = 15;
            this.lblGioiTinh.Text = "Giới Tính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmailNhanVien
            // 
            this.txtEmailNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailNhanVien.Location = new System.Drawing.Point(541, 79);
            this.txtEmailNhanVien.Name = "txtEmailNhanVien";
            this.txtEmailNhanVien.Size = new System.Drawing.Size(233, 18);
            this.txtEmailNhanVien.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(417, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(118, 27);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(541, 34);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(246, 25);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // txtSDTNhanVien
            // 
            this.txtSDTNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDTNhanVien.Location = new System.Drawing.Point(146, 125);
            this.txtSDTNhanVien.Name = "txtSDTNhanVien";
            this.txtSDTNhanVien.Size = new System.Drawing.Size(233, 18);
            this.txtSDTNhanVien.TabIndex = 3;
            // 
            // txtHoTenNhanVien
            // 
            this.txtHoTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTenNhanVien.Location = new System.Drawing.Point(146, 79);
            this.txtHoTenNhanVien.Name = "txtHoTenNhanVien";
            this.txtHoTenNhanVien.Size = new System.Drawing.Size(233, 18);
            this.txtHoTenNhanVien.TabIndex = 2;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNhanVien.Location = new System.Drawing.Point(146, 34);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(233, 18);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(15, 120);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(118, 27);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số Điện Thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgaySinhDocGia
            // 
            this.lblNgaySinhDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinhDocGia.Location = new System.Drawing.Point(417, 34);
            this.lblNgaySinhDocGia.Name = "lblNgaySinhDocGia";
            this.lblNgaySinhDocGia.Size = new System.Drawing.Size(118, 27);
            this.lblNgaySinhDocGia.TabIndex = 3;
            this.lblNgaySinhDocGia.Text = "Ngày Sinh";
            this.lblNgaySinhDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoTenDocGia
            // 
            this.lblHoTenDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenDocGia.Location = new System.Drawing.Point(15, 75);
            this.lblHoTenDocGia.Name = "lblHoTenDocGia";
            this.lblHoTenDocGia.Size = new System.Drawing.Size(118, 27);
            this.lblHoTenDocGia.TabIndex = 2;
            this.lblHoTenDocGia.Text = "Họ Tên";
            this.lblHoTenDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDocGia.Location = new System.Drawing.Point(15, 34);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(118, 27);
            this.lblMaDocGia.TabIndex = 1;
            this.lblMaDocGia.Text = "Mã Nhân Viên";
            this.lblMaDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnThemNhanVien);
            this.panel1.Controls.Add(this.btnCapNhatNhanVien);
            this.panel1.Controls.Add(this.btnSuaNhanVien);
            this.panel1.Controls.Add(this.btnXoaNhanVien);
            this.panel1.Location = new System.Drawing.Point(1, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 70);
            this.panel1.TabIndex = 14;
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.Location = new System.Drawing.Point(34, 14);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(99, 45);
            this.btnThemNhanVien.TabIndex = 9;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatNhanVien
            // 
            this.btnCapNhatNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatNhanVien.Location = new System.Drawing.Point(649, 14);
            this.btnCapNhatNhanVien.Name = "btnCapNhatNhanVien";
            this.btnCapNhatNhanVien.Size = new System.Drawing.Size(99, 45);
            this.btnCapNhatNhanVien.TabIndex = 12;
            this.btnCapNhatNhanVien.Text = "Cập Nhật";
            this.btnCapNhatNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhanVien.Location = new System.Drawing.Point(219, 14);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(99, 45);
            this.btnSuaNhanVien.TabIndex = 10;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhanVien.Location = new System.Drawing.Point(420, 14);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(99, 45);
            this.btnXoaNhanVien.TabIndex = 11;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MDG,
            this.HT,
            this.SDT,
            this.GT,
            this.NS,
            this.Mail});
            this.dgvNhanVien.Location = new System.Drawing.Point(1, 357);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(799, 196);
            this.dgvNhanVien.TabIndex = 15;
            // 
            // grbTimKiemSach
            // 
            this.grbTimKiemSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbTimKiemSach.Controls.Add(this.txtTimKiemNhanVien);
            this.grbTimKiemSach.Controls.Add(this.btnTimNhanVien);
            this.grbTimKiemSach.Controls.Add(this.lblTimKiemSach);
            this.grbTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemSach.Location = new System.Drawing.Point(1, 288);
            this.grbTimKiemSach.Name = "grbTimKiemSach";
            this.grbTimKiemSach.Size = new System.Drawing.Size(799, 66);
            this.grbTimKiemSach.TabIndex = 18;
            this.grbTimKiemSach.TabStop = false;
            this.grbTimKiemSach.Text = "Tìm Kiếm";
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(340, 22);
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(233, 25);
            this.txtTimKiemNhanVien.TabIndex = 13;
            // 
            // btnTimNhanVien
            // 
            this.btnTimNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNhanVien.Location = new System.Drawing.Point(579, 19);
            this.btnTimNhanVien.Name = "btnTimNhanVien";
            this.btnTimNhanVien.Size = new System.Drawing.Size(86, 33);
            this.btnTimNhanVien.TabIndex = 14;
            this.btnTimNhanVien.Text = "Tìm Kiếm";
            this.btnTimNhanVien.UseVisualStyleBackColor = true;
            // 
            // lblTimKiemSach
            // 
            this.lblTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemSach.Location = new System.Drawing.Point(36, 24);
            this.lblTimKiemSach.Name = "lblTimKiemSach";
            this.lblTimKiemSach.Size = new System.Drawing.Size(298, 23);
            this.lblTimKiemSach.TabIndex = 0;
            this.lblTimKiemSach.Text = "Nhập thông tin (tên hoặc mã nhân viên )";
            this.lblTimKiemSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MDG
            // 
            this.MDG.HeaderText = "Mã ĐG";
            this.MDG.MinimumWidth = 6;
            this.MDG.Name = "MDG";
            this.MDG.ReadOnly = true;
            this.MDG.Width = 125;
            // 
            // HT
            // 
            this.HT.HeaderText = "Họ Tên";
            this.HT.MinimumWidth = 6;
            this.HT.Name = "HT";
            this.HT.ReadOnly = true;
            this.HT.Width = 125;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số ĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // GT
            // 
            this.GT.HeaderText = "Giới Tính";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            this.GT.ReadOnly = true;
            this.GT.Width = 125;
            // 
            // NS
            // 
            this.NS.HeaderText = "Ngày Sinh";
            this.NS.MinimumWidth = 6;
            this.NS.Name = "NS";
            this.NS.ReadOnly = true;
            this.NS.Width = 125;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Email";
            this.Mail.MinimumWidth = 6;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 125;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.grbTimKiemSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbQuanLyDocGia);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.grbQuanLyDocGia.ResumeLayout(false);
            this.grbQuanLyDocGia.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.grbTimKiemSach.ResumeLayout(false);
            this.grbTimKiemSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbQuanLyDocGia;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtEmailNhanVien;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSDTNhanVien;
        private System.Windows.Forms.TextBox txtHoTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNgaySinhDocGia;
        private System.Windows.Forms.Label lblHoTenDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnCapNhatNhanVien;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox grbTimKiemSach;
        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
        private System.Windows.Forms.Button btnTimNhanVien;
        private System.Windows.Forms.Label lblTimKiemSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    }
}