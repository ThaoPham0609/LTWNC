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
    public class PhongDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<PhongDTO> dsPhong()
        {

            List<PhongDTO> ds = new List<PhongDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from PHONG where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                PhongDTO a = new PhongDTO()
                {
                    MAPHONG = sdr.GetInt32(0),
                    TENPHONG = sdr.GetString(1),
                    LOAIPHONG = sdr.GetInt32(2),
                    TINHTRANG = sdr.GetInt32(3),
                    GIAPHONG = sdr.GetString(4)
                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
