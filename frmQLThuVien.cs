using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmQLThuVien : Form
    {
        
        public static int phanQuyen = -1;

        public frmQLThuVien()
        {
            // Kiểm tra kết nối
            if (!Database.KiemTraCSDL())
            {
                if (!Database.KhoiTaoCSDL())
                { MessageBox.Show("Khởi Tạo CSDL Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            InitializeComponent();
            Show_MenuUser();
            try
            {
                SqlClientPermission perm = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                perm.Demand();
            }
            catch
            {
                throw new ApplicationException("No permission");
            }
            
        }
        public void Show_MenuUser()
        {
            menuitem_NguoiDung.Visible = true;
            menuitem_QLSach.Visible = true;
            itemDangNhap.Visible = true;

            item_TTCaNhan.Visible = false;
            item_DoiMatKhau.Visible = false;
            item_DangXuat.Visible = false;
            itemCapNhatTTSach.Visible = false;
            menuitem_QLDocGia.Visible = false;
            menuitem_QLMuonTra.Visible = false;
            menuitem_QTHeThong.Visible = false;
            menuitem_TimKiem.Visible = false;
            menuitem_TK_BC.Visible = false;
        }
        public void Show_MenuDocGia()
        {
            menuitem_NguoiDung.Visible = true;
            menuitem_QLSach.Visible = true;
            menuitem_QLMuonTra.Visible = true;
            itemTracuuSach.Visible = true;
            item_TTCaNhan.Visible = true;
            item_DoiMatKhau.Visible = true;
            item_DangXuat.Visible = true;

            menuitem_QLDocGia.Visible = false;
            itemMuonTraSach.Visible = false;
            menuitem_QTHeThong.Visible = false;
            menuitem_TimKiem.Visible = false;
            menuitem_TK_BC.Visible = false;
            itemDangNhap.Visible = false;
            itemCapNhatTTSach.Visible = false;

        }
        public void Show_MenuAdmin()
        {
            menuitem_NguoiDung.Visible = true;  
            menuitem_QTHeThong.Visible = true;
            menuitem_TimKiem.Visible = true;
            menuitem_TK_BC.Visible = true;
            item_TTCaNhan.Visible = true;
            item_DoiMatKhau.Visible = true;
            item_DangXuat.Visible = true;
            itemTKDanhSachNV.Visible = true;


            menuitem_QLDocGia.Visible = false;
            menuitem_QLMuonTra.Visible = false;
            menuitem_QLSach.Visible = false;
            itemDangNhap.Visible = false;

        }
        public void Show_MenuThuthu()
        {
            menuitem_NguoiDung.Visible = true;
            menuitem_QLMuonTra.Visible = true;
            menuitem_QLSach.Visible = true;
            menuitem_QLDocGia.Visible = true;
            menuitem_TimKiem.Visible = true;
            menuitem_TK_BC.Visible = true;
            item_TTCaNhan.Visible = true;
            item_DoiMatKhau.Visible = true;
            item_DangXuat.Visible = true;
            itemCapNhatTTSach.Visible = true;

            menuitem_QTHeThong.Visible = false;
            itemDangNhap.Visible = false;
            itemTKDanhSachNV.Visible = false;


        }
        private void frmQLThuVien_Load(object sender, EventArgs e)
        {
            
            frmLogin frmlgin = new frmLogin();
            frmlgin.StartPosition = FormStartPosition.CenterScreen;
            frmlgin.ShowDialog();
            switch(phanQuyen)
            {
                case 0:
                    Show_MenuAdmin();
                    break;
                case 1:
                    Show_MenuThuthu();
                    break;
                case 2:
                    Show_MenuDocGia();
                    break;
                default:
                    Show_MenuUser();
                    break;
            }
            

        }

        private void itemDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frmlgin = new frmLogin();
            frmlgin.StartPosition = FormStartPosition.CenterScreen;
            frmlgin.ShowDialog();
            switch (phanQuyen)
            {
                case 0:
                    Show_MenuAdmin();
                    break;
                case 1:
                    Show_MenuThuthu();
                    break;
                case 2:
                    Show_MenuDocGia();
                    break;
                default:
                    Show_MenuUser();
                    break;
            }

        }

        private void item_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn đăng xuất ?",
                    "Thông báo -  Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Show_MenuUser();
                phanQuyen = -1;
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void item_TTCaNhan_Click(object sender, EventArgs e)
        {
            frmTTCaNhanDocGia frmTTCNDG = new frmTTCaNhanDocGia();
            frmTTCNDG.MdiParent = this;
            frmTTCNDG.Show();
        }

        private void itemCapNhatTTSach_Click(object sender, EventArgs e)
        {
            frmTTSach frm = new frmTTSach();
            frm.Show();
              
        }

        private void cậpNhậtThôngTinĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTTDocGia frm = new frmTTDocGia();
            frm.Show();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTTMuonTraSach frm = new frmTTMuonTraSach();
            frm.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpNhanVien rpt = new rpNhanVien();
            Connection kn = new Connection();
            kn.Open_Connect();
            rpt.DataSource = kn.getTable("SELECT ROW_NUMBER() OVER(ORDER BY manhanvien) STT,manhanvien ,hoten,email, diachi FROM tbl_nhanvien ");
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }

        private void itemTHemNhanVien_Click(object sender, EventArgs e)
        {
            frmDangKyNhanVien frm = new frmDangKyNhanVien();
            frm.Show();
        }

        private void itemSuaDoiThongTinNV_Click(object sender, EventArgs e)
        {
            frmTTNhanVien frm = new QLThuVien.frmTTNhanVien();
            frm.Show();
        }

        private void itemThongKeTTSach_Click(object sender, EventArgs e)
        {
            rpTTSach rpt = new rpTTSach();
            Connection kn = new Connection();
            kn.Open_Connect();
            rpt.DataSource = kn.getTable("SELECT ROW_NUMBER() OVER(ORDER BY nhande) STT , nhande,sotrang,soluong as soluongton,namxb,nxb,tacgia, tenloai as theloai " +
                  "  FROM tbl_sach a, tbl_phanloai b WHERE a.maloai = b.maloai");
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}
