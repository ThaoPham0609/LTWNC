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
    public class LoaiKhachHangDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdl;Integrated Sucurity = True;";
        public List<LoaiKhachHangDTO> dsloaiKH()
        {

            List<LoaiKhachHangDTO> ds = new List<LoaiKhachHangDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from LOAIKH where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                LoaiKhachHangDTO a = new LoaiKhachHangDTO()
                {
                    MALOAI = sdr.GetInt32(0),
                    TENLOAIKH = sdr.GetString(1),
                    TINHTRANG = sdr.GetInt32(2)

                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
