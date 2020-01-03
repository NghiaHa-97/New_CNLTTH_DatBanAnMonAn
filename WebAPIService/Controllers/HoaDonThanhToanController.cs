using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIService.Controllers
{
    public class HoaDonThanhToanController : ApiController
    {
       [HttpGet]
       public List<DanhSachHoaDonResult> DSHoaDon()
        {
            using (DatBanAnMonAnDataContext context=new DatBanAnMonAnDataContext())
            {
                List<DanhSachHoaDonResult> list = context.DanhSachHoaDon().ToList();
                return list;
            }
        }
        [HttpGet]
        [Route("api/hoadonthanhtoan/mahdmax")]
        public int LaymaHDMax()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<HoaDonThanhToan> list = context.HoaDonThanhToans.OrderByDescending(x => x.MaHD).ToList();
                HoaDonThanhToan[] hd = list.ToArray();
                return hd[0].MaHD;
            }
            
        }

        [HttpPost]
        public bool TaoHoaDon(int mahd,DateTime ngaynhap,int manv,int mapd)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {

                try
                {
                    HoaDonThanhToan hd = new HoaDonThanhToan()
                    {
                        MaHD = mahd,
                        NgayNhap = ngaynhap,
                        MaNV = manv,
                        MaPD = mapd
                    };
                    context.HoaDonThanhToans.InsertOnSubmit(hd);
                    context.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }
    }
}
