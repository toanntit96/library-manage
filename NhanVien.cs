using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace QLThuVien
{
    class NhanVien
    {
        string MaNV;
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        string MatKhau;
        public int QuyenHan { get; set; }

        public NhanVien(string manv, string hoten, string diac, string pass, int quyen)
        {
            this.MaNV = manv;
            this.HoTen = hoten;
            this.DiaChi = diac;
            this.MatKhau = pass;
            this.QuyenHan = quyen;
        }
        public static DataTable ShowAllNhanVien()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if(con.Open_Connect() == true)
            {
                dt = con.getTable("SELECT ROW_NUMBER() OVER(ORDER BY manhanvien) STT, manhanvien, hoten,diachi, email, quyenhan FROM tbl_nhanvien WHERE quyenhan != 0"); 
            }
            con.Close_Connect();
            return dt;

        }
        public static bool Insert_NhanVien (string hoten, string diac, string email)
        {
            string manv = NhanVien.get_MaNV();
            bool kq = false;
                string str_insert = "INSERT INTO tbl_nhanvien VALUES('"+manv+"',N'" + hoten + "',N'" + diac + "',CONVERT(VARCHAR(32), HashBytes('MD5', '123456'), 2),1,'"+email+"')";
                Connection con = new Connection();
                if (con.Open_Connect() == true)
                {
                    if (con.Excute_Update(str_insert) == true)
                        return true;
                    else return false;
                }
                con.Close_Connect();               
            
            return kq;
        }
        public static bool Update_NhanVien(string manv, string hoten, string diac, string email)
        {
            bool kq = false;
            string str_insert = "UPDATE tbl_nhanvien SET hoten = N'" + hoten + "', diachi = N'" + diac + "', email = '"+email+"'" +
                                "WHERE manhanvien = '"+manv+"'";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str_insert) == true)
                    return true;
                else return false;
            }
            con.Close_Connect();
            return kq;
        }
        public static bool Update_Pass(string manv, string pass)
        {
            bool kq = false;
            string str_insert = "UPDATE tbl_nhanvien SET matkhau = CONVERT(VARCHAR(32), HashBytes('MD5', '"+pass+"'), 2) " +
                                "WHERE manhanvien = '" + manv + "'";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str_insert) == true)
                    return true;
                else return false;
            }
            con.Close_Connect();
            return kq;
        }
        public static bool Delete_NhanVien(string manv)
        {
            bool kq = true;
            string str_insert = "DELETE FROM tbl_nhanvien WHERE manhanvien = '" + manv + "'";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str_insert) == true)
                    kq = true;
                else kq = false;
            }
            con.Close_Connect();
            return kq;
        }
        public static bool Check_Login(string user, string pass)
        {
            string sql = "SELECT * FROM tbl_nhanvien WHERE manhanvien ='"+user+ "' AND matkhau = CONVERT(VARCHAR(32), HashBytes('MD5', '" + pass + "'), 2)";
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
        public static int Get_QuyenHan(string user)
        {
            int quyen;
            string sql = "SELECT quyenhan FROM tbl_nhanvien WHERE manhanvien='"+user+"'";
            Connection con = new Connection();
            if (con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                drd.Read();
                quyen = (int)drd[0];
            }
            else
                quyen = -1;
            return quyen;    
        }
        public static string get_MaNV()
        {
            string manv = "NV";
            int stt = 0;
            Connection con = new Connection();
            SqlDataReader drd = null;
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT RIGHT(manhanvien,3) stt " +
                  "  FROM tbl_nhanvien WHERE manhanvien like '%NV%'";
                drd = con.Execute_SQL(sql);
                while (drd.Read())
                {
                    if (drd["stt"].ToString() != "")
                        stt = int.Parse(drd["stt"].ToString());
                    else stt = 0;
                }
                if (stt <= 999 && stt >= 99)
                {
                    manv += (stt + 1);
                }
                else
                    if (stt <= 99 && stt >= 9) manv += "0" + (stt + 1);
                else manv += "00" + (stt + 1);

            }
            con.Close_Connect();
            return manv;

        }
        public static bool Check_Name(string tennv)
        {
            if(string.IsNullOrEmpty(tennv))
            {
                return false;
            }
            else
            {
                string pattern = @"^\D+$";
                string str = tennv.TrimEnd().TrimStart();
                int i = str.IndexOf(" ");
                if (i == -1)
                    return false;
                else
                    if (Regex.IsMatch(str, pattern))
                        return true;
                    else
                        return false;                  
            }
        }
        public static bool Check_Email(string email, string manhanvien)
        {
            string sql = "SELECT * FROM tbl_nhanvien WHERE email = '"+email+"' AND manhanvien != '"+manhanvien+"'";
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


    }
}
