using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace QLThuVien
{
    public partial class frmDangKyNhanVien : Form
    {
        /*
         * CODE GỬI MAIL
         * 
         * */
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
        public frmDangKyNhanVien()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string err = "Kiểm tra lại các thông tin: \n";
            bool chk2 = false;
            bool chk3 = false;
            bool chk4 = false;
            bool chk5 = false;
            bool chk6 = false;
            if (txtHoTen.Text.Length == 0)
            {
                chk2 = false;
                err += "- Thông tin họ tên. \n";
            }
            else chk2 = true;
            if (txtEmail.Text.Length == 0)
            {
                chk3 = false;
                err += "- Thông tin email không được rỗng. \n";

            }
            else
            {
                chk3 = true;
                if (NhanVien.Check_Email(txtEmail.Text,txtMaNV.Text))
                {
                    chk4 = false;
                    err += "- Mail đã tồn tại. Vui lòng đăng ký mail khác. \n";
                }
                else chk4 = true;
                if (!IsValid(txtEmail.Text))
                {
                    chk5 = false;
                    err += "- Mail không đúng định dạng \n";
                }
                else chk5 = true;
            }
            
            if (txtDiaChi.Text.Length == 0)
            {
                chk6 = false;
                err += "- Thông tin địa chỉ. \n";
            }
            else chk6 = true;
            if (chk2 && chk3 && chk4 && chk5 && chk6)
            {
                if(NhanVien.Insert_NhanVien(txtHoTen.Text,txtDiaChi.Text,txtEmail.Text))
                {
                    
                    MessageBox.Show("Thêm mới thành công");
                    string pass = CreatePassword(6);
                    try
                    {
                        MailMessage mail = new MailMessage();

                        //Server mail của Google
                        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("qlthuvien2017@gmail.com");

                        mail.To.Add(txtEmail.Text); // Email cần đến
                        mail.Subject = "Thông báo mật khẩu";
                        string content_mail = "Chào bạn, mật khẩu truy cập quản lý thư viện của bạn là: "+ pass;
                        mail.Body = content_mail;
                        smtpServer.Port = 587;
                        smtpServer.Credentials = new NetworkCredential("qlthuvien2017@gmail.com","Huynhtruong1996");
                        smtpServer.EnableSsl = true;
                        smtpServer.Send(mail);
                        MessageBox.Show("Gửi email đến: " + txtEmail.Text.Trim() + " thành công !");
                      
                    }
                    catch
                    {
                        MessageBox.Show("Lổi xảy ra trong quá trình gửi mail !!!");
                    }
                    if (NhanVien.Update_Pass(txtMaNV.Text.Trim(), pass)) ;
                    else MessageBox.Show("Có lỗi khi tạo mật khẩu cho nhân viên. Liên hệ dev");

                }   
                else MessageBox.Show("Phát sinh lỗi trong quá trình thêm mới nhân viên");
            }
            else
                MessageBox.Show(err);
                
        }

        private void frmDangKyNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = NhanVien.get_MaNV();
        }
    }
}
