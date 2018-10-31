using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    class ThucDonBUS
    {
        public List<ThucDonDTO> DanhSachTD()
        {
            ThucDonDAO b = new ThucDonDAO();
            return b.dsThucDon();
        }
    }
}
