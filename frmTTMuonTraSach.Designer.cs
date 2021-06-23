namespace QLThuVien
{
    partial class frmTTMuonTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTTMuonTraSach));
            this.label1 = new System.Windows.Forms.Label();
            this.gpThongTinMuonS = new System.Windows.Forms.GroupBox();
            this.cmbNhanDe = new System.Windows.Forms.ComboBox();
            this.cmbDocGia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.gpDanhSach = new System.Windows.Forms.GroupBox();
            this.chkbAll = new System.Windows.Forms.CheckBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.dtgv_dsMuonTra = new System.Windows.Forms.DataGridView();
            this.maphieumuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachmuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.gpThongTinDocGia = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgayLapThe = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTraSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnMuonSach = new DevExpress.XtraEditors.SimpleButton();
            this.gpThongTinMuonS.SuspendLayout();
            this.gpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsMuonTra)).BeginInit();
            this.gpThongTinDocGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đọc giả";
            // 
            // gpThongTinMuonS
            // 
            this.gpThongTinMuonS.Controls.Add(this.btnMuonSach);
            this.gpThongTinMuonS.Controls.Add(this.cmbNhanDe);
            this.gpThongTinMuonS.Controls.Add(this.cmbDocGia);
            this.gpThongTinMuonS.Controls.Add(this.label10);
            this.gpThongTinMuonS.Controls.Add(this.label3);
            this.gpThongTinMuonS.Controls.Add(this.cmbLoaiSach);
            this.gpThongTinMuonS.Controls.Add(this.label2);
            this.gpThongTinMuonS.Controls.Add(this.label13);
            this.gpThongTinMuonS.Controls.Add(this.lblNgayTra);
            this.gpThongTinMuonS.Controls.Add(this.label11);
            this.gpThongTinMuonS.Controls.Add(this.lblNgayMuon);
            this.gpThongTinMuonS.Location = new System.Drawing.Point(18, 9);
            this.gpThongTinMuonS.Name = "gpThongTinMuonS";
            this.gpThongTinMuonS.Size = new System.Drawing.Size(550, 112);
            this.gpThongTinMuonS.TabIndex = 2;
            this.gpThongTinMuonS.TabStop = false;
            this.gpThongTinMuonS.Text = "Thông tin mượn sách";
            // 
            // cmbNhanDe
            // 
            this.cmbNhanDe.FormattingEnabled = true;
            this.cmbNhanDe.Location = new System.Drawing.Point(72, 79);
            this.cmbNhanDe.Name = "cmbNhanDe";
            this.cmbNhanDe.Size = new System.Drawing.Size(121, 21);
            this.cmbNhanDe.TabIndex = 3;
            this.cmbNhanDe.SelectedIndexChanged += new System.EventHandler(this.cmbNhanDe_SelectedIndexChanged);
            // 
            // cmbDocGia
            // 
            this.cmbDocGia.FormattingEnabled = true;
            this.cmbDocGia.Location = new System.Drawing.Point(72, 19);
            this.cmbDocGia.Name = "cmbDocGia";
            this.cmbDocGia.Size = new System.Drawing.Size(121, 21);
            this.cmbDocGia.TabIndex = 1;
            this.cmbDocGia.SelectedIndexChanged += new System.EventHandler(this.cmbDocGia_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Đọc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhan đề";
            // 
            // cmbLoaiSach
            // 
            this.cmbLoaiSach.FormattingEnabled = true;
            this.cmbLoaiSach.Location = new System.Drawing.Point(72, 50);
            this.cmbLoaiSach.Name = "cmbLoaiSach";
            this.cmbLoaiSach.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiSach.TabIndex = 2;
            this.cmbLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiSach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại sách";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(401, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày trả:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.ForeColor = System.Drawing.Color.Red;
            this.lblNgayTra.Location = new System.Drawing.Point(463, 23);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(49, 15);
            this.lblNgayTra.TabIndex = 0;
            this.lblNgayTra.Text = "..............";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(212, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày mượn:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMuon.ForeColor = System.Drawing.Color.Red;
            this.lblNgayMuon.Location = new System.Drawing.Point(298, 23);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(49, 15);
            this.lblNgayMuon.TabIndex = 0;
            this.lblNgayMuon.Text = "..............";
            // 
            // gpDanhSach
            // 
            this.gpDanhSach.Controls.Add(this.simpleButton1);
            this.gpDanhSach.Controls.Add(this.chkbAll);
            this.gpDanhSach.Controls.Add(this.btnTraSach);
            this.gpDanhSach.Controls.Add(this.cmbTrangThai);
            this.gpDanhSach.Controls.Add(this.txtDocGia);
            this.gpDanhSach.Controls.Add(this.dtgv_dsMuonTra);
            this.gpDanhSach.Controls.Add(this.label12);
            this.gpDanhSach.Controls.Add(this.label1);
            this.gpDanhSach.Location = new System.Drawing.Point(20, 138);
            this.gpDanhSach.Name = "gpDanhSach";
            this.gpDanhSach.Size = new System.Drawing.Size(980, 416);
            this.gpDanhSach.TabIndex = 3;
            this.gpDanhSach.TabStop = false;
            this.gpDanhSach.Text = "Danh sách";
            // 
            // chkbAll
            // 
            this.chkbAll.AutoSize = true;
            this.chkbAll.Location = new System.Drawing.Point(453, 24);
            this.chkbAll.Name = "chkbAll";
            this.chkbAll.Size = new System.Drawing.Size(150, 17);
            this.chkbAll.TabIndex = 7;
            this.chkbAll.Text = "Hiển thị tất cả phiếu mượn";
            this.chkbAll.UseVisualStyleBackColor = true;
            this.chkbAll.CheckedChanged += new System.EventHandler(this.chkbAll_CheckedChanged);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(308, 19);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(121, 21);
            this.cmbTrangThai.TabIndex = 2;
            this.cmbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThai_SelectedIndexChanged);
            // 
            // txtDocGia
            // 
            this.txtDocGia.Location = new System.Drawing.Point(101, 21);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.Size = new System.Drawing.Size(121, 20);
            this.txtDocGia.TabIndex = 1;
            this.txtDocGia.TextChanged += new System.EventHandler(this.txtDocGia_TextChanged);
            // 
            // dtgv_dsMuonTra
            // 
            this.dtgv_dsMuonTra.AllowUserToAddRows = false;
            this.dtgv_dsMuonTra.AllowUserToDeleteRows = false;
            this.dtgv_dsMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dsMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieumuon,
            this.madocgia,
            this.hoten,
            this.masach,
            this.sachmuon,
            this.soluong,
            this.ngaymuon,
            this.ngaytra,
            this.trangthai,
            this.hotennhanvien});
            this.dtgv_dsMuonTra.Location = new System.Drawing.Point(6, 52);
            this.dtgv_dsMuonTra.Name = "dtgv_dsMuonTra";
            this.dtgv_dsMuonTra.ReadOnly = true;
            this.dtgv_dsMuonTra.RowHeadersVisible = false;
            this.dtgv_dsMuonTra.Size = new System.Drawing.Size(968, 358);
            this.dtgv_dsMuonTra.TabIndex = 0;
            this.dtgv_dsMuonTra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dsMuonTra_CellContentClick);
            // 
            // maphieumuon
            // 
            this.maphieumuon.DataPropertyName = "maphieumuon";
            this.maphieumuon.HeaderText = "maphieumuon";
            this.maphieumuon.Name = "maphieumuon";
            this.maphieumuon.ReadOnly = true;
            this.maphieumuon.Visible = false;
            // 
            // madocgia
            // 
            this.madocgia.DataPropertyName = "madocgia";
            this.madocgia.HeaderText = "Mã đọc giả";
            this.madocgia.Name = "madocgia";
            this.madocgia.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 180;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "masach";
            this.masach.Name = "masach";
            this.masach.ReadOnly = true;
            this.masach.Visible = false;
            // 
            // sachmuon
            // 
            this.sachmuon.DataPropertyName = "sachmuon";
            this.sachmuon.HeaderText = "Sách mượn";
            this.sachmuon.Name = "sachmuon";
            this.sachmuon.ReadOnly = true;
            this.sachmuon.Width = 180;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 74;
            // 
            // ngaymuon
            // 
            this.ngaymuon.DataPropertyName = "ngaymuon";
            this.ngaymuon.DividerWidth = 1;
            this.ngaymuon.HeaderText = "Ngày mượn";
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.ReadOnly = true;
            // 
            // ngaytra
            // 
            this.ngaytra.DataPropertyName = "ngaytra";
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // hotennhanvien
            // 
            this.hotennhanvien.DataPropertyName = "hotennhanvien";
            this.hotennhanvien.HeaderText = "Nhân viên";
            this.hotennhanvien.Name = "hotennhanvien";
            this.hotennhanvien.ReadOnly = true;
            this.hotennhanvien.Width = 130;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Trạng thái";
            // 
            // gpThongTinDocGia
            // 
            this.gpThongTinDocGia.Controls.Add(this.label9);
            this.gpThongTinDocGia.Controls.Add(this.label8);
            this.gpThongTinDocGia.Controls.Add(this.label7);
            this.gpThongTinDocGia.Controls.Add(this.label6);
            this.gpThongTinDocGia.Controls.Add(this.label5);
            this.gpThongTinDocGia.Controls.Add(this.lblKhoa);
            this.gpThongTinDocGia.Controls.Add(this.lblDiaChi);
            this.gpThongTinDocGia.Controls.Add(this.lblNgayLapThe);
            this.gpThongTinDocGia.Controls.Add(this.lblNgaySinh);
            this.gpThongTinDocGia.Controls.Add(this.lblHoTen);
            this.gpThongTinDocGia.Controls.Add(this.lblMaDocGia);
            this.gpThongTinDocGia.Controls.Add(this.label4);
            this.gpThongTinDocGia.Location = new System.Drawing.Point(574, 9);
            this.gpThongTinDocGia.Name = "gpThongTinDocGia";
            this.gpThongTinDocGia.Size = new System.Drawing.Size(425, 111);
            this.gpThongTinDocGia.TabIndex = 4;
            this.gpThongTinDocGia.TabStop = false;
            this.gpThongTinDocGia.Text = "Thông tin đọc giả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày lập thẻ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(266, 28);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(49, 13);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "..............";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(266, 55);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(49, 13);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "..............";
            // 
            // lblNgayLapThe
            // 
            this.lblNgayLapThe.AutoSize = true;
            this.lblNgayLapThe.Location = new System.Drawing.Point(266, 82);
            this.lblNgayLapThe.Name = "lblNgayLapThe";
            this.lblNgayLapThe.Size = new System.Drawing.Size(49, 13);
            this.lblNgayLapThe.TabIndex = 0;
            this.lblNgayLapThe.Text = "..............";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(77, 82);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(49, 13);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "..............";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(77, 55);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "..............";
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(77, 27);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(49, 13);
            this.lblMaDocGia.TabIndex = 0;
            this.lblMaDocGia.Text = "..............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã đọc giả";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(834, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 32);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "GIA HẠN";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.Appearance.Options.UseFont = true;
            this.btnTraSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTraSach.Image")));
            this.btnTraSach.Location = new System.Drawing.Point(657, 13);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(122, 32);
            this.btnTraSach.TabIndex = 5;
            this.btnTraSach.Text = "TRẢ SÁCH";
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonSach.Appearance.Options.UseFont = true;
            this.btnMuonSach.Image = ((System.Drawing.Image)(resources.GetObject("btnMuonSach.Image")));
            this.btnMuonSach.Location = new System.Drawing.Point(297, 51);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(150, 44);
            this.btnMuonSach.TabIndex = 4;
            this.btnMuonSach.Text = "MƯỢN SÁCH";
            this.btnMuonSach.Click += new System.EventHandler(this.btnMuonSach_Click);
            // 
            // frmTTMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 566);
            this.Controls.Add(this.gpThongTinDocGia);
            this.Controls.Add(this.gpDanhSach);
            this.Controls.Add(this.gpThongTinMuonS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTTMuonTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin mượn trả sách";
            this.Load += new System.EventHandler(this.frmTTMuonTraSach_Load);
            this.gpThongTinMuonS.ResumeLayout(false);
            this.gpThongTinMuonS.PerformLayout();
            this.gpDanhSach.ResumeLayout(false);
            this.gpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsMuonTra)).EndInit();
            this.gpThongTinDocGia.ResumeLayout(false);
            this.gpThongTinDocGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpThongTinMuonS;
        private DevExpress.XtraEditors.SimpleButton btnMuonSach;
        private System.Windows.Forms.ComboBox cmbNhanDe;
        private System.Windows.Forms.ComboBox cmbDocGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpDanhSach;
        private System.Windows.Forms.DataGridView dtgv_dsMuonTra;
        private System.Windows.Forms.GroupBox gpThongTinDocGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgayLapThe;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtDocGia;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SimpleButton btnTraSach;
        private System.Windows.Forms.CheckBox chkbAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieumuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sachmuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotennhanvien;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}