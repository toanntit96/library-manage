namespace QLThuVien
{
    partial class frmLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSach));
            this.dtgv_dsLoaiS = new System.Windows.Forms.DataGridView();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsLoaiS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_dsLoaiS
            // 
            this.dtgv_dsLoaiS.AllowUserToAddRows = false;
            this.dtgv_dsLoaiS.AllowUserToDeleteRows = false;
            this.dtgv_dsLoaiS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dsLoaiS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.STT,
            this.tenloai,
            this.maloai});
            this.dtgv_dsLoaiS.Location = new System.Drawing.Point(12, 12);
            this.dtgv_dsLoaiS.Name = "dtgv_dsLoaiS";
            this.dtgv_dsLoaiS.ReadOnly = true;
            this.dtgv_dsLoaiS.RowHeadersVisible = false;
            this.dtgv_dsLoaiS.Size = new System.Drawing.Size(158, 191);
            this.dtgv_dsLoaiS.TabIndex = 0;
            this.dtgv_dsLoaiS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dsLoaiS_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(216, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(307, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(216, 32);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(166, 20);
            this.txtTenLoai.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên loại";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = global::QLThuVien.Properties.Resources.document_delete;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 25;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 30;
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Tên loại";
            this.tenloai.Name = "tenloai";
            this.tenloai.ReadOnly = true;
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "maloai";
            this.maloai.Name = "maloai";
            this.maloai.ReadOnly = true;
            this.maloai.Visible = false;
            // 
            // frmLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 208);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgv_dsLoaiS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoaiSach";
            this.Text = "Quản lý loại sách";
            this.Load += new System.EventHandler(this.frmLoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsLoaiS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_dsLoaiS;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
    }
}