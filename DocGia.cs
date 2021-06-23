using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLThuVien
{
    class DocGia
    {
        string MaDG;
        public string HoTenDG { get; set; }
        public string NgayS { get; set; }
        public string MaKhoa { get; set; }
        public string DiaChiDG { get; set; }
        public string NgayLapThe { get; set; }
        string MatKhau;
        public DocGia(string madg, string ht, string ngs, string mak, string dc, string nglapthe, string pass)
        {
            MaDG = madg;
            HoTenDG = ht;
            NgayS = ngs;
            MaKhoa = mak;
            DiaChiDG = dc;
            NgayLapThe = nglapthe;
            MatKhau = pass;
        }
        public DocGia()
        {
            MaDG = "";
            HoTenDG = "";
            NgayS = "";
            MaKhoa = "";
            DiaChiDG ="" ;
            NgayLapThe = "";
            MatKhau = "";
        }
        public static DataTable ShowAllDocGia()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT ROW_NUMBER() OVER(ORDER BY madocgia) STT, madocgia, hoten,CONVERT(VARCHAR(10),ngaysinh,103) as ngaysinh, a.makhoa, a.diachi,CONVERT(VARCHAR(10),ngaylapthe,103) as ngaylapthe, tenkhoa " +
                  "  FROM tbl_docgia a, tbl_khoa b WHERE a.makhoa = b.makhoa ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static DataTable GetDocGia_FromKhoa(string makhoa)
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (makhoa != "System.Data.DataRowView")
                {
                    string sql = "SELECT ROW_NUMBER() OVER(ORDER BY madocgia) STT, madocgia, hoten,CONVERT(VARCHAR(10),ngaysinh,103) as ngaysinh, a.makhoa, a.diachi,CONVERT(VARCHAR(10),ngaylapthe,103) as ngaylapthe, tenkhoa " +
                  "  FROM tbl_docgia a, tbl_khoa b WHERE a.makhoa = b.makhoa AND b.makhoa = '" + makhoa + "'";
                    dt = con.getTable(sql);
                    con.Close_Connect();
                }
                    
            }
            
            return dt;
        }
        public static DataTable LayDocGia_MaDocGia(string madg)
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                
                    string sql = "SELECT madocgia FROM tbl_docgia WHERE madocgia = '"+madg+"'";
                    dt = con.getTable(sql);
                    con.Close_Connect();
                

            }

            return dt;
        }
        public static DataTable GetAllKhoa()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT tenkhoa, makhoa " +
                  "  FROM tbl_khoa ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static string GetMaDocGia()
        {
            string madocgia = "DG";
            int stt = 0;
            Connection con = new Connection();
            SqlDataReader drd = null;
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT RIGHT(madocgia,3) stt " +
                  "  FROM tbl_docgia ";
                drd = con.Execute_SQL(sql);
                while(drd.Read())
                {
                    if (drd["stt"].ToString() != "")
                        stt = int.Parse(drd["stt"].ToString());
                    else stt = 0;
                }
                if(stt <=999 && stt >= 99)
                {
                    madocgia += (stt+1);
                }
                else
                    if(stt<=99 && stt >= 9) madocgia += "0" + (stt + 1);
                    else madocgia += "00" + (stt + 1);

            }
            con.Close_Connect();
            return madocgia;
        }

        public static bool Insert_DocGia(string madg, string ht, string ngs, string makhoa, string dc, string nglapthe)
        {
            
            
                string str_insert = "INSERT INTO tbl_docgia " +
                " VALUES('" + madg + "',N'" + ht + "','" + ngs + "','" + makhoa + "',N'" + dc + "','" + nglapthe + "',CONVERT(VARCHAR(32), HashBytes('MD5', '123456'), 2))";
                Connection con = new Connection();
                if (con.Open_Connect() == true)
                {
                if (con.Excute_Update(str_insert) == true)
                {
                    return true;
                }
                else return false;
                    
                }
                con.Close_Connect();
           
            return false;

        }
        public static bool Update_DocGia(string madg, string ht, string ngs, string makhoa, string dc, string nglapthe)
        {
            
            string str_insert = "UPDATE tbl_docgia SET hoten = N'" + ht + "',ngaysinh = '" + ngs + "',makhoa = '"+makhoa+"', diachi = N'"+dc+"', ngaylapthe = '"+nglapthe+"'" +
                                "WHERE madocgia = '" + madg + "'";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str_insert) == true)
                {
                    return true;
                }
                else return false;
            }
            con.Close_Connect();
            return false;
        }
        public static bool Delete_DocGia(string madg)
        {
           
            string str_del = "DELETE FROM tbl_docgia WHERE madocgia = '" + madg + "'";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str_del) == true)
                {
                    return true;
                }
                else return false;
            }
            con.Close_Connect();
            return false;
        }


        /* Dùng cho form Login */
        public static bool Check_Login(string user, string pass)
        {
            string sql = "SELECT * FROM tbl_docgia WHERE madocgia ='" + user + "' AND matkhau = CONVERT(VARCHAR(32), HashBytes('MD5', '"+pass+"'), 2)";
            Connection con = new Connection();
            if (con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                if (drd.Read())
                    return true;
                else return false;
            }
            else return false;
        }

        public static DocGia get_DocGia(string sql)
        {
            DocGia DG =  new DocGia();
            Connection con = new Connection();
            if(con.Open_Connect() == true)
            {
                DataTable dt;
                dt = con.getTable(sql);
                foreach(DataRow row in dt.Rows)
                {
                    DG.MaDG = row["madocgia"].ToString();
                    DG.HoTenDG = row["hoten"].ToString();
                    DG.NgayS = row["ngaysinh"].ToString();
                    DG.MaKhoa = row["makhoa"].ToString();
                    DG.DiaChiDG = row["diachi"].ToString();
                    DG.NgayLapThe = row["ngaylapthe"].ToString();
                    DG.MatKhau = row["matkhau"].ToString();
                }
            }
            con.Close_Connect();
            return DG;

        }
        public static bool chkDocGia_CoPhieuMuon(string madg)
        {
            bool kq = false;
            string sql = "SELECT * FROM tbl_phieumuon WHERE madocgia ='" + madg + "' " +
                " AND trangthai = 0 "; 
            Connection con = new Connection();
            if (con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                if (drd.Read())
                    return true;
                else return false;
            }
            else return false;
            return kq;
        }
        ///////////////////////////// XỬ LÝ tbl_Khoa
        public static DataTable ShowAllKhoa()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT ROW_NUMBER() OVER(ORDER BY makhoa) STT, makhoa, tenkhoa " +
                  "  FROM tbl_khoa ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static bool Insert_Khoa(string makhoa, string tenk)
        {


            string str_insert = "INSERT INTO tbl_khoa " +
            " VALUES('" + makhoa + "',N'" + tenk + "',null, null) ";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str_insert) == true)
                {
                    return true;
                }
                else return false;

            }
            con.Close_Connect();

            return false;

        }
        public static bool Update_Khoa(string makhoa_old, string makhoa_new, string tenk)
        {

            string str_insert = "UPDATE tbl_khoa SET makhoa = '"+makhoa_new+"', tenkhoa = N'"+tenk+"' " +
                                "WHERE makhoa = '" + makhoa_old + "'";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str_insert) == true)
                {
                    return true;
                }
                else return false;
            }
            con.Close_Connect();
            return false;
        }
        public static bool Delete_Khoa(string makhoa)
        {

            string str_del = "DELETE FROM tbl_khoa WHERE makhoa = '" + makhoa + "'";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str_del) == true)
                {
                    return true;
                }
                else return false;
            }
            con.Close_Connect();
            return false;
        }
        public static bool chkKhoa_CoDocGia(string makhoa)
        {
            bool kq = false;
            string sql = "SELECT * FROM tbl_khoa a, tbl_docgia b, tbl_phieumuon c " +
                " WHERE b.makhoa ='" + makhoa + "' AND a.makhoa = b.makhoa AND b.madocgia = c.madocgia " +
                " AND trangthai = 0 ";
            Connection con = new Connection();
            if (con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                if (drd.Read())
                    return true;
                else return false;
            }
            else return false;
            return kq;
        }
        public static bool chkTonTai_MaKhoa (string makhoa)
        {
            bool kq = false;
            string sql = "SELECT * FROM tbl_khoa " +
                " WHERE makhoa ='" + makhoa + "' ";
               
            Connection con = new Connection();
            if (con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                if (drd.Read())
                    return true;
                else return false;
            }
            else return false;
            return kq;
        }
        public static bool chkTonTai_TenKhoa(string tenkhoa)
        {
            bool kq = false;
            string sql = "SELECT * FROM tbl_khoa " +
                " WHERE tenkhoa ='" + tenkhoa + "' ";

            Connection con = new Connection();
            if (con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                if (drd.Read())
                    return true;
                else return false;
            }
            else return false;
            return kq;
        }
    

    }
}
