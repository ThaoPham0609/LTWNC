using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    public class PhongBUS
    {
        public List<PhongDTO> DanhSachPhong()
        {
            PhongDAO b = new PhongDAO();
            return b.dsPhong();
        }
    }
}
