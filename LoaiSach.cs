using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLThuVien
{
    class LoaiSach
    {
        int maloai{ get; set; }
        string tenloai { get; set; }

        public LoaiSach()
        {
            maloai = 0;
            tenloai = "";
        }
        public static DataTable ShowAll_LoaiS()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT ROW_NUMBER() OVER(ORDER BY maloai) STT,* FROM tbl_phanloai ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static bool Insert_LoaiS(string ten)
        {
            string sql = "INSERT INTO tbl_phanloai VALUES (N'"+ten+"')";
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
        public static bool Update_LoaiS(int maloai, string tenloai)
        {
            string sql = "UPDATE tbl_phanloai SET tenloai = N'"+tenloai+"' WHERE maloai = "+maloai+"";
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
        public static bool Delete_LoaiS(int maloai)
        {
            string sql = "DELETE FROM tbl_phanloai WHERE maloai = " + maloai + "";
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
        public static bool Check_ExistTenLoai(string tenloai)
        {
            SqlDataReader drd = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT * FROM tbl_phanloai WHERE tenloai = N'"+tenloai+"' OR tenloai like '%"+tenloai+"%' ";
                drd = con.Execute_SQL(sql);
                while (drd.Read()) return true;
            }
            con.Close_Connect();
            return false;
        }
    }
}
