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
    public class LoaiThucDonDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<LoaiThucDonDTO> dsLoaiTD()
        {

            List<LoaiThucDonDTO> ds = new List<LoaiThucDonDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from LOAITD where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                LoaiThucDonDTO a = new LoaiThucDonDTO()
                {
                    MALOAITD = sdr.GetInt32(0),
                    TEN = sdr.GetString(1),
                    TINHTRANG = sdr.GetInt32(2),

                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
