using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;


namespace DoAnQLKaraokeBUS
{
    class LoaiNhanVienBUS
    {
        public List<LoaiNhanVienDTO> DanhSachLoaiNhanVien()
        {
            LoaiNhanVienDAO b = new LoaiNhanVienDAO();
            return b.dsloaiNV();
        }
    }
}
