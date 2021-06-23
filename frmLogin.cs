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
    public partial class frmLogin : Form
    {
        public static string user = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            txtUser_DocGia.Focus();
            // Kiểm tra đã có nhân viên nào trong hệ thống chưa
           // List<NhanVien> dsNV = NhanVien.getAllNhanVien();
            //if(dsNV.Count == 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Nhân viên quản lý thư viện đang rỗng. Bạn có muốn tạo mới người quản lý", 
            //        "Quản lý thư viện - Thông báo", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        this.Hide();
            //        frmDangKyNhanVien frm = new frmDangKyNhanVien();
            //        frm.ShowDialog();
            //        this.Show();
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        this.Close();
            //    }
            //}
            //txtUser_NhanVien.Focus();
        }

        private void btnClose_NhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_DocGia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LoginNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser_NhanVien.Text) || string.IsNullOrEmpty(txtPass_NhanVien.Text))
            {

                if (string.IsNullOrEmpty(txtUser_NhanVien.Text))
                {
                    MessageBox.Show("Mã đăng nhập không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtPass_NhanVien.Text))
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                }
            }
            else
                if (NhanVien.Check_Login(txtUser_NhanVien.Text, txtPass_NhanVien.Text))
            {
                //Properties.Settings.Default.MaDocGia = txtUser_NhanVien.Text;
                user = txtUser_NhanVien.Text;
                if (NhanVien.Get_QuyenHan(txtUser_NhanVien.Text) == 0)
                {

                    frmQLThuVien.phanQuyen = 0;
                    this.Close();
                }
                else
                    if (NhanVien.Get_QuyenHan(txtUser_NhanVien.Text) == 1)
                {
                    frmQLThuVien.phanQuyen = 1;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Kiểm tra lại mã đăng nhập hoặc mật khẩu");
                txtPass_NhanVien.Text = "";
            }
           
        }

        private void btnLogin_DocGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser_DocGia.Text) || string.IsNullOrEmpty(txtPass_DocGia.Text))
            {

                if (string.IsNullOrEmpty(txtUser_DocGia.Text))
                {
                    MessageBox.Show("Mã đăng nhập không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtPass_DocGia.Text))
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                }
            }
            else
                if (DocGia.Check_Login(txtUser_DocGia.Text, txtPass_DocGia.Text))
            {
                // Properties.Settings.Default.MaDocGia = txtUser_DocGia.Text;
                user = txtUser_DocGia.Text;
                frmQLThuVien.phanQuyen = 2;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Kiểm tra lại mã đăng nhập hoặc mật khẩu");
                txtPass_DocGia.Text = "";
            }
        }
    }
}
