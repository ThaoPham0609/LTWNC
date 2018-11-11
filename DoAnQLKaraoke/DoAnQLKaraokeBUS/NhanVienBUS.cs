using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    class NhanVienBUS
    {
        public List<NhanVienDTO> DanhSachNhanVien()
        {
            NhanVienDAO b = new NhanVienDAO();
            return b.dsNhanVien();
        }
    }
}
