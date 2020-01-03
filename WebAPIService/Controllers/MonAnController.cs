using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Drawing;

namespace WebAPIService.Controllers
{
    public class MonAnController : ApiController
    {
        

        [HttpGet]
        public List<MonAn> LayToanBoMonAn()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<MonAn> list = context.MonAns.ToList();
                foreach (MonAn m in list)
                {
                    //m.LoaiMonAn = null;
                    m.ChiTietPDs.Clear();
                }
                return list;
            }
               

        }

        [HttpGet]
        [Route("api/monan/danhsach")]
        public List<DSBanAnCoLoaiMonAnResult> LayToanBoMonAn1()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<DSBanAnCoLoaiMonAnResult> list = context.DSBanAnCoLoaiMonAn().ToList();
                return list;
            }
        }
        [HttpGet]
        public List<MonAn> LayDanhSachMonAnTrongDonGia(int dongia1,int dongia2)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<MonAn> list = context.MonAns
                                    .Where(x => x.DonGia >= dongia1 && x.DonGia <= dongia2)
                                    .ToList();
                foreach (MonAn m in list)
                {
                    m.LoaiMonAn = null;
                    m.ChiTietPDs.Clear();
                }
                return list;
            }
           
        }

        [HttpGet]
        public List<MonAn> LayDanhSachMonAnTheoLoai(int maloai)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<MonAn> list = context.MonAns
                                      .Where(x => x.MaLoai == maloai)
                                      .ToList();
                foreach (MonAn m in list)
                {
                    m.LoaiMonAn = null;
                    m.ChiTietPDs.Clear();
                }
                return list;
            }
           
        }


        [HttpGet]
        public MonAn LayMonAnTheoMa(int id)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                MonAn list = context.MonAns
                                    .FirstOrDefault(x => x.MaMA == id);

                if (list != null)
                {
                    list.LoaiMonAn = null;
                    list.ChiTietPDs.Clear();
                }
                return list;
            }
            
        }

        [HttpGet]
        public List<MonAn> LayMonAnTheoTen(string tenmonan)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<MonAn> list = context.MonAns
                                   .Where(x => x.TenMonAn.Contains(tenmonan))
                                   .ToList();

                foreach (MonAn m in list)
                {
                    m.LoaiMonAn = null;
                    m.ChiTietPDs.Clear();
                }
                return list;
            }
           
        }

        [HttpPost]
        
        public bool LuuMonAn(int mama,string tenmonan,int dongia,int maloai)
        {
           
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    MonAn ma = new MonAn
                    {
                        MaMA = mama,
                        TenMonAn = tenmonan,
                        DonGia = dongia,
                        MaLoai = maloai,

                    };
                    context.MonAns.InsertOnSubmit(ma);
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
        public bool SuaMonAn(int mamasua, string tenmonan, int dongia, int maloai)
        {
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    MonAn ma = context.MonAns.FirstOrDefault(x => x.MaMA == mamasua);
                    ma.TenMonAn = tenmonan;
                    ma.DonGia = dongia;
                    ma.MaLoai = maloai;
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
        public bool XoaMonAn(int mamaxoa)
        {
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    MonAn ma = context.MonAns.FirstOrDefault(x => x.MaMA == mamaxoa);
                    context.MonAns.DeleteOnSubmit(ma);
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
