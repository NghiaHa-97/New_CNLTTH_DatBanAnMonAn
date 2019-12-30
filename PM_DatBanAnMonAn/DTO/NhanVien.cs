using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatBanAn_MonAn.DTO
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int Luong { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}
