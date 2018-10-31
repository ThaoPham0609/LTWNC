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
   public class LoaiPhongDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdl;Integrated Sucurity = True;";
        public List<LoaiPhongDTO> dsloaiPhong()
        {

            List<LoaiPhongDTO> ds = new List<LoaiPhongDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from LOAIPHONG where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                LoaiPhongDTO a = new LoaiPhongDTO()
                {
                    MALOAIPHONG = sdr.GetInt32(0),
                    TENLOAIPHONG = sdr.GetString(1),
                    TINHTRANG = sdr.GetInt32(2)

                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
