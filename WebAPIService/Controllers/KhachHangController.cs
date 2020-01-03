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
                foreach (KhachHang kh in list)
                {
                    kh.PhieuDatBanAns.Clear();
                }
                return list;
            }
        }

        /// <summary>
        /// Lấy mã Khách hàng max
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/khachhang/mamax")]
        public int NVMaMax()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<KhachHang> list = context.KhachHangs.OrderByDescending(x => x.MaKH).ToList();
                foreach (KhachHang kh in list)
                {
                    kh.PhieuDatBanAns.Clear();
                }
                KhachHang[] kh1 = list.ToArray();


                return kh1[0].MaKH;
            }
        }
        /// <summary>
        /// Luu Thong tin khasch hang
        /// </summary>
        [HttpPost]
        // cai ma nay o lay o dau, cái này là paramater mà, ý t là chuyền vào lấy gt ở đâu khi gọi method này
        public bool LuuKhachHang(int makh,string ten,string sdt)
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                try
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = makh;
                    kh.TenKH = ten;
                    kh.SDT = sdt;

                    context.KhachHangs.InsertOnSubmit(kh);
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
