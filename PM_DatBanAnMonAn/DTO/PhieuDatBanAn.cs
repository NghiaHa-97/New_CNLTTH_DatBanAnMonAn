using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatBanAn_MonAn.DTO
{
    public class PhieuDatBanAn
    {
        public int MaPD { get; set; }
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public string TenKH { get; set; }
        public string TenBan { get; set; }
        public DateTime NgayLap { get; set; }
        public int TongTien { get; set; }
    }
}
