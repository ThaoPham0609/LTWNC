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
   public class LoaiNhanVienDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdl;Integrated Sucurity = True;";
        public List<LoaiNhanVienDTO> dsloaiNV()
        {

            List<LoaiNhanVienDTO> ds = new List<LoaiNhanVienDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from LOAINV where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                LoaiNhanVienDTO a = new LoaiNhanVienDTO()
                {
                    MALOAI = sdr.GetInt32(0),
                    TENLOAI = sdr.GetString(1),
                    TINHTRANG = sdr.GetString(2)

                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
