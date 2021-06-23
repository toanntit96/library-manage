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
    public partial class frmAddDocGia : Form
    {
        public frmAddDocGia()
        {
            
            InitializeComponent();

            dtpNgaySinh.MaxDate = DateTime.Now.AddYears(-18);
            dtpNgayLapThe.MaxDate = DateTime.Now;
            dtpNgayLapThe.MinDate = DateTime.Now.AddDays(-1);
            dtpNgayLapThe.Value = DateTime.Now;
            
        }

        private void frmAddDocGia_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = DocGia.GetAllKhoa();
            cmbKhoa.DisplayMember = "tenkhoa";
            cmbKhoa.ValueMember = "makhoa";
            txtMaDocGia.Text = DocGia.GetMaDocGia();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool CheckAdd = false;
            string err = "Kiểm tra lại các thông tin sau: \n";
            if (txtMaDocGia.Text.Length == 0)
            {
                CheckAdd = false;
                err += "- Mã đọc giả \n";
            }
            else CheckAdd = true;
            if (txtHoTen.Text.Length == 0)
            {
                CheckAdd = false;
                err += "- Họ tên \n";
            }
            else CheckAdd = true;
            if (txtDiaChi.Text.Length == 0)
            {
                CheckAdd = false;
                err += "- Địa chỉ \n";
            }
            else CheckAdd = true;
            if (CheckAdd == true)
            {
                if (DocGia.Insert_DocGia(txtMaDocGia.Text, txtHoTen.Text, dtpNgaySinh.Value.ToString(), cmbKhoa.SelectedValue.ToString(), txtDiaChi.Text, dtpNgayLapThe.Value.ToString()))
                {
                    MessageBox.Show("Thêm mới đọc giả thành công");
                    txtHoTen.Focus();
                    txtMaDocGia.Text = DocGia.GetMaDocGia();
                    txtHoTen.Clear();
                    txtDiaChi.Clear();
                }
                else
                    MessageBox.Show("Có lỗi trong quá trình thêm mới đọc giả");
            }
            else
                MessageBox.Show(err);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Focus();
            txtHoTen.Clear();
            txtDiaChi.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            frm.ShowDialog();
            cmbKhoa.DataSource = DocGia.GetAllKhoa();
            cmbKhoa.DisplayMember = "tenkhoa";
            cmbKhoa.ValueMember = "makhoa";
        }
    }
}
