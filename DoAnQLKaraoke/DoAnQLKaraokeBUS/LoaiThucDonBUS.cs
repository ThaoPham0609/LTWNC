using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    class LoaiThucDonBUS
    {
        public List<LoaiThucDonDTO> DanhSachLoaiTD()
        {
            LoaiThucDonDAO b = new LoaiThucDonDAO();
            return b.dsLoaiTD();
        }
    }
}
