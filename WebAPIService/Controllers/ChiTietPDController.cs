using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIService.Controllers
{
    public class ChiTietPDController : ApiController
    {
        [HttpGet]
       
        public List<ChiTietPD> ListPhieuDat()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<ChiTietPD> list = context.ChiTietPDs.ToList();
                foreach(ChiTietPD ch in list)
                {
                    ch.MonAn = null;
                    ch.PhieuDatBanAn = null;
                }
                return list;
            }
        }
        [HttpGet]

        public List<ChiTietPD> ListPhieuDatTheoMaPD(int mapd)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<ChiTietPD> list = context.ChiTietPDs
                    .Where(x=>x.MaPD==mapd)
                    .ToList();
                foreach (ChiTietPD ch in list)
                {
                    ch.MonAn = null;
                    ch.PhieuDatBanAn = null;
                }
                return list;
            }
        }

        [HttpGet]

        public List<MonAn> ListMonAnTrongPhieuDatTheoMaPD(int listmonmapd)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<MonAn> ma = new List<MonAn>();
                List<ChiTietPD> list = context.ChiTietPDs
                    .Where(x => x.MaPD == listmonmapd)
                    .ToList();
                list.ForEach(x =>
                {
                    MonAn m = context.MonAns.FirstOrDefault(i => i.MaMA == x.MaMA);
                    ma.Add(m);
                });
                foreach (MonAn m in ma)
                {
                    m.LoaiMonAn = null;
                    m.ChiTietPDs.Clear();
                }
                return ma;

               
            }

        }
        [HttpPost]
        public bool LuuChiTietPhieuDat(int mapd,int mama,int dongia,int soluong)
        {
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    ChiTietPD ct = new ChiTietPD()
                    {
                        MaPD = mapd,
                        MaMA = mama,
                        DonGia = dongia,
                        SoLuong = soluong
                    };
                    context.ChiTietPDs.InsertOnSubmit(ct);
                    context.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        [HttpPut]
        public bool SuaChiTietPhieuDat(int mapdsua, int mama, int dongia, int soluong)
        {
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    ChiTietPD ct = context.ChiTietPDs.FirstOrDefault(x => x.MaPD == mapdsua);



                    ct.MaMA = mama;
                    ct.DonGia = dongia;
                    ct.SoLuong = soluong;
                   
                    
                    context.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        [HttpDelete]

        public bool XoaChiTietPhieuDat(int mapdxoa)
        {
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    List<ChiTietPD> ct = context.ChiTietPDs.Where(x => x.MaPD == mapdxoa).ToList();

                    context.ChiTietPDs.DeleteAllOnSubmit(ct);
                    context.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
