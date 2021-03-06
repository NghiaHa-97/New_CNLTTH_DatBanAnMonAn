﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIService.Controllers
{
    public class NhanVienController : ApiController
    {
        [HttpGet]
        public List<NhanVien> ListNV()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<NhanVien> list = context.NhanViens.ToList();
                foreach(NhanVien nv in list)
                {
                    nv.HoaDonThanhToans.Clear();
                    nv.PhieuDatBanAns.Clear();
                }
                return list;
            }
        }
        //[HttpGet]
        //[Route("api/nhanvien/mamax")]
        //public NhanVien NVMaMax()
        //{
        //     using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
        //    {
        //        List<NhanVien> list = context.NhanViens.OrderBy(x=>x.MaNV).ToList();
        //        foreach(NhanVien nv in list)
        //        {
        //            nv.HoaDonThanhToans.Clear();
        //            nv.PhieuDatBanAns.Clear();
        //        }
        //        NhanVien[] nv1 = list.ToArray();

        //        return nv1[0];
        //    }
        //}
    }
}
