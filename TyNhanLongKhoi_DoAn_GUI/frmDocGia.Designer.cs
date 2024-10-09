namespace TyNhanLongKhoi_DoAn_GUI
{
    partial class frmDocGia
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
            this.txtEmailDocGia = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDTDocGia = new System.Windows.Forms.TextBox();
            this.txtHoTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaySinhDocGia = new System.Windows.Forms.Label();
            this.lblHoTenDocGia = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.btnCapNhatDocGia = new System.Windows.Forms.Button();
            this.btnXoaDocGia = new System.Windows.Forms.Button();
            this.btnSuaDocGia = new System.Windows.Forms.Button();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.grbTimKiemSach = new System.Windows.Forms.GroupBox();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.lblTimKiemSach = new System.Windows.Forms.Label();
            this.lblTheThuVien = new System.Windows.Forms.Label();
            this.cmbTheThuVien = new System.Windows.Forms.ComboBox();
            this.MDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyDocGia.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.grbTimKiemSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbQuanLyDocGia
            // 
            this.grbQuanLyDocGia.BackColor = System.Drawing.Color.LightBlue;
            this.grbQuanLyDocGia.Controls.Add(this.cmbTheThuVien);
            this.grbQuanLyDocGia.Controls.Add(this.chkNu);
            this.grbQuanLyDocGia.Controls.Add(this.chkNam);
            this.grbQuanLyDocGia.Controls.Add(this.lblGioiTinh);
            this.grbQuanLyDocGia.Controls.Add(this.txtEmailDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblTheThuVien);
            this.grbQuanLyDocGia.Controls.Add(this.lblEmail);
            this.grbQuanLyDocGia.Controls.Add(this.dtpNgaySinh);
            this.grbQuanLyDocGia.Controls.Add(this.txtSDTDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.txtHoTenDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.txtMaDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblSDT);
            this.grbQuanLyDocGia.Controls.Add(this.lblNgaySinhDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblHoTenDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblMaDocGia);
            this.grbQuanLyDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyDocGia.Location = new System.Drawing.Point(1, 2);
            this.grbQuanLyDocGia.Name = "grbQuanLyDocGia";
            this.grbQuanLyDocGia.Size = new System.Drawing.Size(799, 198);
            this.grbQuanLyDocGia.TabIndex = 1;
            this.grbQuanLyDocGia.TabStop = false;
            this.grbQuanLyDocGia.Text = "Quản Lý  Độc Giả";
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNu.Location = new System.Drawing.Point(219, 170);
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
            this.chkNam.Location = new System.Drawing.Point(142, 170);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(59, 21);
            this.chkNam.TabIndex = 4;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(18, 166);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(118, 27);
            this.lblGioiTinh.TabIndex = 15;
            this.lblGioiTinh.Text = "Giới Tính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmailDocGia
            // 
            this.txtEmailDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailDocGia.Location = new System.Drawing.Point(541, 120);
            this.txtEmailDocGia.Name = "txtEmailDocGia";
            this.txtEmailDocGia.Size = new System.Drawing.Size(233, 18);
            this.txtEmailDocGia.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(417, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(118, 27);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(541, 34);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(246, 25);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // txtSDTDocGia
            // 
            this.txtSDTDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDTDocGia.Location = new System.Drawing.Point(541, 79);
            this.txtSDTDocGia.Name = "txtSDTDocGia";
            this.txtSDTDocGia.Size = new System.Drawing.Size(233, 18);
            this.txtSDTDocGia.TabIndex = 7;
            // 
            // txtHoTenDocGia
            // 
            this.txtHoTenDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTenDocGia.Location = new System.Drawing.Point(146, 120);
            this.txtHoTenDocGia.Name = "txtHoTenDocGia";
            this.txtHoTenDocGia.Size = new System.Drawing.Size(233, 18);
            this.txtHoTenDocGia.TabIndex = 3;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDocGia.Location = new System.Drawing.Point(146, 34);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(233, 18);
            this.txtMaDocGia.TabIndex = 1;
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(417, 79);
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
            this.lblHoTenDocGia.Location = new System.Drawing.Point(11, 116);
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
            this.lblMaDocGia.Text = "Mã Độc Giả";
            this.lblMaDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapNhatDocGia
            // 
            this.btnCapNhatDocGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDocGia.Location = new System.Drawing.Point(649, 14);
            this.btnCapNhatDocGia.Name = "btnCapNhatDocGia";
            this.btnCapNhatDocGia.Size = new System.Drawing.Size(99, 45);
            this.btnCapNhatDocGia.TabIndex = 12;
            this.btnCapNhatDocGia.Text = "Cập Nhật";
            this.btnCapNhatDocGia.UseVisualStyleBackColor = true;
            // 
            // btnXoaDocGia
            // 
            this.btnXoaDocGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDocGia.Location = new System.Drawing.Point(446, 14);
            this.btnXoaDocGia.Name = "btnXoaDocGia";
            this.btnXoaDocGia.Size = new System.Drawing.Size(99, 45);
            this.btnXoaDocGia.TabIndex = 11;
            this.btnXoaDocGia.Text = "Xóa";
            this.btnXoaDocGia.UseVisualStyleBackColor = true;
            // 
            // btnSuaDocGia
            // 
            this.btnSuaDocGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDocGia.Location = new System.Drawing.Point(230, 14);
            this.btnSuaDocGia.Name = "btnSuaDocGia";
            this.btnSuaDocGia.Size = new System.Drawing.Size(99, 45);
            this.btnSuaDocGia.TabIndex = 10;
            this.btnSuaDocGia.Text = "Sửa";
            this.btnSuaDocGia.UseVisualStyleBackColor = true;
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDocGia.Location = new System.Drawing.Point(34, 14);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(99, 45);
            this.btnThemDocGia.TabIndex = 9;
            this.btnThemDocGia.Text = "Thêm";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnThemDocGia);
            this.panel1.Controls.Add(this.btnCapNhatDocGia);
            this.panel1.Controls.Add(this.btnSuaDocGia);
            this.panel1.Controls.Add(this.btnXoaDocGia);
            this.panel1.Location = new System.Drawing.Point(1, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 70);
            this.panel1.TabIndex = 13;
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MDG,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDocGia.Location = new System.Drawing.Point(1, 354);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(799, 201);
            this.dgvDocGia.TabIndex = 15;
            // 
            // grbTimKiemSach
            // 
            this.grbTimKiemSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbTimKiemSach.Controls.Add(this.txtTimKiemSach);
            this.grbTimKiemSach.Controls.Add(this.btnTimKiemSach);
            this.grbTimKiemSach.Controls.Add(this.lblTimKiemSach);
            this.grbTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemSach.Location = new System.Drawing.Point(1, 282);
            this.grbTimKiemSach.Name = "grbTimKiemSach";
            this.grbTimKiemSach.Size = new System.Drawing.Size(799, 66);
            this.grbTimKiemSach.TabIndex = 17;
            this.grbTimKiemSach.TabStop = false;
            this.grbTimKiemSach.Text = "Tìm Kiếm";
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Location = new System.Drawing.Point(349, 19);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(233, 25);
            this.txtTimKiemSach.TabIndex = 13;
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSach.Location = new System.Drawing.Point(588, 15);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(86, 33);
            this.btnTimKiemSach.TabIndex = 14;
            this.btnTimKiemSach.Text = "Tìm Kiếm";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            // 
            // lblTimKiemSach
            // 
            this.lblTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemSach.Location = new System.Drawing.Point(45, 20);
            this.lblTimKiemSach.Name = "lblTimKiemSach";
            this.lblTimKiemSach.Size = new System.Drawing.Size(298, 23);
            this.lblTimKiemSach.TabIndex = 0;
            this.lblTimKiemSach.Text = "Nhập thông tin (tên hoặc mã độc giả )";
            this.lblTimKiemSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTheThuVien
            // 
            this.lblTheThuVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheThuVien.Location = new System.Drawing.Point(11, 70);
            this.lblTheThuVien.Name = "lblTheThuVien";
            this.lblTheThuVien.Size = new System.Drawing.Size(118, 27);
            this.lblTheThuVien.TabIndex = 13;
            this.lblTheThuVien.Text = "Thẻ Thư Viện";
            this.lblTheThuVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTheThuVien
            // 
            this.cmbTheThuVien.FormattingEnabled = true;
            this.cmbTheThuVien.Items.AddRange(new object[] {
            "Thẻ Sinh Viên",
            "Thẻ Giảng Viên"});
            this.cmbTheThuVien.Location = new System.Drawing.Point(146, 72);
            this.cmbTheThuVien.Name = "cmbTheThuVien";
            this.cmbTheThuVien.Size = new System.Drawing.Size(233, 25);
            this.cmbTheThuVien.TabIndex = 2;
            // 
            // MDG
            // 
            this.MDG.HeaderText = "Mã ĐG";
            this.MDG.MinimumWidth = 6;
            this.MDG.Name = "MDG";
            this.MDG.ReadOnly = true;
            this.MDG.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thẻ Thư Viện";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số ĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.grbTimKiemSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbQuanLyDocGia);
            this.Name = "frmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Độc Giả";
            this.grbQuanLyDocGia.ResumeLayout(false);
            this.grbQuanLyDocGia.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.grbTimKiemSach.ResumeLayout(false);
            this.grbTimKiemSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbQuanLyDocGia;
        private System.Windows.Forms.Button btnCapNhatDocGia;
        private System.Windows.Forms.Button btnXoaDocGia;
        private System.Windows.Forms.Button btnSuaDocGia;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.TextBox txtSDTDocGia;
        private System.Windows.Forms.TextBox txtHoTenDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNgaySinhDocGia;
        private System.Windows.Forms.Label lblHoTenDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtEmailDocGia;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.GroupBox grbTimKiemSach;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Button btnTimKiemSach;
        private System.Windows.Forms.Label lblTimKiemSach;
        private System.Windows.Forms.ComboBox cmbTheThuVien;
        private System.Windows.Forms.Label lblTheThuVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}