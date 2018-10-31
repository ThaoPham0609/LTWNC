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
    public class HoaDonDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<HoaDonDTO> dsHoaDon()
        {

            List<HoaDonDTO> ds = new List<HoaDonDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from HOADON where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                HoaDonDTO a = new HoaDonDTO()
                {
                    MAHD = sdr.GetInt32(0),
                    MAPHONG = sdr.GetInt32(1),
                    MANV = sdr.GetString(2),
                    NGUOILAPHD = sdr.GetString(3),
                    MAKH = sdr.GetInt32(4),
                    HOTENKH = sdr.GetString(5),

                    THOIGIANBATDAU = sdr.GetDateTime(6),

                    THOIGIANKETTHUC = sdr.GetDateTime(7),

                    TONGTHANHTOAN = sdr.GetInt32(8),

                    TINHTRANG = sdr.GetInt32(9)

                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
