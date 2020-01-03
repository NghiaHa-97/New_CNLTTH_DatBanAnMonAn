using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIService.Controllers
{
    public class LoaiMonAnController : ApiController
    {
        [HttpGet]
        public List<LoaiMonAn> DSLoaiMonAn()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<LoaiMonAn> list = context.LoaiMonAns.ToList();
                foreach(LoaiMonAn l in list)
                {
                    l.MonAns.Clear();
                }
                return list;
            }
        }
    }
}
