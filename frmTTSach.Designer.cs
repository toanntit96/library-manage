namespace QLThuVien
{
    partial class frmTTSach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTTSach));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.numNamXB = new System.Windows.Forms.NumericUpDown();
            this.dtgvDanhSach = new System.Windows.Forms.DataGridView();
            this.coldel = new System.Windows.Forms.DataGridViewImageColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbLoaiS1 = new System.Windows.Forms.ComboBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtNhanDe = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.numLanXB = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.numSoTrang = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLoaiS2 = new System.Windows.Forms.ComboBox();
            this.gpbThongTinSach = new System.Windows.Forms.GroupBox();
            this.btnThemLoaiS = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gpbDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLanXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTrang)).BeginInit();
            this.gpbThongTinSach.SuspendLayout();
            this.gpbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tác giả";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(90, 96);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(121, 20);
            this.txtTacGia.TabIndex = 3;
            this.txtTacGia.TextChanged += new System.EventHandler(this.txtTacGia_TextChanged);
            // 
            // numNamXB
            // 
            this.numNamXB.Location = new System.Drawing.Point(90, 166);
            this.numNamXB.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numNamXB.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNamXB.Name = "numNamXB";
            this.numNamXB.Size = new System.Drawing.Size(77, 20);
            this.numNamXB.TabIndex = 5;
            this.numNamXB.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // dtgvDanhSach
            // 
            this.dtgvDanhSach.AllowUserToAddRows = false;
            this.dtgvDanhSach.AllowUserToDeleteRows = false;
            this.dtgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coldel,
            this.STT,
            this.nhande,
            this.tacgia,
            this.nxb,
            this.namxb,
            this.sotrang,
            this.soluong,
            this.lanxb,
            this.ngaynhap,
            this.tenloai,
            this.masach});
            this.dtgvDanhSach.Location = new System.Drawing.Point(6, 61);
            this.dtgvDanhSach.Name = "dtgvDanhSach";
            this.dtgvDanhSach.ReadOnly = true;
            this.dtgvDanhSach.RowHeadersVisible = false;
            this.dtgvDanhSach.Size = new System.Drawing.Size(900, 417);
            this.dtgvDanhSach.TabIndex = 5;
            this.dtgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellContentClick);
            // 
            // coldel
            // 
            this.coldel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coldel.Description = "Xóa quyển sách";
            this.coldel.HeaderText = "";
            this.coldel.Image = global::QLThuVien.Properties.Resources.book_blue_delete;
            this.coldel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.coldel.Name = "coldel";
            this.coldel.ReadOnly = true;
            this.coldel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coldel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.coldel.Width = 30;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.STT.Width = 30;
            // 
            // nhande
            // 
            this.nhande.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nhande.DataPropertyName = "nhande";
            this.nhande.HeaderText = "Nhan đề";
            this.nhande.Name = "nhande";
            this.nhande.ReadOnly = true;
            this.nhande.Width = 220;
            // 
            // tacgia
            // 
            this.tacgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.Name = "tacgia";
            this.tacgia.ReadOnly = true;
            this.tacgia.Width = 150;
            // 
            // nxb
            // 
            this.nxb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nxb.DataPropertyName = "nxb";
            this.nxb.HeaderText = "NXB";
            this.nxb.Name = "nxb";
            this.nxb.ReadOnly = true;
            // 
            // namxb
            // 
            this.namxb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.namxb.DataPropertyName = "namxb";
            this.namxb.HeaderText = "Năm XB";
            this.namxb.Name = "namxb";
            this.namxb.ReadOnly = true;
            this.namxb.Width = 71;
            // 
            // sotrang
            // 
            this.sotrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sotrang.DataPropertyName = "sotrang";
            this.sotrang.HeaderText = "Số trang";
            this.sotrang.Name = "sotrang";
            this.sotrang.ReadOnly = true;
            this.sotrang.Width = 40;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 40;
            // 
            // lanxb
            // 
            this.lanxb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lanxb.DataPropertyName = "lanxb";
            this.lanxb.HeaderText = "Lần XB";
            this.lanxb.Name = "lanxb";
            this.lanxb.ReadOnly = true;
            this.lanxb.Width = 40;
            // 
            // ngaynhap
            // 
            this.ngaynhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.ReadOnly = true;
            this.ngaynhap.Width = 84;
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Loại sách";
            this.tenloai.Name = "tenloai";
            this.tenloai.ReadOnly = true;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "masach";
            this.masach.Name = "masach";
            this.masach.ReadOnly = true;
            this.masach.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số trang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lần xuất bản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nhan đề";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nhà xuất bản";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày nhập";
            // 
            // cmbLoaiS1
            // 
            this.cmbLoaiS1.FormattingEnabled = true;
            this.cmbLoaiS1.Location = new System.Drawing.Point(90, 19);
            this.cmbLoaiS1.Name = "cmbLoaiS1";
            this.cmbLoaiS1.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiS1.TabIndex = 0;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(90, 131);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(121, 20);
            this.txtNXB.TabIndex = 4;
            this.txtNXB.TextChanged += new System.EventHandler(this.txtNXB_TextChanged);
            // 
            // txtNhanDe
            // 
            this.txtNhanDe.Location = new System.Drawing.Point(90, 59);
            this.txtNhanDe.Name = "txtNhanDe";
            this.txtNhanDe.Size = new System.Drawing.Size(121, 20);
            this.txtNhanDe.TabIndex = 2;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(90, 236);
            this.numSoLuong.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(53, 20);
            this.numSoLuong.TabIndex = 7;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLanXB
            // 
            this.numLanXB.Location = new System.Drawing.Point(90, 271);
            this.numLanXB.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numLanXB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLanXB.Name = "numLanXB";
            this.numLanXB.Size = new System.Drawing.Size(53, 20);
            this.numLanXB.TabIndex = 8;
            this.numLanXB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(90, 306);
            this.dtpNgayNhap.MaxDate = new System.DateTime(2017, 6, 3, 14, 23, 8, 0);
            this.dtpNgayNhap.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayNhap.TabIndex = 10;
            this.dtpNgayNhap.Value = new System.DateTime(2017, 5, 18, 0, 0, 0, 0);
            // 
            // numSoTrang
            // 
            this.numSoTrang.Location = new System.Drawing.Point(90, 201);
            this.numSoTrang.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoTrang.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSoTrang.Name = "numSoTrang";
            this.numSoTrang.Size = new System.Drawing.Size(53, 20);
            this.numSoTrang.TabIndex = 6;
            this.numSoTrang.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại sách";
            // 
            // cmbLoaiS2
            // 
            this.cmbLoaiS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiS2.FormattingEnabled = true;
            this.cmbLoaiS2.Location = new System.Drawing.Point(354, 17);
            this.cmbLoaiS2.Name = "cmbLoaiS2";
            this.cmbLoaiS2.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiS2.TabIndex = 13;
            this.cmbLoaiS2.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiS2_SelectedIndexChanged);
            // 
            // gpbThongTinSach
            // 
            this.gpbThongTinSach.Controls.Add(this.btnThemLoaiS);
            this.gpbThongTinSach.Controls.Add(this.cmbLoaiS1);
            this.gpbThongTinSach.Controls.Add(this.dtpNgayNhap);
            this.gpbThongTinSach.Controls.Add(this.numLanXB);
            this.gpbThongTinSach.Controls.Add(this.numSoTrang);
            this.gpbThongTinSach.Controls.Add(this.numSoLuong);
            this.gpbThongTinSach.Controls.Add(this.numNamXB);
            this.gpbThongTinSach.Controls.Add(this.txtNhanDe);
            this.gpbThongTinSach.Controls.Add(this.txtNXB);
            this.gpbThongTinSach.Controls.Add(this.label12);
            this.gpbThongTinSach.Controls.Add(this.label10);
            this.gpbThongTinSach.Controls.Add(this.label11);
            this.gpbThongTinSach.Controls.Add(this.label9);
            this.gpbThongTinSach.Controls.Add(this.label7);
            this.gpbThongTinSach.Controls.Add(this.label5);
            this.gpbThongTinSach.Controls.Add(this.label4);
            this.gpbThongTinSach.Controls.Add(this.label3);
            this.gpbThongTinSach.Controls.Add(this.txtTacGia);
            this.gpbThongTinSach.Controls.Add(this.label1);
            this.gpbThongTinSach.Location = new System.Drawing.Point(9, 11);
            this.gpbThongTinSach.Name = "gpbThongTinSach";
            this.gpbThongTinSach.Size = new System.Drawing.Size(256, 385);
            this.gpbThongTinSach.TabIndex = 7;
            this.gpbThongTinSach.TabStop = false;
            this.gpbThongTinSach.Text = "Thông tin sách";
            // 
            // btnThemLoaiS
            // 
            this.btnThemLoaiS.Location = new System.Drawing.Point(220, 21);
            this.btnThemLoaiS.Name = "btnThemLoaiS";
            this.btnThemLoaiS.Size = new System.Drawing.Size(23, 18);
            this.btnThemLoaiS.TabIndex = 11;
            this.btnThemLoaiS.Text = "...";
            this.btnThemLoaiS.Click += new System.EventHandler(this.btnThemLoaiS_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(129, 462);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(28, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpbDanhSach
            // 
            this.gpbDanhSach.Controls.Add(this.cmbLoaiS2);
            this.gpbDanhSach.Controls.Add(this.dtgvDanhSach);
            this.gpbDanhSach.Controls.Add(this.label6);
            this.gpbDanhSach.Location = new System.Drawing.Point(271, 11);
            this.gpbDanhSach.Name = "gpbDanhSach";
            this.gpbDanhSach.Size = new System.Drawing.Size(912, 484);
            this.gpbDanhSach.TabIndex = 8;
            this.gpbDanhSach.TabStop = false;
            this.gpbDanhSach.Text = "Danh sách";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.Description = "Xóa quyển sách";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::QLThuVien.Properties.Resources.document_delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTTSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 497);
            this.Controls.Add(this.gpbDanhSach);
            this.Controls.Add(this.gpbThongTinSach);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTTSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sách";
            this.Load += new System.EventHandler(this.frmTTSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLanXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTrang)).EndInit();
            this.gpbThongTinSach.ResumeLayout(false);
            this.gpbThongTinSach.PerformLayout();
            this.gpbDanhSach.ResumeLayout(false);
            this.gpbDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTacGia;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.NumericUpDown numNamXB;
        private System.Windows.Forms.DataGridView dtgvDanhSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbLoaiS1;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtNhanDe;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.NumericUpDown numLanXB;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.NumericUpDown numSoTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoaiS2;
        private System.Windows.Forms.GroupBox gpbThongTinSach;
        private System.Windows.Forms.GroupBox gpbDanhSach;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewImageColumn coldel;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhande;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiS;
    }
}