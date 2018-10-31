using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeDAO
{
    public class ThucDonDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<ThucDonDTO> dsThucDon()
        {

            List<ThucDonDTO> ds = new List<ThucDonDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from THUCDON where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                ThucDonDTO a = new ThucDonDTO()
                {
                    MATD = sdr.GetInt32(0),
                    LOAITD = sdr.GetInt32(1),
                    TENTHUCDON = sdr.GetString(2),
                    GIA = sdr.GetString(3),
                    TINHTRANG = sdr.GetInt32(4)

                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
