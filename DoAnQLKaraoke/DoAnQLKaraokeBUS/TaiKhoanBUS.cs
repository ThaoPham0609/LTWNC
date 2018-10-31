using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    public class TaiKhoanBUS
    {
        public List<TaiKhoanDTO> DanhSachTaiKhoan()
        {
            TaiKhoanDAO b = new TaiKhoanDAO();
            return b.dsTaiKhoan();
        }
        public TaiKhoanDTO LayThongTinTaiKhoan(string taikhoan,string matkhau)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            TaiKhoanDAO b = new TaiKhoanDAO();
            List<TaiKhoanDTO> dstk =  b.dsTaiKhoan();
            tk = dstk.Find(o => o.TAIKHOAN == taikhoan.Trim() && o.MATKHAU == matkhau.Trim());
            return tk;
        }
    }
}
