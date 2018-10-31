using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    class HoaDonBUS
    {
        public List<HoaDonDTO> DanhSachHoaDon()
        {
            HoaDonDAO b = new HoaDonDAO();
            return b.dsHoaDon();
        }
    }
}
