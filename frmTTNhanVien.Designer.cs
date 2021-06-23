namespace QLThuVien
{
    partial class frmTTNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTTNhanVien));
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDanhSach = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpThongTin = new System.Windows.Forms.GroupBox();
            this.gpDanhSach = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetpass = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.quyenhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).BeginInit();
            this.gpThongTin.SuspendLayout();
            this.gpDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(283, 19);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 71);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(69, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(141, 20);
            this.txtHoTen.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ và tên";
            // 
            // dtgvDanhSach
            // 
            this.dtgvDanhSach.AllowUserToAddRows = false;
            this.dtgvDanhSach.AllowUserToDeleteRows = false;
            this.dtgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.manhanvien,
            this.hoten,
            this.diachi,
            this.email,
            this.resetpass,
            this.delete,
            this.quyenhan});
            this.dtgvDanhSach.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSach.Name = "dtgvDanhSach";
            this.dtgvDanhSach.ReadOnly = true;
            this.dtgvDanhSach.RowHeadersVisible = false;
            this.dtgvDanhSach.Size = new System.Drawing.Size(876, 261);
            this.dtgvDanhSach.TabIndex = 18;
            this.dtgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellContentClick);
            // 
            // gpThongTin
            // 
            this.gpThongTin.Controls.Add(this.txtEmail);
            this.gpThongTin.Controls.Add(this.label2);
            this.gpThongTin.Controls.Add(this.txtDiaChi);
            this.gpThongTin.Controls.Add(this.txtHoTen);
            this.gpThongTin.Controls.Add(this.label6);
            this.gpThongTin.Controls.Add(this.label1);
            this.gpThongTin.Location = new System.Drawing.Point(18, 7);
            this.gpThongTin.Name = "gpThongTin";
            this.gpThongTin.Size = new System.Drawing.Size(619, 131);
            this.gpThongTin.TabIndex = 19;
            this.gpThongTin.TabStop = false;
            this.gpThongTin.Text = "Thông tin nhân viên";
            // 
            // gpDanhSach
            // 
            this.gpDanhSach.Controls.Add(this.dtgvDanhSach);
            this.gpDanhSach.Location = new System.Drawing.Point(12, 157);
            this.gpDanhSach.Name = "gpDanhSach";
            this.gpDanhSach.Size = new System.Drawing.Size(888, 286);
            this.gpDanhSach.TabIndex = 20;
            this.gpDanhSach.TabStop = false;
            this.gpDanhSach.Text = "Danh sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Mật khẩu mới";
            this.dataGridViewImageColumn1.Image = global::QLThuVien.Properties.Resources.custom_flat_reset_password_512;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.Image = global::QLThuVien.Properties.Resources.remove_user1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(673, 88);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(121, 36);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Cập nhật";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(673, 26);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 36);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Thêm mới";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã nhân viên";
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 200;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // resetpass
            // 
            this.resetpass.HeaderText = "Mật khẩu mới";
            this.resetpass.Image = global::QLThuVien.Properties.Resources.custom_flat_reset_password_512;
            this.resetpass.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.resetpass.Name = "resetpass";
            this.resetpass.ReadOnly = true;
            this.resetpass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resetpass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.resetpass.Width = 50;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delete.HeaderText = "Xóa";
            this.delete.Image = global::QLThuVien.Properties.Resources.remove_user1;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // quyenhan
            // 
            this.quyenhan.DataPropertyName = "quyenhan";
            this.quyenhan.HeaderText = "quyenhan";
            this.quyenhan.Name = "quyenhan";
            this.quyenhan.ReadOnly = true;
            this.quyenhan.Visible = false;
            // 
            // frmTTNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 455);
            this.Controls.Add(this.gpDanhSach);
            this.Controls.Add(this.gpThongTin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "frmTTNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.frmTTNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).EndInit();
            this.gpThongTin.ResumeLayout(false);
            this.gpThongTin.PerformLayout();
            this.gpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDanhSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpThongTin;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.GroupBox gpDanhSach;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewImageColumn resetpass;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenhan;
    }
}