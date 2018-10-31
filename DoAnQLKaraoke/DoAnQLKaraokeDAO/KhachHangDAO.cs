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
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
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
    }
}
