using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    class TaiKhoanBUS
    {
        public List<TaiKhoanDTO> DanhSachTaiKhoan()
        {
            TaiKhoanDAO b = new TaiKhoanDAO();
            return b.dsTaiKhoan();
        }
    }
}
