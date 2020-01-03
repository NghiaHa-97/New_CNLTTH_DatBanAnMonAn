using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIService.Controllers
{
    public class KhachHangController : ApiController
    {
        [HttpGet]
        public List<KhachHang> DSKH()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<KhachHang> list = context.KhachHangs.ToList();
                foreach(KhachHang kh in list)
                {
                    kh.PhieuDatBanAns.Clear();
                }
                return list;
            }
        }
    }
}
