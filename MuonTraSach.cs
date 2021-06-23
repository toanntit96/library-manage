using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QLThuVien
{
    class MuonTraSach
    {
        string madocgia { get; set; }
        string ngaymuon { get; set; }
        string masach { get; set; }
        string manhanvien { get; set; }
        int soluong { get; set; }
        int trangthai { set; get; }
        int maphieumuon { get; set; }

        public MuonTraSach()
        {
            madocgia = "";
            ngaymuon = "";
            masach = "";
            manhanvien = "";
            soluong = 0;
            trangthai = 0;
            maphieumuon = 0;
        }
        public static DataTable ShowAllPhieuMuon()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT d.maphieumuon,d.madocgia, a.hoten,d.masach, e.nhande sachmuon, CONVERT(VARCHAR(10),d.ngaymuon,103) ngaymuon, " +
                             "   CONVERT(VARCHAR(10), DATEADD(DAY, 7, d.ngaymuon), 103) ngaytra, d.soluong, " +
                             "   CASE d.trangthai WHEN 0 THEN N'Đang mượn' WHEN 1 THEN N'Đã trả' ELSE N'Quá hạn' END AS trangthai, " +
                              "  c.hoten hotennhanvien " +
                      "  FROM tbl_docgia a, tbl_khoa b, tbl_nhanvien c, tbl_phieumuon d, tbl_sach e " +
                      "  WHERE " +
                      "  a.madocgia = d.madocgia " +
                      "  AND a.makhoa = b.makhoa " +
                      "  AND d.manhanvien = c.manhanvien " +
                      "  AND e.masach = d.masach " +
                      "  ORDER BY madocgia ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static DataTable ShowAllPhieuMuon_ChuaTra()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT d.maphieumuon,d.madocgia, a.hoten,d.masach, e.nhande sachmuon, CONVERT(VARCHAR(10),d.ngaymuon,103) ngaymuon, "+ 
                             "   CONVERT(VARCHAR(10), DATEADD(DAY, 7, d.ngaymuon), 103) ngaytra, d.soluong, " +
		                     "   CASE d.trangthai WHEN 0 THEN N'Đang mượn' WHEN 1 THEN N'Đã trả' ELSE N'Quá hạn' END AS trangthai, "+
		                      "  c.hoten hotennhanvien " +
                      "  FROM tbl_docgia a, tbl_khoa b, tbl_nhanvien c, tbl_phieumuon d, tbl_sach e "+
                      "  WHERE "+
                      "  a.madocgia = d.madocgia "+
                      "  AND a.makhoa = b.makhoa " +
                      "  AND d.manhanvien = c.manhanvien " +
                      "  AND e.masach = d.masach "+
                      " AND d.trangthai = 0"+
                      "  ORDER BY madocgia ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static DataTable GetPhieuMuon_DocGia(string docgia)
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT d.maphieumuon,d.madocgia, a.hoten, d.masach, e.nhande sachmuon, CONVERT(VARCHAR(10),d.ngaymuon,103) ngaymuon, " +
                             "   CONVERT(VARCHAR(10), DATEADD(DAY, 7, d.ngaymuon), 103) ngaytra, d.soluong, " +
                             "   CASE d.trangthai WHEN 0 THEN N'Đang mượn' WHEN 1 THEN N'Đã trả' ELSE N'Quá hạn' END AS trangthai, " +
                              "  c.hoten hotennhanvien " +
                      "  FROM tbl_docgia a, tbl_khoa b, tbl_nhanvien c, tbl_phieumuon d, tbl_sach e " +
                      "  WHERE " +
                      "  a.madocgia = d.madocgia " +
                      "  AND a.makhoa = b.makhoa " +
                      "  AND d.manhanvien = c.manhanvien " +
                      "  AND e.masach = d.masach " +
                      "  AND d.madocgia LIKE '%" + docgia + "%'" +
                      " ORDER BY d.madocgia ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static DataTable getTrangThaiSach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("matrangthai");
            dt.Columns.Add("trangthai");
            dt.Rows.Add(0,"Đang mượn");
            dt.Rows.Add(1, "Đã trả");
            dt.Rows.Add(2, "Quá hạn");
            return dt;
        }
        public static DataTable getPhieuMuon_FormTrangThai(int matrangthai, string docgia)
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "";
                if(docgia != "")
                {
                    
                    sql = "SELECT d.maphieumuon,d.madocgia, a.hoten, d.masach, e.nhande sachmuon, CONVERT(VARCHAR(10),d.ngaymuon,103) ngaymuon, " +
                            "   CONVERT(VARCHAR(10), DATEADD(DAY, 7, d.ngaymuon), 103) ngaytra, d.soluong, " +
                            "   CASE d.trangthai WHEN 0 THEN N'Đang mượn' WHEN 1 THEN N'Đã trả' ELSE N'Quá hạn' END AS trangthai, " +
                             "  c.hoten hotennhanvien " +
                     "  FROM tbl_docgia a, tbl_khoa b, tbl_nhanvien c, tbl_phieumuon d, tbl_sach e " +
                     "  WHERE " +
                     "  a.madocgia = d.madocgia " +
                     "  AND a.makhoa = b.makhoa " +
                     "  AND d.manhanvien = c.manhanvien " +
                     "  AND e.masach = d.masach " +
                     "  AND d.madocgia LIKE '%" + docgia + "%' AND d.trangthai = "+matrangthai+" " +
                     " ORDER BY d.madocgia ";
                }
                else
                {
                     sql = "SELECT d.maphieumuon,d.madocgia, a.hoten, d.masach, e.nhande sachmuon, CONVERT(VARCHAR(10),d.ngaymuon,103) ngaymuon, " +
                            "   CONVERT(VARCHAR(10), DATEADD(DAY, 7, d.ngaymuon), 103) ngaytra, d.soluong, " +
                            "   CASE d.trangthai WHEN 0 THEN N'Đang mượn' WHEN 1 THEN N'Đã trả' ELSE N'Quá hạn' END AS trangthai, " +
                             "  c.hoten hotennhanvien " +
                     "  FROM tbl_docgia a, tbl_khoa b, tbl_nhanvien c, tbl_phieumuon d, tbl_sach e " +
                     "  WHERE " +
                     "  a.madocgia = d.madocgia " +
                     "  AND a.makhoa = b.makhoa " +
                     "  AND d.manhanvien = c.manhanvien " +
                     "  AND e.masach = d.masach AND d.trangthai = "+matrangthai+" " +
                     " ORDER BY d.madocgia ";
                }
               
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static DataTable getLoaiSach()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT maloai, tenloai " +
                  "  FROM tbl_phanloai";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static DataTable getNhanDe(int maloaisach)
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT masach, nhande" +
                  "  FROM tbl_phanloai a, tbl_sach b " +
                  "WHERE a.maloai = b.maloai AND a.maloai = "+maloaisach+" ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static DataTable getTTDocGia(string madocgia)
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT  madocgia, hoten,CONVERT(VARCHAR(10),ngaysinh,103) as ngaysinh, a.diachi,CONVERT(VARCHAR(10),ngaylapthe,103) as ngaylapthe, tenkhoa " +
                  "  FROM tbl_docgia a, tbl_khoa b WHERE a.makhoa = b.makhoa  AND a.madocgia = '"+madocgia+"' ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static DataTable getDocGiaAll()
        {
            DataTable dt = null;
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                string sql = "SELECT  madocgia, hoten,CONVERT(VARCHAR(10),ngaysinh,103) as ngaysinh, a.diachi,CONVERT(VARCHAR(10),ngaylapthe,103) as ngaylapthe, tenkhoa " +
                  "  FROM tbl_docgia a, tbl_khoa b WHERE a.makhoa = b.makhoa ";
                dt = con.getTable(sql);
            }
            con.Close_Connect();
            return dt;
        }
        public static bool Insert_PhieuMuon(string madg, int masach, string manv, string ngaymuon)
        {
            bool status = false;
            
                string str_insert = "INSERT INTO tbl_phieumuon VALUES('" + madg + "','"+ngaymuon+"'," + masach + ",'"+manv+"',1,0)";
                Connection con = new Connection();
                if (con.Open_Connect() == true)
                {
                    if (con.Excute_Update(str_insert) == true)
                        return true;
                    else return false;
                }
                con.Close_Connect();
            
            return status;

        }
        public static bool Tra_Sach(int maphieumuon)
        {
            bool status = false;
            Connection con = new Connection();
            string str = "UPDATE tbl_phieumuon SET trangthai = 1 WHERE maphieumuon = " + maphieumuon + "" +
                "AND CAST(GETDATE() AS DATE) <= CAST(DATEADD (Day,7,ngaymuon) AS DATE)" +
                "AND trangthai != 1 AND trangthai != 2";
                
                if (con.Open_Connect() == true)
                {
                    if (con.Excute_Update(str) == true)
                        return true;
                    else return false;
                }
                con.Close_Connect();
            
            return status;

        }
        public static bool GiaHan_Sach(int maphieumuon)
        {
            bool status = false;
            string str = "UPDATE tbl_phieumuon SET ngaymuon =  CAST(DATEADD (Day,7,ngaymuon) AS DATE) WHERE maphieumuon = " + maphieumuon + " " +
               "AND DATEDIFF(day,CAST(GETDATE() AS DATE), CAST(DATEADD (Day,7,ngaymuon) AS DATE)) <=3  AND trangthai = 0";
            Connection con = new Connection();
            if (con.Open_Connect() == true)
            {
                if (con.Excute_Update(str) == true)
                    return true;
                else return false;
            }
            con.Close_Connect();

            return status;

        }
        public static bool Check_CoPhieuMuon (string madg, int masach)
        {
            bool status = false;
            string sql = "SELECT * FROM tbl_phieumuon WHERE madocgia = '"+madg+"' AND masach = "+masach+" AND trangthai = 0";
            Connection con = new Connection();
            if(con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                while (drd.Read())
                    return true;
                return false;
            }
            return status;
        }
        public static bool Check_ConSachTrongKho(int masach)
        {
            bool status = false;
            string sql = "SELECT SUM(a.soluong) AS conlai FROM " +
                           " ( SELECT masach, soluong FROM dbo.tbl_sach " +
                          "  UNION ALL  SELECT masach, count(masach) * -1 FROM dbo.tbl_phieumuon GROUP BY dbo.tbl_phieumuon.masach  ) AS a " +
                          "  WHERE a.masach = "+masach+" GROUP BY a.masach ";
            Connection con = new Connection();
            if (con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                while(drd.Read())
                {
                    if (int.Parse(drd[0].ToString()) > 1)
                        return true;
                    return false;
                }
                
            }
            return status;
        }
        public static bool CapNhat_PhieuMuon ()
        {
            bool status = false;
            string sql = "UPDATE tbl_phieumuon SET trangthai = 2 WHERE CAST(GETDATE() AS DATE) > CAST(DATEADD (Day,7,ngaymuon) AS DATE)";
            Connection con = new Connection();
            if (con.Open_Connect())
            {
                if (con.Excute_Update(sql)) return true;
                else return false;
            }
            return status;
        }
        public static bool chk_CoPhieuMuon()
        {
            bool status = false;
            string sql = "SELECT * FROM tbl_phieumuon";
            Connection con = new Connection();
            if (con.Open_Connect())
            {
                SqlDataReader drd = con.Execute_SQL(sql);
                while (drd.Read())
                {
                        return true;
                }
                return false;

            }
            return status;
        }


             

    }
}
