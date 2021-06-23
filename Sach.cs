using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QLThuVien
{
    class Sach
    {
        public string MaS { get; set; }
        public string NhanDe { get; set; }
        public int SoTrang { get; set; }
        public int SoLuong { get; set; }
        public int NamXB { get; set; }
        public int LanXB { get; set; }
        public int SoLanMuon { get; set; }
        string MaLoai;
        public string NXB { get; set; }
        public string TacGia { get; set; }
        public string NgayNhap { get; set; }

        public Sach()
        {
            MaS = "";
            NhanDe = "";
            SoTrang = 0;
            SoLuong = 0;
            NamXB = 0;
            LanXB = 0;
            SoLanMuon = 0;
            MaLoai = "";
            NXB = "";
            TacGia = "";
            NgayNhap = "";
        }
        public Sach(string mas, string nhande, int sotrang, int sluong, int namxb, int lanxb, int solanmuon, string maloai, string nxb, string tacgia, string ngaynhap)
        {
            MaS = mas;
            NhanDe = nhande;
            SoTrang = sotrang;
            SoLuong = sluong;
            NamXB = namxb;
            LanXB = lanxb;
            SoLanMuon = solanmuon;
            MaLoai = maloai;
            NXB = nxb;
            TacGia = tacgia;
            NgayNhap = ngaynhap;
        }
        public static DataTable ShowAllSach()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT ROW_NUMBER() OVER(ORDER BY nhande) STT,masach , nhande,sotrang,soluong,namxb,lanxb,nxb,tacgia,CONVERT(VARCHAR(10),ngaynhap,103) as ngaynhap, tenloai " +
                  "  FROM tbl_sach a, tbl_phanloai b WHERE a.maloai = b.maloai ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        
        public static DataTable getSachFromLoai(string MaLoai)
        {
            DataTable dt = null;
            if (MaLoai != "System.Data.DataRowView")
            {
               
                Connection con = new Connection();
                if (con.Open_Connect() == true)
                {
                    dt = con.getTable("SELECT ROW_NUMBER() OVER(ORDER BY nhande) STT,masach ,nhande,sotrang,soluong,namxb,lanxb,nxb,tacgia,CONVERT(VARCHAR(10),ngaynhap,103) as ngaynhap, tenloai " +
                        "FROM tbl_sach a, tbl_phanloai b WHERE b.maloai = " + MaLoai + " AND a.maloai = b.maloai");
                }
                con.Close_Connect();
                
            }
            return dt;
        }
        public static DataTable getLoaiSach()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                dt = con.getTable("SELECT * FROM tbl_phanloai");
            }
            con.Close_Connect();
            return dt;
        }
        

        public static bool Insert_Sach(string nhande, int sotrang, int sluong, int namxb, int lanxb, string maloai, string nxb, string tacgia, string ngaynhap)
        {
            string sql = "INSERT INTO tbl_sach " +
                  " VALUES (N'" + nhande + "'," + sotrang + "," + sluong + "," + namxb + "," + lanxb + ",0,'" + maloai + "',N'" + nxb + "',N'" + tacgia + "','" + ngaynhap + "')";
            
            Connection con = new Connection();
            if(con.Open_Connect())
            {
                try
                {
                   
                    if (con.Excute_Update(sql)) return true;

                }
                catch
                {
                    return false;
                }
                
            }
            con.Close_Connect();
            return false;
        }

        public static bool Delete_Sach(string masach)
        {
            bool result;
            string sql = "DELETE FROM tbl_sach WHERE masach = '"+masach+"'";
            try
            {
                Connection con = new Connection();
                if (con.Open_Connect() == true)
                {
                    if (con.Excute_Update(sql))
                        return true;
                }
                con.Close_Connect();
            }
            catch
            { }
            return false;
        }
        public static bool Update_Sach(int masach, string nhande, int sotrang, int sluong, int namxb, int lanxb, string maloai, string nxb, string tacgia, string ngaynhap)
        {
            string sql = "UPDATE tbl_sach " +
            " SET nhande = N'" + nhande + "',sotrang = " + sotrang + ",soluong = " + sluong + ",namxb = " + namxb + ",lanxb = " + lanxb + ",solanmuon = 0, "+
            " maloai = " + maloai + ",nxb = N'" + nxb + "',tacgia = N'" + tacgia + "',ngaynhap = '" + ngaynhap + "'" +
            " WHERE masach = "+masach+"";

            Connection con = new Connection();
            if (con.Open_Connect())
            {
                try
                {

                    if (con.Excute_Update(sql)) return true;

                }
                catch
                {
                    return false;
                }

            }
            con.Close_Connect();
            return false;
        }
       
        

    }
}
