using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIService.Controllers
{
    public class BanAnController : ApiController
    {
        [HttpGet]
        public List<BanAn> LayDSBanAn()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<BanAn> list = context.BanAns.ToList();
                foreach (BanAn b in list)
                {
                    b.PhieuDatBanAns.Clear();
                }
                return list;
            }
        }
        [HttpGet]
        public BanAn LayDSBanAn(int maban)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                BanAn ba = context.BanAns.FirstOrDefault(x => x.MaBan == maban);
                if(ba!=null)
                {
                    ba.PhieuDatBanAns.Clear();
                }
                return ba;
            }

        }
        [HttpGet]
        public List<BanAn> LayDSBanAn1(int trangthai)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<BanAn> ba = context.BanAns.Where(x => x.TrangThai == trangthai).ToList();
                foreach(BanAn b in ba)
                {
                    b.PhieuDatBanAns.Clear();
                }
                return ba;
            }

        }
        [HttpGet]
        public List<BanAn> LayDSBanAn2(int socho)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<BanAn> ba = context.BanAns.Where(x => x.SoChoNgoi == socho).ToList();
                foreach (BanAn b in ba)
                {
                    b.PhieuDatBanAns.Clear();
                }
                return ba;
            }

        }
        [HttpGet]
        public List<BanAn> LayDSBanAn2(int trangthai,int socho)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<BanAn> ba = context.BanAns.Where(x => (x.SoChoNgoi == socho && x.TrangThai==trangthai)).ToList();
                foreach (BanAn b in ba)
                {
                    b.PhieuDatBanAns.Clear();
                }
                return ba;
            }

        }
    }
}
