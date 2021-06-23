using DevExpress.XtraEditors.Controls;
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
    public partial class frmTTSach : Form
    {
        bool Check_Add = false;
        bool Check_Update = false;
        string temp;
        int MaS_Old;
        public frmTTSach()
        {
            InitializeComponent();
                     
        }
        public void LoadData ()
        {
            dtgvDanhSach.DataSource = Sach.ShowAllSach();
        }

        private void frmTTSach_Load(object sender, EventArgs e)
        {
            LoadData();
            ////// Combobox Danh Sách
            cmbLoaiS2.DataSource = Sach.getLoaiSach();
            cmbLoaiS2.DisplayMember = "tenloai";
            cmbLoaiS2.ValueMember = "maloai";
            ///// Combobox Thông tin sách
            cmbLoaiS1.DataSource = Sach.getLoaiSach();
            cmbLoaiS1.DisplayMember = "tenloai";
            cmbLoaiS1.ValueMember = "maloai";
            dtpNgayNhap.MaxDate = DateTime.Now;
   
            dtpNgayNhap.Value = DateTime.Now;
            
        }
        
        private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Check_Update = true;
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa quyển sách này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string masach = this.dtgvDanhSach.Rows[e.RowIndex].Cells["masach"].Value.ToString();
                    if (Sach.Delete_Sach(masach))
                    {
                        MessageBox.Show("Đã xóa quyển sách vừa chọn");
                        LoadData();
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
                DataGridViewRow row = this.dtgvDanhSach.Rows[e.RowIndex];
                txtNhanDe.Text = row.Cells["nhande"].Value.ToString();
                txtNXB.Text = row.Cells["nxb"].Value.ToString();
                txtTacGia.Text = row.Cells["tacgia"].Value.ToString();
                numNamXB.Value = (int)row.Cells["namxb"].Value;
                numSoTrang.Value = (int)row.Cells["sotrang"].Value;
                numSoLuong.Value = (int)row.Cells["soluong"].Value;
                numLanXB.Value = (int)row.Cells["lanxb"].Value;
                dtpNgayNhap.Value = DateTime.ParseExact(row.Cells["ngaynhap"].Value.ToString(), "dd/MM/yyyy", null);
                cmbLoaiS1.SelectedIndex = cmbLoaiS1.FindStringExact(row.Cells["tenloai"].Value.ToString());
                MaS_Old = (int)row.Cells["masach"].Value;
                Check_Update = true;  
            }
        }

        private void cmbLoaiS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sach.getSachFromLoai(cmbLoaiS2.SelectedValue.ToString()) != null)
                dtgvDanhSach.DataSource = Sach.getSachFromLoai(cmbLoaiS2.SelectedValue.ToString());
            else LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string err = "Kiểm tra lại các thông tin sau: \n";
            if (txtNhanDe.Text.Length == 0)
            {
                err += "- Nhan đề \n";
                Check_Add = false;
            }
            else Check_Add = true;
            if (txtTacGia.Text.Length == 0)
            {
                err += "- Tác giả \n";
                Check_Add = false;
            }
            else Check_Add = true;
            if (txtNXB.Text.Length == 0)
            {
                err += "- Nhà xuất bản \n";
                Check_Add = false;
            }
            else Check_Add = true;
            
           if (Check_Add == true)
            {
                if (Sach.Insert_Sach(txtNhanDe.Text, (int)numSoTrang.Value, (int)numSoLuong.Value, (int)numNamXB.Value, (int)numLanXB.Value, cmbLoaiS1.SelectedValue.ToString(), txtNXB.Text, txtTacGia.Text, dtpNgayNhap.Value.ToString()))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                    cmbLoaiS2.SelectedValue = cmbLoaiS1.SelectedValue.ToString();
                }
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string err = "Kiểm tra lại các thông tin sau: \n";
            if (txtNhanDe.Text.Length == 0)
            {
                err += "- Nhan đề \n";
                Check_Update = false;
            }
            else Check_Update = true;
            if (txtTacGia.Text.Length == 0)
            {
                err += "- Tác giả \n";
                Check_Update = false;
            }
            else Check_Update = true;
            if (txtNXB.Text.Length == 0)
            {
                err += "- Nhà xuất bản \n";
                Check_Update = false;
            }
            else Check_Update = true;

            if (Check_Update == true)
            {
                if (Sach.Update_Sach(MaS_Old,txtNhanDe.Text, (int)numSoTrang.Value, (int)numSoLuong.Value, (int)numNamXB.Value, (int)numLanXB.Value, cmbLoaiS1.SelectedValue.ToString(), txtNXB.Text, txtTacGia.Text, dtpNgayNhap.Value.ToString()))
                {
                    MessageBox.Show("Thay đổi thông tin thành công");
                    LoadData();
                    cmbLoaiS2.SelectedValue = cmbLoaiS1.SelectedValue.ToString();
                    Check_Update = false;
                }
            }
            else
            {
                MessageBox.Show(err);
            }
        }
        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTacGia.Text.Length == 0)
            {
                errorProvider1.SetError(txtTacGia, "Không được bỏ trống");
                Check_Add = false;
            }
            else
            {
                errorProvider1.Clear();
                Check_Add = true;
            }
        }

        private void txtNXB_TextChanged(object sender, EventArgs e)
        {
            if (txtNXB.Text.Length == 0)
            {
                errorProvider1.SetError(txtNXB, "Không được bỏ trống");
                Check_Add = false;
            }
            else
            {
                errorProvider1.Clear();
                Check_Add = true;
            }
        }

        private void btnThemLoaiS_Click(object sender, EventArgs e)
        {
            frmLoaiSach frm = new frmLoaiSach();
            frm.ShowDialog();
            cmbLoaiS2.DataSource = Sach.getLoaiSach();
            cmbLoaiS2.DisplayMember = "tenloai";
            cmbLoaiS2.ValueMember = "maloai";
            ///// Combobox Thông tin sách
            cmbLoaiS1.DataSource = Sach.getLoaiSach();
            cmbLoaiS1.DisplayMember = "tenloai";
            cmbLoaiS1.ValueMember = "maloai";
            LoadData();
            ////// Combobox Danh Sách
            
            
        }
    }
}
