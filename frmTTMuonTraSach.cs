using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QLThuVien
{
    public partial class frmTTMuonTraSach : Form
    {
        string MaS_Old { get; set; }
        int maphieu { get; set; } 
        public frmTTMuonTraSach()
        {
            InitializeComponent();
        }

        private void frmTTMuonTraSach_Load(object sender, EventArgs e)
        {
            /////////////////////////// CẬP NHẬT LẠI TOÀN BỘ PHIẾU MƯỢN
            if(MuonTraSach.chk_CoPhieuMuon())
            {
                MuonTraSach.CapNhat_PhieuMuon();
                
            }
            

            dtgv_dsMuonTra.DataSource = MuonTraSach.ShowAllPhieuMuon_ChuaTra();
            btnTraSach.Enabled = false;
            simpleButton1.Enabled = false;
            btnMuonSach.Enabled = false;
            //////////////////////// Combobox trong groupbox Danh sách

            cmbTrangThai.DataSource = MuonTraSach.getTrangThaiSach();
            cmbTrangThai.DisplayMember = "trangthai";
            cmbTrangThai.ValueMember = "matrangthai";


            ///////////////////////// combobox trong thông tin mượn
            /////////////////////// Label Ngày mượn - ngày trả
            lblNgayMuon.Text = DateTime.Now.ToString("dd'/'MM'/'yyyy");
            lblNgayTra.Text = DateTime.Now.AddDays(7).ToString("dd'/'MM'/'yyyy");
            /////////////////////////// Combobox đọc giả
            cmbDocGia.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDocGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDocGia.DisplayMember = "madocgia";
            cmbDocGia.ValueMember = "madocgia";
            cmbDocGia.DataSource = DocGia.ShowAllDocGia();
            ///////////////////////////// combobox loại sách
            cmbLoaiSach.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbLoaiSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLoaiSach.DataSource = MuonTraSach.getLoaiSach();
            cmbLoaiSach.DisplayMember = "tenloai";
            cmbLoaiSach.ValueMember = "maloai";


        }

        private void txtDocGia_TextChanged(object sender, EventArgs e)
        {
            dtgv_dsMuonTra.DataSource = MuonTraSach.GetPhieuMuon_DocGia(txtDocGia.Text);
        }

        private void dtgv_dsMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv_dsMuonTra.Rows[e.RowIndex];
                MaS_Old = row.Cells["masach"].Value.ToString();
                maphieu = int.Parse(row.Cells["maphieumuon"].Value.ToString());
                string trangthai = row.Cells["trangthai"].Value.ToString();
                if (MaS_Old != "" && trangthai == "Đang mượn")
                {
                    btnTraSach.Enabled = true;
                    simpleButton1.Enabled = true;
                }

                else
                {
                    btnTraSach.Enabled = false;
                    simpleButton1.Enabled = false;
                }
                
            }
            
        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTrangThai.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                dtgv_dsMuonTra.DataSource = MuonTraSach.getPhieuMuon_FormTrangThai(int.Parse(cmbTrangThai.SelectedValue.ToString()), txtDocGia.Text);
            }

        }

        private void cmbLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiSach.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                
                if (MuonTraSach.getNhanDe(int.Parse(cmbLoaiSach.SelectedValue.ToString())).Rows.Count > 0)
                {
                    cmbNhanDe.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cmbNhanDe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmbNhanDe.DataSource = MuonTraSach.getNhanDe(int.Parse(cmbLoaiSach.SelectedValue.ToString()));
                    cmbNhanDe.DisplayMember = "nhande";
                    cmbNhanDe.ValueMember = "masach";
                    btnMuonSach.Enabled = true;
                }
                else
                {
                    cmbNhanDe.DataSource = null;
                    cmbNhanDe.DisplayMember = "";
                    cmbNhanDe.ValueMember = "";
                }  
            }
        }

        private void cmbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MuonTraSach.getTTDocGia(cmbDocGia.SelectedValue.ToString());
            if(dt.Rows.Count > 0)
            {
                lblMaDocGia.Text = dt.Rows[0]["madocgia"].ToString();
                lblHoTen.Text = dt.Rows[0]["hoten"].ToString();
                lblNgaySinh.Text = dt.Rows[0]["ngaysinh"].ToString();
                lblDiaChi.Text = dt.Rows[0]["diachi"].ToString();
                lblKhoa.Text = dt.Rows[0]["tenkhoa"].ToString();
                lblNgayLapThe.Text = dt.Rows[0]["ngaylapthe"].ToString();

            }
            
        }
        private void cmbNhanDe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            bool chk_muon1 = false;
            bool chk_muon2 = false;
            bool chk_muon3 = false;
            bool chk_muon4 = false;
            bool chk_muon5 = false;
            string err = "Kiểm tra lại các thông tin sau: \n";
            if (cmbDocGia.Text.Length == 0)
            {
                err += "- Mã đọc giả. \n";
                chk_muon1 = false;
            }
            else chk_muon1 = true;
            if (cmbLoaiSach.Text.Length == 0)
            {
                err += "- Loại sách. \n";
                chk_muon2 = false;
            }
            else chk_muon2 = true;
            if (cmbNhanDe.Text.Length == 0)
            {
                err += "- Nhan đề. \n";
                chk_muon3 = false;
            }
            else chk_muon3 = true;
            if (MuonTraSach.Check_CoPhieuMuon(cmbDocGia.Text, int.Parse(cmbNhanDe.SelectedValue.ToString())))
            {
                err += "- Đọc giả đã mượn sách này. Và chưa hoàn trả!!!";
                chk_muon4 = false;
            }
            else chk_muon4 = true;
            if (!MuonTraSach.Check_ConSachTrongKho(int.Parse(cmbNhanDe.SelectedValue.ToString())))
            {
                err += "- Trong kho đã hết tựa sách này. Vui lòng kiểm tra lại";
                chk_muon5 = false;
            }
            else chk_muon5 = true;
            if (chk_muon1 && chk_muon2 && chk_muon3 && chk_muon4 && chk_muon5)
            {
                string ngaymuon = "";
                ngaymuon += DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Year.ToString();
                string manv = "nv001";

                if (MuonTraSach.Insert_PhieuMuon(cmbDocGia.Text, int.Parse(cmbNhanDe.SelectedValue.ToString()), manv, ngaymuon))
                {
                    MessageBox.Show("Đã xác nhận mượn sách");
                    dtgv_dsMuonTra.DataSource = MuonTraSach.ShowAllPhieuMuon_ChuaTra();
                }
                else MessageBox.Show("Đã xảy ra lỗi !!!");
            }
            else MessageBox.Show(err);
        }

        private void chkbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbAll.Checked == true)
            {
                dtgv_dsMuonTra.DataSource = MuonTraSach.ShowAllPhieuMuon();
            }
            else dtgv_dsMuonTra.DataSource = MuonTraSach.ShowAllPhieuMuon_ChuaTra();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if(MuonTraSach.Tra_Sach(maphieu))
            {
                MessageBox.Show("Đã thực thi thao tác hoàn trả sách.");
                dtgv_dsMuonTra.DataSource = MuonTraSach.ShowAllPhieuMuon_ChuaTra();
            }
            else MessageBox.Show("Không được phép hoàn trả sách.");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MuonTraSach.GiaHan_Sach(maphieu))
            {
                MessageBox.Show("Đã thực thi gia hạn sách");
                dtgv_dsMuonTra.DataSource = MuonTraSach.ShowAllPhieuMuon_ChuaTra();

            }
            else MessageBox.Show("Không được phép gia hạn sách. \n ***Lưu ý: Chỉ được gia hạn nếu còn 3 ngày nữa đến ngày trả.");
        }

        
    }
}
