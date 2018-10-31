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
    public class TaiKhoanDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<TaiKhoanDTO> dsTaiKhoan()
        {

            List<TaiKhoanDTO> ds = new List<TaiKhoanDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from NGUOIDUNG where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                TaiKhoanDTO a = new TaiKhoanDTO()
                {

                    TAIKHOAN = sdr.GetString(0),
                    MATKHAU = sdr.GetString(1),
                    MANV = sdr.GetString(2),
                    LOAIND = sdr.GetInt32(2),
                    TINHTRANG = sdr.GetInt32(3),
                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
