using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace QLThuVien
{
    public partial class frmTTNhanVien : Form
    {
        public bool CheckUpdate = false;
        string manv { get; set; }
        public frmTTNhanVien()
        {
            InitializeComponent();
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        private void frmTTNhanVien_Load(object sender, EventArgs e)
        {
            dtgvDanhSach.DataSource = NhanVien.ShowAllNhanVien();
            gpThongTin.Enabled = false;
        }

        private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgvDanhSach.Rows[e.RowIndex];
            gpThongTin.Enabled = true;
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn xin cấp mật khẩu mới ?", "Thông báo !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Vui lòng đợi đến khi có thông báo xác thực.");
                    string pass = CreatePassword(6);
                    try
                    {
                        MailMessage mail = new MailMessage();
                        //Server mail của Google
                        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("qlthuvien2017@gmail.com");
                        if (row.Cells["email"].Value.ToString().Trim() != "")
                        {
                            mail.To.Add(txtEmail.Text); // Email cần đến
                            mail.Subject = "Thông báo mật khẩu";
                            string content_mail = "Chào bạn, mật khẩu truy cập quản lý thư viện của bạn là: " + pass;
                            mail.Body = content_mail;
                            smtpServer.Port = 587;
                            smtpServer.Credentials = new NetworkCredential("qlthuvien2017@gmail.com", "Huynhtruong1996");
                            smtpServer.EnableSsl = true;
                            smtpServer.Send(mail);
                            MessageBox.Show("Gửi email đến: " + txtEmail.Text.Trim() + " thành công! \n Vào mail để kiểm tra mật khẩu được cấp.");
                            if (NhanVien.Update_Pass(manv, pass)) ;
                            else MessageBox.Show("Có lỗi khi tạo mật khẩu cho nhân viên. Liên hệ dev");
                        }
                        else MessageBox.Show("Email không đúng định dạng. Hoặc bị trống");
                        

                    }
                    catch
                    {
                        MessageBox.Show("Lổi xảy ra trong quá trình gửi mail. Kiểm tra lại định dạng email");
                    }
                    
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            else { }
            if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string manv = this.dtgvDanhSach.Rows[e.RowIndex].Cells["manhanvien"].Value.ToString();
                    if (NhanVien.Delete_NhanVien(manv))
                    {
                        MessageBox.Show("Đã xóa nhân viên !");
                        dtgvDanhSach.DataSource = NhanVien.ShowAllNhanVien();
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
                txtHoTen.Text = row.Cells["hoten"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtDiaChi.Text = row.Cells["diachi"].Value.ToString();
                CheckUpdate = true;
                manv = row.Cells["manhanvien"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmDangKyNhanVien frm = new frmDangKyNhanVien();
            frm.ShowDialog();
            dtgvDanhSach.DataSource = NhanVien.ShowAllNhanVien();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(CheckUpdate)
            {
                bool chk4 = false;
                bool chk5 = false;
                if (NhanVien.Check_Email(txtEmail.Text, manv))
                {
                    chk4 = false;
                    MessageBox.Show("- Mail đã tồn tại. Vui lòng đăng ký mail khác. \n");
                }
                else chk4 = true;
                if (!IsValid(txtEmail.Text))
                {
                    chk5 = false;
                    MessageBox.Show( "- Mail không đúng định dạng \n");
                }
                chk5 = true;
                if (chk4 && chk5)
                {
                    if (NhanVien.Update_NhanVien(manv, txtHoTen.Text.Trim(), txtDiaChi.Text, txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công");
                        dtgvDanhSach.DataSource = NhanVien.ShowAllNhanVien();
                        CheckUpdate = false;
                        gpThongTin.Enabled = false;
                        
                    }
                    else MessageBox.Show("Quá trình cập nhật thất bại");
                }
            }
        }
    }
}
