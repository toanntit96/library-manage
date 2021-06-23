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
    public partial class frmKhoa : Form
    {
       public bool CheckAdd = false;
       public bool CheckUpdate = false;
        string makhoaOld = "";
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dtgv_dsKhoa.DataSource = DocGia.ShowAllKhoa();
            btnCapNhat.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool chk1 = false;
            bool chk2 = false;
            string err = "Kiểm tra các thông tin sau: n";
            if (txtMaKhoa.Text.Length == 0)
            {
                err += "Mã khoa không được bỏ trống \n";
                chk1 = false;
            }
            else chk1 = true;
            if (txtTenKhoa.Text.Length == 0)
            {
                err += "Tên khoa không được bỏ trống \n";
                chk2 = false;
            }
            else chk2 = true;
            if (chk1 && chk2)
            {
                if (!DocGia.chkTonTai_MaKhoa(txtMaKhoa.Text.Trim()))
                {
                    if (!DocGia.chkTonTai_TenKhoa(txtTenKhoa.Text.Trim()))
                    {

                        if (DocGia.Insert_Khoa(txtMaKhoa.Text.Trim(), txtTenKhoa.Text.Trim()))
                        {
                            MessageBox.Show("Thêm khoa thành công!");
                            dtgv_dsKhoa.DataSource = DocGia.ShowAllKhoa();
                        }
                        else MessageBox.Show("Có lỗi trong quá trình thêm khoa. Liên hệ dev!");
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại tên khoa. Kiểm tra lại!");
                        txtTenKhoa.Clear();
                        txtTenKhoa.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại mã khoa. Kiểm tra lại!");
                    txtMaKhoa.Clear();
                    txtMaKhoa.Focus();
                }
            }
            else MessageBox.Show(err);
            
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool chk1 = false;
            bool chk2 = false;
            string err = "Kiểm tra các thông tin sau: n";
            if (txtMaKhoa.Text.Length == 0)
            {
                err += "Mã khoa không được bỏ trống \n";
                chk1 = false;
            }
            else chk1 = true;
            if (txtTenKhoa.Text.Length == 0)
            {
                err += "Tên khoa không được bỏ trống \n";
                chk2 = false;
            }
            else chk2 = true;
            if (chk1 && chk2)
            {
                
                    if (!DocGia.chkTonTai_TenKhoa(txtTenKhoa.Text.Trim()))
                    {

                        if (DocGia.Update_Khoa(makhoaOld,txtMaKhoa.Text.Trim(), txtTenKhoa.Text.Trim()))
                        {
                            MessageBox.Show("Cập nhật khoa thành công!");
                            dtgv_dsKhoa.DataSource = DocGia.ShowAllKhoa();
                        }
                        else MessageBox.Show("Có lỗi trong quá trình cập nhật khoa. Liên hệ dev!");
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại tên khoa. Kiểm tra lại!");
                        txtTenKhoa.Clear();
                        txtTenKhoa.Focus();
                    }
                
                
            }
            else MessageBox.Show(err);
        }

        private void dtgv_dsKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dtgv_dsKhoa.Rows[e.RowIndex];
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa khoa này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DocGia.chkKhoa_CoDocGia(row.Cells["makhoa"].Value.ToString()))    //Kiểm tra khoa có đọc giả mượn sách
                    {
                        DialogResult dialog = MessageBox.Show("Khoa này có đọc giả đang mượn sách. Vẫn xóa ???", "Cảnh báo !!!", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            string makhoa = row.Cells["makhoa"].Value.ToString();
                            if (DocGia.Delete_Khoa(makhoa))
                            {
                                MessageBox.Show("Đã xóa khoa vừa chọn");
                                dtgv_dsKhoa.DataSource =  DocGia.ShowAllKhoa();
                            }
                            else MessageBox.Show("Đã xảy ra lỗi khi xóa");
                        }
                        else if(dialog == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else                            // Khoa không có đọc giả mượn sách
                    {
                        string makhoa = row.Cells["makhoa"].Value.ToString();
                        if (DocGia.Delete_Khoa(makhoa))
                        {
                            MessageBox.Show("Đã xóa khoa vừa chọn");
                            dtgv_dsKhoa.DataSource = DocGia.ShowAllKhoa();
                        }
                        else MessageBox.Show("Đã xảy ra lỗi khi xóa");
                    }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            else
            if (e.RowIndex >= 0)
            {
                row = this.dtgv_dsKhoa.Rows[e.RowIndex];
                btnCapNhat.Enabled = true;
                txtMaKhoa.Text = row.Cells["makhoa"].Value.ToString();
                makhoaOld = row.Cells["makhoa"].Value.ToString();
                txtTenKhoa.Text = row.Cells["tenkhoa"].Value.ToString();
                CheckUpdate = true;
            }
        }
    }
}
