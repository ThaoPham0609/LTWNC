using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDTO;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQLKaraokeDAO
{
    public class KhachHangDAO
    {
        //string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<KhachHangDTO> dsKhachHang()
        {

            List<KhachHangDTO> ds = new List<KhachHangDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from KHACHHANG where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                KhachHangDTO a = new KhachHangDTO()
                {
                    MAKH = sdr.GetInt32(0),
                    LOAIKH = sdr.GetInt32(1),
                    HOKH = sdr.GetString(2),
                    TENKH = sdr.GetString(3),
                    NAMSINH = sdr.GetDateTime(4),
                    SDT = sdr.GetString(5),
                    TINHTRANG = sdr.GetInt32(6)

                };
                ds.Add(a);
            }
            return ds;
        }
        public bool ThemKH(KhachHangDTO khachhang)
        {
            string insert = "INSERT INTO KHACHANG"
                                      + " (MAKH"
                                       + ", HOKH"
                                       +",TENKH"
                                       + "  , LOAIKH"
                                        + " , NAMSINH"
                                        +",SDT"
                                        + " , TINHTRANG)"
                                  + " VALUES"
                                     + "(@MAKH,"
                                     +"@HOKH,"
                                     + "@TENKH,"
                                     + "@LOAIKH,"
                                     + "@NAMSINH,"
                                     +"@SDT,"
                                      + "@TINHTRANG)";
            //SqlParameter[] arrParams = new SqlParameter[7];
            
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAKH", khachhang.MAKH));
            lsparams.Add(new SqlParameter("@HOKH", khachhang.HOKH));
            lsparams.Add(new SqlParameter("@TENKH", khachhang.TENKH));
            lsparams.Add(new SqlParameter("@LOAIKH", khachhang.LOAIKH));
            lsparams.Add(new SqlParameter("@NAMSINH", khachhang.NAMSINH));
            lsparams.Add(new SqlParameter("@SDT", khachhang.SDT));
            lsparams.Add(new SqlParameter("@TINHTRANG", khachhang.TINHTRANG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;

            
        }
        public List<KhachHangDTO> TraCuu(int x, int y)
        {
            string search = "SELECT * FROM KHACHANG"
                               + " WHERE MAKH LIKE '%" + x + "%' and TINHTRANG  LIKE '%" + y + "%' ";


            SqlConnection con = DataProvider.TaoKetNoi();
            List<KhachHangDTO> ds = new List<KhachHangDTO>();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(search, con);
            while (sdr.Read())
            {
                KhachHangDTO a = new KhachHangDTO();
                a.MAKH = sdr.GetString(0);
                a.HOKH = sdr.GetString(1);
                a.TENKH = sdr.GetString(2);
                a.LOAIKH = sdr.GetInt32(3);
                a.NAMSINH = sdr.GetDateTime(4);
                a.SDT = sdr.GetString(5);
                a.TINHTRANG = sdr.GetInt32(6);
                ds.Add(a);
            }
            sdr.Close();
            con.Close();
            return ds;
        }
        public bool CapNhatKH(KhachHangDTO khachhang)
        {
            string update = "UPDATE KHACHANG "
                              + "SET HO = @HO,"
                              +"TENKH=@TENKH,"
                              + " LOAIKH = @LOAIKH"
                              + "NAMSINH = @NAMSINH"
                              +"SDT=@SDT"
                              + " , TINHTRANG = @TINHTRANG"
                              + " WHERE MAKH = @MAKH";
            //SqlParameter[] arrParams = new SqlParameter[7];

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAKH", khachhang.MAKH));
            lsparams.Add(new SqlParameter("@HOKH", khachhang.HOKH));
            lsparams.Add(new SqlParameter("@TENKH", khachhang.TENKH));
            lsparams.Add(new SqlParameter("@LOAIKH", khachhang.LOAIKH));
            lsparams.Add(new SqlParameter("@NAMSINH", khachhang.NAMSINH));
            lsparams.Add(new SqlParameter("@SDT", khachhang.SDT));
            lsparams.Add(new SqlParameter("@TINHTRANG", khachhang.TINHTRANG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }
    }
}
