namespace QLThuVien
{
    partial class frmQLThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLThuVien));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuitem_NguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.item_TTCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.item_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.item_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_QLSach = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTracuuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCapNhatTTSach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_QLDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinĐọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_QLMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMuonTraSach = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPhieuMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_QTHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTHemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSuaDoiThongTinNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_TK_BC = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTKDanhSachNV = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThongKeTTSach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_TimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_NguoiDung,
            this.menuitem_QLSach,
            this.menuitem_QLDocGia,
            this.menuitem_QLMuonTra,
            this.menuitem_QTHeThong,
            this.menuitem_TK_BC,
            this.menuitem_TimKiem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(893, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menuitem_NguoiDung
            // 
            this.menuitem_NguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDangNhap,
            this.item_TTCaNhan,
            this.item_DoiMatKhau,
            this.item_DangXuat});
            this.menuitem_NguoiDung.Name = "menuitem_NguoiDung";
            this.menuitem_NguoiDung.Size = new System.Drawing.Size(83, 20);
            this.menuitem_NguoiDung.Text = "Người dùng";
            // 
            // itemDangNhap
            // 
            this.itemDangNhap.Name = "itemDangNhap";
            this.itemDangNhap.Size = new System.Drawing.Size(171, 22);
            this.itemDangNhap.Text = "Đăng nhập";
            this.itemDangNhap.Click += new System.EventHandler(this.itemDangNhap_Click);
            // 
            // item_TTCaNhan
            // 
            this.item_TTCaNhan.Name = "item_TTCaNhan";
            this.item_TTCaNhan.Size = new System.Drawing.Size(171, 22);
            this.item_TTCaNhan.Text = "Thông tin cá nhân";
            this.item_TTCaNhan.Click += new System.EventHandler(this.item_TTCaNhan_Click);
            // 
            // item_DoiMatKhau
            // 
            this.item_DoiMatKhau.Name = "item_DoiMatKhau";
            this.item_DoiMatKhau.Size = new System.Drawing.Size(171, 22);
            this.item_DoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // item_DangXuat
            // 
            this.item_DangXuat.Name = "item_DangXuat";
            this.item_DangXuat.Size = new System.Drawing.Size(171, 22);
            this.item_DangXuat.Text = "Đăng xuất";
            this.item_DangXuat.Click += new System.EventHandler(this.item_DangXuat_Click);
            // 
            // menuitem_QLSach
            // 
            this.menuitem_QLSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTracuuSach,
            this.itemCapNhatTTSach});
            this.menuitem_QLSach.Name = "menuitem_QLSach";
            this.menuitem_QLSach.Size = new System.Drawing.Size(87, 20);
            this.menuitem_QLSach.Text = "Quản lý sách";
            // 
            // itemTracuuSach
            // 
            this.itemTracuuSach.Name = "itemTracuuSach";
            this.itemTracuuSach.Size = new System.Drawing.Size(201, 22);
            this.itemTracuuSach.Text = "Tra cứu sách";
            // 
            // itemCapNhatTTSach
            // 
            this.itemCapNhatTTSach.Name = "itemCapNhatTTSach";
            this.itemCapNhatTTSach.Size = new System.Drawing.Size(201, 22);
            this.itemCapNhatTTSach.Text = "Cập nhật thông tin sách";
            this.itemCapNhatTTSach.Click += new System.EventHandler(this.itemCapNhatTTSach_Click);
            // 
            // menuitem_QLDocGia
            // 
            this.menuitem_QLDocGia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinĐọcGiảToolStripMenuItem});
            this.menuitem_QLDocGia.Name = "menuitem_QLDocGia";
            this.menuitem_QLDocGia.Size = new System.Drawing.Size(102, 20);
            this.menuitem_QLDocGia.Text = "Quản lý đọc giả";
            // 
            // cậpNhậtThôngTinĐọcGiảToolStripMenuItem
            // 
            this.cậpNhậtThôngTinĐọcGiảToolStripMenuItem.Name = "cậpNhậtThôngTinĐọcGiảToolStripMenuItem";
            this.cậpNhậtThôngTinĐọcGiảToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cậpNhậtThôngTinĐọcGiảToolStripMenuItem.Text = "Cập nhật thông tin đọc giả";
            this.cậpNhậtThôngTinĐọcGiảToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinĐọcGiảToolStripMenuItem_Click);
            // 
            // menuitem_QLMuonTra
            // 
            this.menuitem_QLMuonTra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMuonTraSach,
            this.itemPhieuMuon});
            this.menuitem_QLMuonTra.Name = "menuitem_QLMuonTra";
            this.menuitem_QLMuonTra.Size = new System.Drawing.Size(112, 20);
            this.menuitem_QLMuonTra.Text = "Quản lý mượn trả";
            // 
            // itemMuonTraSach
            // 
            this.itemMuonTraSach.Name = "itemMuonTraSach";
            this.itemMuonTraSach.Size = new System.Drawing.Size(150, 22);
            this.itemMuonTraSach.Text = "Mượn trả sách";
            this.itemMuonTraSach.Click += new System.EventHandler(this.mượnTrảSáchToolStripMenuItem_Click);
            // 
            // itemPhieuMuon
            // 
            this.itemPhieuMuon.Name = "itemPhieuMuon";
            this.itemPhieuMuon.Size = new System.Drawing.Size(150, 22);
            this.itemPhieuMuon.Text = "Phiếu mượn";
            // 
            // menuitem_QTHeThong
            // 
            this.menuitem_QTHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTHemNhanVien,
            this.itemSuaDoiThongTinNV});
            this.menuitem_QTHeThong.Name = "menuitem_QTHeThong";
            this.menuitem_QTHeThong.Size = new System.Drawing.Size(113, 20);
            this.menuitem_QTHeThong.Text = "Quản trị hệ thống";
            // 
            // itemTHemNhanVien
            // 
            this.itemTHemNhanVien.Name = "itemTHemNhanVien";
            this.itemTHemNhanVien.Size = new System.Drawing.Size(220, 22);
            this.itemTHemNhanVien.Text = "Thêm nhân viên";
            this.itemTHemNhanVien.Click += new System.EventHandler(this.itemTHemNhanVien_Click);
            // 
            // itemSuaDoiThongTinNV
            // 
            this.itemSuaDoiThongTinNV.Name = "itemSuaDoiThongTinNV";
            this.itemSuaDoiThongTinNV.Size = new System.Drawing.Size(220, 22);
            this.itemSuaDoiThongTinNV.Text = "Sửa đổi thông tin nhân viên";
            this.itemSuaDoiThongTinNV.Click += new System.EventHandler(this.itemSuaDoiThongTinNV_Click);
            // 
            // menuitem_TK_BC
            // 
            this.menuitem_TK_BC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTKDanhSachNV,
            this.itemThongKeTTSach});
            this.menuitem_TK_BC.Name = "menuitem_TK_BC";
            this.menuitem_TK_BC.Size = new System.Drawing.Size(122, 20);
            this.menuitem_TK_BC.Text = "Thống kê - Báo cáo";
            // 
            // itemTKDanhSachNV
            // 
            this.itemTKDanhSachNV.Name = "itemTKDanhSachNV";
            this.itemTKDanhSachNV.Size = new System.Drawing.Size(203, 22);
            this.itemTKDanhSachNV.Text = "Danh sách nhân viên";
            this.itemTKDanhSachNV.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // itemThongKeTTSach
            // 
            this.itemThongKeTTSach.Name = "itemThongKeTTSach";
            this.itemThongKeTTSach.Size = new System.Drawing.Size(203, 22);
            this.itemThongKeTTSach.Text = "Thống kê thông tin sách";
            this.itemThongKeTTSach.Click += new System.EventHandler(this.itemThongKeTTSach_Click);
            // 
            // menuitem_TimKiem
            // 
            this.menuitem_TimKiem.Name = "menuitem_TimKiem";
            this.menuitem_TimKiem.Size = new System.Drawing.Size(69, 20);
            this.menuitem_TimKiem.Text = "Tìm kiếm";
            // 
            // frmQLThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(893, 489);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmQLThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLThuVien_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuitem_NguoiDung;
        private System.Windows.Forms.ToolStripMenuItem item_TTCaNhan;
        private System.Windows.Forms.ToolStripMenuItem item_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem item_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuitem_QLSach;
        private System.Windows.Forms.ToolStripMenuItem itemCapNhatTTSach;
        private System.Windows.Forms.ToolStripMenuItem menuitem_QLDocGia;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinĐọcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitem_QLMuonTra;
        private System.Windows.Forms.ToolStripMenuItem itemMuonTraSach;
        private System.Windows.Forms.ToolStripMenuItem itemPhieuMuon;
        private System.Windows.Forms.ToolStripMenuItem menuitem_QTHeThong;
        private System.Windows.Forms.ToolStripMenuItem itemTHemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem itemSuaDoiThongTinNV;
        private System.Windows.Forms.ToolStripMenuItem menuitem_TK_BC;
        private System.Windows.Forms.ToolStripMenuItem menuitem_TimKiem;
        private System.Windows.Forms.ToolStripMenuItem itemTracuuSach;
        private System.Windows.Forms.ToolStripMenuItem itemDangNhap;
        private System.Windows.Forms.ToolStripMenuItem itemTKDanhSachNV;
        private System.Windows.Forms.ToolStripMenuItem itemThongKeTTSach;
    }
}