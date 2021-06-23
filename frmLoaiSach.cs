using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmLoaiSach : Form
    {
        bool Check_Add;
        bool Check_Update;
        int MaOld;

        public frmLoaiSach()
        {
            InitializeComponent();
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            dtgv_dsLoaiS.DataSource = LoaiSach.ShowAll_LoaiS();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text.Length == 0)
                Check_Add = false;
            else Check_Add = true;
            if (Check_Add == true)
            {
                if(LoaiSach.Check_ExistTenLoai(txtTenLoai.Text))
                {
                    MessageBox.Show("Loại sách này hiện đang có. Vui lòng kiểm tra lại");
                    txtTenLoai.Focus();
                }
                else
                if (LoaiSach.Insert_LoaiS(txtTenLoai.Text))
                {
                    MessageBox.Show("Thêm loại sách mới thành công");
                    dtgv_dsLoaiS.DataSource = LoaiSach.ShowAll_LoaiS();
                }
                else MessageBox.Show("Có lỗi khi thêm mới");
                    

            }
            else MessageBox.Show("Không được bỏ trống");
        }
        private void dtgv_dsLoaiS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            Check_Update = true;
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa loại sách này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int masach = int.Parse(this.dtgv_dsLoaiS.Rows[e.RowIndex].Cells["maloai"].Value.ToString());
                    if (LoaiSach.Delete_LoaiS(masach))
                    {
                        MessageBox.Show("Đã xóa quyển sách vừa chọn");
                        dtgv_dsLoaiS.DataSource = LoaiSach.ShowAll_LoaiS();
                    }
                    else MessageBox.Show("Đã xảy ra lỗi khi xóa");
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            else
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv_dsLoaiS.Rows[e.RowIndex];
                txtTenLoai.Text = row.Cells["tenloai"].Value.ToString();
                MaOld = (int)row.Cells["maloai"].Value;
                Check_Update = true;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text.Length == 0)
                Check_Update = false;
            else Check_Update = true;
            if (Check_Update == true)
            {
                if (LoaiSach.Update_LoaiS(MaOld, txtTenLoai.Text))
                {
                    MessageBox.Show("Cập nhật lại thành công");
                    dtgv_dsLoaiS.DataSource = LoaiSach.ShowAll_LoaiS();
                }
                else MessageBox.Show("Có lỗi khi cập nhật");


            }
            else MessageBox.Show("Không được bỏ trống");
        }

        
    }
}
