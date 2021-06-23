using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace QLThuVien
{
    class Database
    {
        #region Kiểm tra SQL có CSDL chưa, Tạo CSDL nếu chưa có
        public static bool KiemTraCSDL()
        {
            String Query = @"SELECT COUNT(Name) AS Tong FROM dbo.sysdatabases WHERE name = 'quanlythuvien'";
            String Kq = "";
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Kq = dr[0].ToString();
                }
                con.Close();
            }
            catch { }
            return Kq == "0" ? false : true;
        }
        public static bool KhoiTaoCSDL()
        {
            try
            {
                SqlCommand cmd;
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                con.Open();
                // Đọc file Sql vào biến String
                String Restore = null;
                try
                {
                    Restore = File.ReadAllText(@"data\db.sql");
                }
                catch
                {
                    OpenFileDialog oPen = new OpenFileDialog();
                    oPen.Filter = "File Image (*.sql)|*.sql; ";
                    if (oPen.ShowDialog() == DialogResult.OK)
                    {
                        Restore = File.ReadAllText(oPen.FileName);
                    }
                }
                // Tách lấy từng dòng Lệnh dựa vào tư GO, Trả về một Mảng
                var sqlqueries = Restore.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                cmd = new SqlCommand("query", con);
                foreach (var query in sqlqueries)
                {
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
        #endregion
    }
}
