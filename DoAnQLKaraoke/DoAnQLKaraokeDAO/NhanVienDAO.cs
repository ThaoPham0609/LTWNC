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
   public class NhanVienDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<NhanVienDTO> dsNhanVien()
        {

            List<NhanVienDTO> ds = new List<NhanVienDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from NHANVIEN where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                NhanVienDTO a = new NhanVienDTO()
                {

                   
                    TINHTRANG = sdr.GetInt32(3),
                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
