using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    class LoaiKhachHangBUS
    {
        public List<LoaiKhachHangDTO> DanhSachLoaiKH()
        {
            LoaiKhachHangDAO b = new LoaiKhachHangDAO();
            return b.dsloaiKH();
        }
    }
}
