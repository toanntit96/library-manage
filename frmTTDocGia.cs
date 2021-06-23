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
    public partial class frmTTDocGia : Form
    {
        bool CheckUpdate;
        string MaOld;
        public frmTTDocGia()
        {
            InitializeComponent();
            dtpNgayLapThe.MaxDate = DateTime.Now;
            dtpNgaySinh.MaxDate = DateTime.Now.AddYears(-18);
            gpbThongtin.Enabled = false;
        }

        private void frmTTDocGia_Load(object sender, EventArgs e)
        {
            dtgv_dsDocGia.DataSource = DocGia.ShowAllDocGia();

            cmbKhoa.DataSource = DocGia.GetAllKhoa();
            cmbKhoa.DisplayMember = "tenkhoa";
            cmbKhoa.ValueMember = "makhoa";
        }

        private void dtgv_dsDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gpbThongtin.Enabled = true;
           
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa đọc giả này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string madocgia = this.dtgv_dsDocGia.Rows[e.RowIndex].Cells["madocgia"].Value.ToString();
                    if (DocGia.chkDocGia_CoPhieuMuon(madocgia))
                    {
                        DialogResult dialog = MessageBox.Show("Đọc giả có phiếu mượn. Bạn có chắc muốn xóa. Thao tác sẽ làm mất hết dữ liệu phiếu mượn ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            if (DocGia.Delete_DocGia(madocgia))
                            {
                                MessageBox.Show("Đã xóa đọc giả vừa chọn");
                                dtgv_dsDocGia.DataSource = DocGia.ShowAllDocGia();
                            }
                            else MessageBox.Show("Đã xảy ra lỗi khi xóa");
                        }
                        else { }
                    }
                    else 
                        if (DocGia.Delete_DocGia(madocgia))
                        {
                            MessageBox.Show("Đã xóa đọc giả vừa chọn");
                            dtgv_dsDocGia.DataSource = DocGia.ShowAllDocGia();
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
                DataGridViewRow row = this.dtgv_dsDocGia.Rows[e.RowIndex];
                txtMaDG.Text = row.Cells["madocgia"].Value.ToString();
                MaOld = row.Cells["madocgia"].Value.ToString();
                txtHoTen.Text = row.Cells["hoten"].Value.ToString();
                txtDiaChi.Text = row.Cells["diachi"].Value.ToString();
                dtpNgaySinh.Value = DateTime.ParseExact(row.Cells["ngaysinh"].Value.ToString(), "dd/MM/yyyy", null);
                dtpNgayLapThe.Value = DateTime.ParseExact(row.Cells["ngaylapthe"].Value.ToString(), "dd/MM/yyyy", null);
                cmbKhoa.SelectedIndex = cmbKhoa.FindStringExact(row.Cells["tenkhoa"].Value.ToString());
                CheckUpdate = true;
            }
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddDocGia frm = new frmAddDocGia();
            frm.ShowDialog();
            dtgv_dsDocGia.DataSource = DocGia.ShowAllDocGia();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string err = "Vui lòng kiểm tra các thông tin: \n";
            if (txtHoTen.Text.Length == 0)
            {
                err += "- Họ tên \n";
                CheckUpdate = false;
            }
            else CheckUpdate = true;
            if (txtDiaChi.Text.Length == 0)
            {
                err += "- Địa chỉ \n";
                CheckUpdate = false;
            }
            if (CheckUpdate)
            {
                if(DocGia.Update_DocGia(MaOld,txtHoTen.Text,dtpNgaySinh.Value.ToString(),cmbKhoa.SelectedValue.ToString(),txtDiaChi.Text,dtpNgayLapThe.Value.ToString()))
                {
                    MessageBox.Show("Cập nhật đọc giả thành công");
                    dtgv_dsDocGia.DataSource = DocGia.ShowAllDocGia();
                }
                else MessageBox.Show("Có lỗi trong quá trình cập nhật");
            }
            else
                MessageBox.Show(err);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
