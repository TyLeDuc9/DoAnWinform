namespace TyNhanLongKhoi_DoAn_GUI
{
    partial class frmTraSach
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
            this.grbTimKiemSach = new System.Windows.Forms.GroupBox();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.lblTimKiemSach = new System.Windows.Forms.Label();
            this.grbTraSach = new System.Windows.Forms.GroupBox();
            this.lblSLCon = new System.Windows.Forms.Label();
            this.txtSLConLaiTraSach = new System.Windows.Forms.TextBox();
            this.txtTenSachTra = new System.Windows.Forms.TextBox();
            this.lblTenSachMuon = new System.Windows.Forms.Label();
            this.txtMPTra = new System.Windows.Forms.TextBox();
            this.lblMPMuon = new System.Windows.Forms.Label();
            this.txtGhiChuTra = new System.Windows.Forms.TextBox();
            this.cmbTinhTrangTra = new System.Windows.Forms.ComboBox();
            this.dtpNgayTraSach = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuonSach = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblTGTra = new System.Windows.Forms.Label();
            this.lblTGMuon = new System.Windows.Forms.Label();
            this.lblSLMuon = new System.Windows.Forms.Label();
            this.SLSachTra = new System.Windows.Forms.TextBox();
            this.txtMaSachTraSach = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.cmbTheThuVienTraSach = new System.Windows.Forms.ComboBox();
            this.lblTheThuVien = new System.Windows.Forms.Label();
            this.txtMaDocGiaTraSach = new System.Windows.Forms.TextBox();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.grbDanhSachTra = new System.Windows.Forms.GroupBox();
            this.dgvTraSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTimKiemSach.SuspendLayout();
            this.grbTraSach.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbDanhSachTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTimKiemSach
            // 
            this.grbTimKiemSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbTimKiemSach.Controls.Add(this.txtTimKiemSach);
            this.grbTimKiemSach.Controls.Add(this.btnTimKiemSach);
            this.grbTimKiemSach.Controls.Add(this.lblTimKiemSach);
            this.grbTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemSach.Location = new System.Drawing.Point(2, 1);
            this.grbTimKiemSach.Name = "grbTimKiemSach";
            this.grbTimKiemSach.Size = new System.Drawing.Size(799, 58);
            this.grbTimKiemSach.TabIndex = 18;
            this.grbTimKiemSach.TabStop = false;
            this.grbTimKiemSach.Text = "Tìm Kiếm";
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Location = new System.Drawing.Point(302, 22);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(233, 25);
            this.txtTimKiemSach.TabIndex = 12;
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSach.Location = new System.Drawing.Point(541, 17);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(86, 35);
            this.btnTimKiemSach.TabIndex = 13;
            this.btnTimKiemSach.Text = "Tìm Kiếm";
            this.btnTimKiemSach.UseVisualStyleBackColor = false;
            // 
            // lblTimKiemSach
            // 
            this.lblTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemSach.Location = new System.Drawing.Point(31, 22);
            this.lblTimKiemSach.Name = "lblTimKiemSach";
            this.lblTimKiemSach.Size = new System.Drawing.Size(269, 24);
            this.lblTimKiemSach.TabIndex = 0;
            this.lblTimKiemSach.Text = "Nhập thông tin (tên sách hoặc mã sách )";
            this.lblTimKiemSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbTraSach
            // 
            this.grbTraSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbTraSach.Controls.Add(this.lblSLCon);
            this.grbTraSach.Controls.Add(this.txtSLConLaiTraSach);
            this.grbTraSach.Controls.Add(this.txtTenSachTra);
            this.grbTraSach.Controls.Add(this.lblTenSachMuon);
            this.grbTraSach.Controls.Add(this.txtMPTra);
            this.grbTraSach.Controls.Add(this.lblMPMuon);
            this.grbTraSach.Controls.Add(this.txtGhiChuTra);
            this.grbTraSach.Controls.Add(this.cmbTinhTrangTra);
            this.grbTraSach.Controls.Add(this.dtpNgayTraSach);
            this.grbTraSach.Controls.Add(this.dtpNgayMuonSach);
            this.grbTraSach.Controls.Add(this.lblGhiChu);
            this.grbTraSach.Controls.Add(this.lblTinhTrang);
            this.grbTraSach.Controls.Add(this.lblTGTra);
            this.grbTraSach.Controls.Add(this.lblTGMuon);
            this.grbTraSach.Controls.Add(this.lblSLMuon);
            this.grbTraSach.Controls.Add(this.SLSachTra);
            this.grbTraSach.Controls.Add(this.txtMaSachTraSach);
            this.grbTraSach.Controls.Add(this.lblMaSach);
            this.grbTraSach.Controls.Add(this.cmbTheThuVienTraSach);
            this.grbTraSach.Controls.Add(this.lblTheThuVien);
            this.grbTraSach.Controls.Add(this.txtMaDocGiaTraSach);
            this.grbTraSach.Controls.Add(this.lblMaDocGia);
            this.grbTraSach.Location = new System.Drawing.Point(2, 65);
            this.grbTraSach.Name = "grbTraSach";
            this.grbTraSach.Size = new System.Drawing.Size(799, 179);
            this.grbTraSach.TabIndex = 19;
            this.grbTraSach.TabStop = false;
            this.grbTraSach.Text = "Thực Hiện Trả Sách";
            // 
            // lblSLCon
            // 
            this.lblSLCon.Location = new System.Drawing.Point(6, 143);
            this.lblSLCon.Name = "lblSLCon";
            this.lblSLCon.Size = new System.Drawing.Size(106, 29);
            this.lblSLCon.TabIndex = 33;
            this.lblSLCon.Text = "SL Còn";
            this.lblSLCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSLConLaiTraSach
            // 
            this.txtSLConLaiTraSach.Location = new System.Drawing.Point(118, 147);
            this.txtSLConLaiTraSach.Name = "txtSLConLaiTraSach";
            this.txtSLConLaiTraSach.Size = new System.Drawing.Size(126, 22);
            this.txtSLConLaiTraSach.TabIndex = 32;
            // 
            // txtTenSachTra
            // 
            this.txtTenSachTra.Location = new System.Drawing.Point(118, 103);
            this.txtTenSachTra.Name = "txtTenSachTra";
            this.txtTenSachTra.Size = new System.Drawing.Size(126, 22);
            this.txtTenSachTra.TabIndex = 31;
            // 
            // lblTenSachMuon
            // 
            this.lblTenSachMuon.Location = new System.Drawing.Point(6, 98);
            this.lblTenSachMuon.Name = "lblTenSachMuon";
            this.lblTenSachMuon.Size = new System.Drawing.Size(106, 29);
            this.lblTenSachMuon.TabIndex = 30;
            this.lblTenSachMuon.Text = "Tên Sách";
            this.lblTenSachMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMPTra
            // 
            this.txtMPTra.Location = new System.Drawing.Point(398, 27);
            this.txtMPTra.Name = "txtMPTra";
            this.txtMPTra.Size = new System.Drawing.Size(121, 22);
            this.txtMPTra.TabIndex = 29;
            // 
            // lblMPMuon
            // 
            this.lblMPMuon.Location = new System.Drawing.Point(274, 27);
            this.lblMPMuon.Name = "lblMPMuon";
            this.lblMPMuon.Size = new System.Drawing.Size(118, 29);
            this.lblMPMuon.TabIndex = 28;
            this.lblMPMuon.Text = "Mã Phiếu Mượn";
            this.lblMPMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGhiChuTra
            // 
            this.txtGhiChuTra.Location = new System.Drawing.Point(398, 146);
            this.txtGhiChuTra.Name = "txtGhiChuTra";
            this.txtGhiChuTra.Size = new System.Drawing.Size(121, 22);
            this.txtGhiChuTra.TabIndex = 27;
            // 
            // cmbTinhTrangTra
            // 
            this.cmbTinhTrangTra.FormattingEnabled = true;
            this.cmbTinhTrangTra.Location = new System.Drawing.Point(662, 70);
            this.cmbTinhTrangTra.Name = "cmbTinhTrangTra";
            this.cmbTinhTrangTra.Size = new System.Drawing.Size(126, 24);
            this.cmbTinhTrangTra.TabIndex = 26;
            // 
            // dtpNgayTraSach
            // 
            this.dtpNgayTraSach.Location = new System.Drawing.Point(398, 102);
            this.dtpNgayTraSach.Name = "dtpNgayTraSach";
            this.dtpNgayTraSach.Size = new System.Drawing.Size(121, 22);
            this.dtpNgayTraSach.TabIndex = 25;
            // 
            // dtpNgayMuonSach
            // 
            this.dtpNgayMuonSach.Location = new System.Drawing.Point(662, 104);
            this.dtpNgayMuonSach.Name = "dtpNgayMuonSach";
            this.dtpNgayMuonSach.Size = new System.Drawing.Size(121, 22);
            this.dtpNgayMuonSach.TabIndex = 24;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(284, 148);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(90, 24);
            this.lblGhiChu.TabIndex = 23;
            this.lblGhiChu.Text = "Ghi Chú";
            this.lblGhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(556, 69);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(100, 24);
            this.lblTinhTrang.TabIndex = 22;
            this.lblTinhTrang.Text = "Tình Trạng";
            this.lblTinhTrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTGTra
            // 
            this.lblTGTra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGTra.Location = new System.Drawing.Point(274, 102);
            this.lblTGTra.Name = "lblTGTra";
            this.lblTGTra.Size = new System.Drawing.Size(100, 24);
            this.lblTGTra.TabIndex = 21;
            this.lblTGTra.Text = "Ngày Trả";
            this.lblTGTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTGMuon
            // 
            this.lblTGMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGMuon.Location = new System.Drawing.Point(556, 104);
            this.lblTGMuon.Name = "lblTGMuon";
            this.lblTGMuon.Size = new System.Drawing.Size(100, 24);
            this.lblTGMuon.TabIndex = 20;
            this.lblTGMuon.Text = "Ngày Mượn";
            this.lblTGMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSLMuon
            // 
            this.lblSLMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLMuon.Location = new System.Drawing.Point(274, 64);
            this.lblSLMuon.Name = "lblSLMuon";
            this.lblSLMuon.Size = new System.Drawing.Size(118, 29);
            this.lblSLMuon.TabIndex = 19;
            this.lblSLMuon.Text = "SL Sách Trả";
            this.lblSLMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SLSachTra
            // 
            this.SLSachTra.Location = new System.Drawing.Point(398, 64);
            this.SLSachTra.Name = "SLSachTra";
            this.SLSachTra.Size = new System.Drawing.Size(121, 22);
            this.SLSachTra.TabIndex = 18;
            // 
            // txtMaSachTraSach
            // 
            this.txtMaSachTraSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSachTraSach.Location = new System.Drawing.Point(118, 67);
            this.txtMaSachTraSach.Name = "txtMaSachTraSach";
            this.txtMaSachTraSach.Size = new System.Drawing.Size(126, 15);
            this.txtMaSachTraSach.TabIndex = 17;
            // 
            // lblMaSach
            // 
            this.lblMaSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(6, 60);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(106, 29);
            this.lblMaSach.TabIndex = 16;
            this.lblMaSach.Text = "Mã Sách";
            this.lblMaSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTheThuVienTraSach
            // 
            this.cmbTheThuVienTraSach.FormattingEnabled = true;
            this.cmbTheThuVienTraSach.Items.AddRange(new object[] {
            "Thẻ Sinh Viên",
            "Thẻ Giảng Viên"});
            this.cmbTheThuVienTraSach.Location = new System.Drawing.Point(662, 29);
            this.cmbTheThuVienTraSach.Name = "cmbTheThuVienTraSach";
            this.cmbTheThuVienTraSach.Size = new System.Drawing.Size(126, 24);
            this.cmbTheThuVienTraSach.TabIndex = 15;
            // 
            // lblTheThuVien
            // 
            this.lblTheThuVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheThuVien.Location = new System.Drawing.Point(538, 29);
            this.lblTheThuVien.Name = "lblTheThuVien";
            this.lblTheThuVien.Size = new System.Drawing.Size(118, 29);
            this.lblTheThuVien.TabIndex = 14;
            this.lblTheThuVien.Text = "Thẻ Thư Viện";
            this.lblTheThuVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDocGiaTraSach
            // 
            this.txtMaDocGiaTraSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDocGiaTraSach.Location = new System.Drawing.Point(118, 34);
            this.txtMaDocGiaTraSach.Name = "txtMaDocGiaTraSach";
            this.txtMaDocGiaTraSach.Size = new System.Drawing.Size(126, 15);
            this.txtMaDocGiaTraSach.TabIndex = 3;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDocGia.Location = new System.Drawing.Point(6, 27);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(106, 29);
            this.lblMaDocGia.TabIndex = 2;
            this.lblMaDocGia.Text = "Mã Độc Giả";
            this.lblMaDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTraSach);
            this.panel1.Location = new System.Drawing.Point(1, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 49);
            this.panel1.TabIndex = 21;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(431, 7);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 33);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(187, 7);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(89, 33);
            this.btnTraSach.TabIndex = 0;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            // 
            // grbDanhSachTra
            // 
            this.grbDanhSachTra.BackColor = System.Drawing.Color.LightBlue;
            this.grbDanhSachTra.Controls.Add(this.dgvTraSach);
            this.grbDanhSachTra.Location = new System.Drawing.Point(2, 307);
            this.grbDanhSachTra.Name = "grbDanhSachTra";
            this.grbDanhSachTra.Size = new System.Drawing.Size(799, 248);
            this.grbDanhSachTra.TabIndex = 22;
            this.grbDanhSachTra.TabStop = false;
            this.grbDanhSachTra.Text = "Danh Sách Trả";
            // 
            // dgvTraSach
            // 
            this.dgvTraSach.AllowUserToAddRows = false;
            this.dgvTraSach.AllowUserToDeleteRows = false;
            this.dgvTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvTraSach.Location = new System.Drawing.Point(0, 17);
            this.dgvTraSach.Name = "dgvTraSach";
            this.dgvTraSach.ReadOnly = true;
            this.dgvTraSach.RowHeadersWidth = 51;
            this.dgvTraSach.RowTemplate.Height = 24;
            this.dgvTraSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraSach.Size = new System.Drawing.Size(799, 231);
            this.dgvTraSach.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Độc Giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Phiếu Mượn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thẻ Thư Viện";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã Sách";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SL Sách Trả";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tình Trạng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày Mượn";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ngày Trả";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ghi Chú";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.grbDanhSachTra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbTraSach);
            this.Controls.Add(this.grbTimKiemSach);
            this.Name = "frmTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả Sách";
            this.grbTimKiemSach.ResumeLayout(false);
            this.grbTimKiemSach.PerformLayout();
            this.grbTraSach.ResumeLayout(false);
            this.grbTraSach.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbDanhSachTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimKiemSach;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Button btnTimKiemSach;
        private System.Windows.Forms.Label lblTimKiemSach;
        private System.Windows.Forms.GroupBox grbTraSach;
        private System.Windows.Forms.Label lblSLCon;
        private System.Windows.Forms.TextBox txtSLConLaiTraSach;
        private System.Windows.Forms.TextBox txtTenSachTra;
        private System.Windows.Forms.Label lblTenSachMuon;
        private System.Windows.Forms.TextBox txtMPTra;
        private System.Windows.Forms.Label lblMPMuon;
        private System.Windows.Forms.TextBox txtGhiChuTra;
        private System.Windows.Forms.ComboBox cmbTinhTrangTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTraSach;
        private System.Windows.Forms.DateTimePicker dtpNgayMuonSach;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblTGTra;
        private System.Windows.Forms.Label lblTGMuon;
        private System.Windows.Forms.Label lblSLMuon;
        private System.Windows.Forms.TextBox SLSachTra;
        private System.Windows.Forms.TextBox txtMaSachTraSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.ComboBox cmbTheThuVienTraSach;
        private System.Windows.Forms.Label lblTheThuVien;
        private System.Windows.Forms.TextBox txtMaDocGiaTraSach;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.GroupBox grbDanhSachTra;
        private System.Windows.Forms.DataGridView dgvTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}