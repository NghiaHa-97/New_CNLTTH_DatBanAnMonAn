﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIService.Controllers
{
    public class PhieuDatBanAnController : ApiController
    {
        [HttpGet]
        public List<DSPhieuDatBanAnResult> ListPhieuDatBan()
        {
            using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
            {
                List<DSPhieuDatBanAnResult> list = context.DSPhieuDatBanAn().ToList();
                //List<PhieuDatBanAn> list = context.PhieuDatBanAns.ToList();
                //foreach (PhieuDatBanAn l in list)
                //{
                //    l.BanAn = null;
                //    l.ChiTietPDs.Clear();
                //    l.HoaDonThanhToan = null;
                //    l.KhachHang = null;
                //    l.NhanVien = null;
                //}
                return list;
            }
        }
        [HttpPost]
        public bool ThemPhieuDatBan(int mapd, DateTime ngaylap, int mahd, int manv, int maban, int makh)
        {
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    PhieuDatBanAn pd = new PhieuDatBanAn();
                    pd.MaPD = mapd;
                    pd.NgayLap = ngaylap;
                    pd.MaHD = mahd;
                    pd.MaNV = manv;
                    pd.MaBan = maban;
                    pd.MaKH = makh;
                    context.PhieuDatBanAns.InsertOnSubmit(pd);
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
        public bool SuaPhieuDatBan(int mapdsua, DateTime ngaylap, int mahd, int manv, int maban, int makh)
        {
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    PhieuDatBanAn pd = context.PhieuDatBanAns.FirstOrDefault(x => x.MaPD == mapdsua);
                    
                    pd.NgayLap = ngaylap;
                    pd.MaHD = mahd;
                    pd.MaNV = manv;
                    pd.MaBan = maban;
                    pd.MaKH = makh;
                    
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
        [HttpPut]
        public bool SuaPhieuDatBan(int mapdxoa)
        {
            try
            {
                using (DatBanAnMonAnDataContext context = new DatBanAnMonAnDataContext())
                {
                    PhieuDatBanAn pd = context.PhieuDatBanAns.FirstOrDefault(x => x.MaPD == mapdxoa);

                    context.PhieuDatBanAns.DeleteOnSubmit(pd);
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
