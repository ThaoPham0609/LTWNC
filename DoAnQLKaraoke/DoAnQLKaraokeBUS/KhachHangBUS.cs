using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    class KhachHangBUS
    {
        public List<KhachHangDTO> DanhSachKhachHang()
        {
            KhachHangDAO b = new KhachHangDAO();
            return b.dsKhachHang(); 
        }
    }
}
