namespace QLThuVien
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tabctrlLogin = new System.Windows.Forms.TabControl();
            this.tabpNhanVien = new System.Windows.Forms.TabPage();
            this.txtPass_NhanVien = new System.Windows.Forms.TextBox();
            this.txtUser_NhanVien = new System.Windows.Forms.TextBox();
            this.btnClose_NhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_LoginNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabpDocGia = new System.Windows.Forms.TabPage();
            this.txtPass_DocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser_DocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose_DocGia = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin_DocGia = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabctrlLogin.SuspendLayout();
            this.tabpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabpDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlLogin
            // 
            this.tabctrlLogin.Controls.Add(this.tabpNhanVien);
            this.tabctrlLogin.Controls.Add(this.tabpDocGia);
            this.tabctrlLogin.Location = new System.Drawing.Point(12, 12);
            this.tabctrlLogin.Name = "tabctrlLogin";
            this.tabctrlLogin.SelectedIndex = 0;
            this.tabctrlLogin.Size = new System.Drawing.Size(468, 256);
            this.tabctrlLogin.TabIndex = 100;
            // 
            // tabpNhanVien
            // 
            this.tabpNhanVien.Controls.Add(this.txtPass_NhanVien);
            this.tabpNhanVien.Controls.Add(this.txtUser_NhanVien);
            this.tabpNhanVien.Controls.Add(this.btnClose_NhanVien);
            this.tabpNhanVien.Controls.Add(this.label4);
            this.tabpNhanVien.Controls.Add(this.btn_LoginNhanVien);
            this.tabpNhanVien.Controls.Add(this.label3);
            this.tabpNhanVien.Controls.Add(this.pictureBox1);
            this.tabpNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabpNhanVien.Name = "tabpNhanVien";
            this.tabpNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabpNhanVien.Size = new System.Drawing.Size(460, 230);
            this.tabpNhanVien.TabIndex = 0;
            this.tabpNhanVien.Text = "Nhân viên";
            this.tabpNhanVien.UseVisualStyleBackColor = true;
            // 
            // txtPass_NhanVien
            // 
            this.txtPass_NhanVien.Location = new System.Drawing.Point(222, 107);
            this.txtPass_NhanVien.Name = "txtPass_NhanVien";
            this.txtPass_NhanVien.PasswordChar = '*';
            this.txtPass_NhanVien.Size = new System.Drawing.Size(129, 20);
            this.txtPass_NhanVien.TabIndex = 2;
            // 
            // txtUser_NhanVien
            // 
            this.txtUser_NhanVien.Location = new System.Drawing.Point(222, 51);
            this.txtUser_NhanVien.Name = "txtUser_NhanVien";
            this.txtUser_NhanVien.Size = new System.Drawing.Size(129, 20);
            this.txtUser_NhanVien.TabIndex = 1;
            // 
            // btnClose_NhanVien
            // 
            this.btnClose_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnClose_NhanVien.Image")));
            this.btnClose_NhanVien.Location = new System.Drawing.Point(350, 166);
            this.btnClose_NhanVien.Name = "btnClose_NhanVien";
            this.btnClose_NhanVien.Size = new System.Drawing.Size(85, 23);
            this.btnClose_NhanVien.TabIndex = 4;
            this.btnClose_NhanVien.Text = "Thoát";
            this.btnClose_NhanVien.Click += new System.EventHandler(this.btnClose_NhanVien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu";
            // 
            // btn_LoginNhanVien
            // 
            this.btn_LoginNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoginNhanVien.Image")));
            this.btn_LoginNhanVien.Location = new System.Drawing.Point(222, 166);
            this.btn_LoginNhanVien.Name = "btn_LoginNhanVien";
            this.btn_LoginNhanVien.Size = new System.Drawing.Size(92, 23);
            this.btn_LoginNhanVien.TabIndex = 3;
            this.btn_LoginNhanVien.Text = "Đăng nhập";
            this.btn_LoginNhanVien.Click += new System.EventHandler(this.btn_LoginNhanVien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabpDocGia
            // 
            this.tabpDocGia.Controls.Add(this.txtPass_DocGia);
            this.tabpDocGia.Controls.Add(this.label2);
            this.tabpDocGia.Controls.Add(this.txtUser_DocGia);
            this.tabpDocGia.Controls.Add(this.label1);
            this.tabpDocGia.Controls.Add(this.btnClose_DocGia);
            this.tabpDocGia.Controls.Add(this.btnLogin_DocGia);
            this.tabpDocGia.Controls.Add(this.pictureBox2);
            this.tabpDocGia.Location = new System.Drawing.Point(4, 22);
            this.tabpDocGia.Name = "tabpDocGia";
            this.tabpDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDocGia.Size = new System.Drawing.Size(460, 230);
            this.tabpDocGia.TabIndex = 1;
            this.tabpDocGia.Text = "Đọc giả";
            this.tabpDocGia.UseVisualStyleBackColor = true;
            // 
            // txtPass_DocGia
            // 
            this.txtPass_DocGia.Location = new System.Drawing.Point(226, 98);
            this.txtPass_DocGia.Name = "txtPass_DocGia";
            this.txtPass_DocGia.PasswordChar = '*';
            this.txtPass_DocGia.Size = new System.Drawing.Size(132, 20);
            this.txtPass_DocGia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txtUser_DocGia
            // 
            this.txtUser_DocGia.Location = new System.Drawing.Point(226, 47);
            this.txtUser_DocGia.Name = "txtUser_DocGia";
            this.txtUser_DocGia.Size = new System.Drawing.Size(132, 20);
            this.txtUser_DocGia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // btnClose_DocGia
            // 
            this.btnClose_DocGia.Image = ((System.Drawing.Image)(resources.GetObject("btnClose_DocGia.Image")));
            this.btnClose_DocGia.Location = new System.Drawing.Point(357, 166);
            this.btnClose_DocGia.Name = "btnClose_DocGia";
            this.btnClose_DocGia.Size = new System.Drawing.Size(84, 23);
            this.btnClose_DocGia.TabIndex = 4;
            this.btnClose_DocGia.Text = "Thoát";
            this.btnClose_DocGia.Click += new System.EventHandler(this.btnClose_DocGia_Click);
            // 
            // btnLogin_DocGia
            // 
            this.btnLogin_DocGia.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin_DocGia.Image")));
            this.btnLogin_DocGia.Location = new System.Drawing.Point(226, 166);
            this.btnLogin_DocGia.Name = "btnLogin_DocGia";
            this.btnLogin_DocGia.Size = new System.Drawing.Size(91, 23);
            this.btnLogin_DocGia.TabIndex = 3;
            this.btnLogin_DocGia.Text = "Đăng nhập";
            this.btnLogin_DocGia.Click += new System.EventHandler(this.btnLogin_DocGia_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_LoginNhanVien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 280);
            this.Controls.Add(this.tabctrlLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tabctrlLogin.ResumeLayout(false);
            this.tabpNhanVien.ResumeLayout(false);
            this.tabpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabpDocGia.ResumeLayout(false);
            this.tabpDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlLogin;
        private System.Windows.Forms.TabPage tabpNhanVien;
        private System.Windows.Forms.TabPage tabpDocGia;
        private System.Windows.Forms.TextBox txtPass_NhanVien;
        private System.Windows.Forms.TextBox txtUser_NhanVien;
        private DevExpress.XtraEditors.SimpleButton btnClose_NhanVien;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_LoginNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPass_DocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser_DocGia;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnClose_DocGia;
        private DevExpress.XtraEditors.SimpleButton btnLogin_DocGia;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}