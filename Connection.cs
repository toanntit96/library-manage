using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLThuVien
{
    class Connection
    {
        string str_con = @"Data Source=DESKTOP-SFEN60G\SQLEXPRESS;Initial Catalog=quanlythuvien;Persist Security Info=True;User ID=sa;Password=system";
        public SqlConnection con { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader drd { get; set; }
        public SqlDataAdapter da { get; set; }

        public Connection()
        {
            con = new SqlConnection(str_con);
            cmd = null;
            drd = null;
            da = null;
        }
        public bool Open_Connect()
        {
            try
            {
                this.con.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Close_Connect()
        {
            try
            {
                this.con.Close();
                this.drd.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public SqlDataReader Execute_SQL (string str_select)
        {
            try
            {
                this.cmd = new SqlCommand(str_select, this.con);
                this.drd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                
            }
            catch { }
            return this.drd;
        }
        public  bool Excute_Update(string str_update)
        {
            try
            {
                this.cmd = new SqlCommand(str_update, this.con);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)  // Nó chỉ có 1 dòng thay đổi ko thể a > 1
                    return true;
                return false;
            }
            catch { return false; }
            
        }
        public DataTable getTable (string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                
                this.da = new SqlDataAdapter(sql, this.con);
                da.Fill(dt);
                
            }
            catch { }
            return dt;
        }
    }
}
