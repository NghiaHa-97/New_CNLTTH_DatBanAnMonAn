using DatBanAn_MonAn.DTO;
using PM_DatBanAnMonAn.Public;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_DatBanAnMonAn
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            LoadPhieuDatBanAnChuaThanhToan();
            LoadHoaDonThanhToan();
        }

        public List<PhieuDatBanAn> DSPhieuDatChuaThanhToan()
        {
            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(List<PhieuDatBanAn>),
                new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat("yyyy-MM-ddTHH:mm:ss") });
            string url = "http://192.168.163.101/CNLTTICHHOP/api/phieudatbanan/danhsachphieudatchuadcthanhtoan";
            List<PhieuDatBanAn> list = Service.Get(url, data) as List<PhieuDatBanAn>;
            return list;
        }

        public List<HoaDonThanhToan> DSHoaDon()
        {
            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(List<HoaDonThanhToan>),
                new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat("yyyy-MM-ddTHH:mm:ss") });
            string url = "http://192.168.163.101/CNLTTICHHOP/api/HoaDonThanhToan";
            List<HoaDonThanhToan> list = Service.Get(url, data) as List<HoaDonThanhToan>;
            return list;
        }

        public void LoadPhieuDatBanAnChuaThanhToan()
        {
            List<PhieuDatBanAn> list = DSPhieuDatChuaThanhToan();
            listViewPhieuDat.Items.Clear();
            list.ForEach(x =>
            {
                ListViewItem lt = new ListViewItem(x.MaPD + "");
                lt.SubItems.Add(x.MaNV + "");
                lt.SubItems.Add(x.HoTen + "");
                lt.SubItems.Add(x.TenKH + "");
                lt.SubItems.Add(x.TenBan + "");
                lt.SubItems.Add(x.NgayLap + "");
                lt.SubItems.Add(x.TongTien + "");
                listViewPhieuDat.Items.Add(lt);

            });
        }


        public void LoadHoaDonThanhToan()
        {
            List<HoaDonThanhToan> list = DSHoaDon();
            listViewHD.Items.Clear();
            list.ForEach(x =>
            {
                ListViewItem lt = new ListViewItem(x.MaHD + "");
                lt.SubItems.Add(x.MaPD + "");
                lt.SubItems.Add(x.MaNV + "");
                lt.SubItems.Add(x.HoTen + "");
                lt.SubItems.Add(x.TenKH + "");
                lt.SubItems.Add(x.TenBan + "");
                lt.SubItems.Add(x.NgayLap + "");
                lt.SubItems.Add(x.TongTien + "");
                listViewHD.Items.Add(lt);

            });
        }
        public int LayMaHoaDonMax()
        {
            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(int));
                
            string url = "http://192.168.163.101/CNLTTICHHOP/api/hoadonthanhtoan/mahdmax";
            int list =(int) Service.Get(url, data);
            return list;
        }

        public void TaoHoaDon()
        {
            if (listViewPhieuDat.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Bạn Chưa Chọn Phiếu đặt nào");
                return;
            }

            ListViewItem lt = listViewPhieuDat.SelectedItems[0];
            string mapd= lt.SubItems[0].Text;
            string manv = lt.SubItems[1].Text;
            string ngaynhap = lt.SubItems[5].Text;

            string pra = string.Format("?mahd={0}&ngaynhap={1}&manv={2}&mapd={3}", LayMaHoaDonMax()+1, ngaynhap, manv,mapd);

            string url = "http://192.168.163.101/CNLTTICHHOP/api/HoaDonThanhToan";
            string methot = "Post";
            bool kq = Service.Post_Put_Delete(methot, url, pra);
            if(kq==true)
            {
                MessageBox.Show("Tạo Hóa Đơn Thành Công");
            }
            else
            {
                MessageBox.Show("Tạo Hóa Đơn Thất Bại");
            }


        }

        public bool XoaChiTietPhieuDat(string mapdxoa)
        {
            
            string pra = string.Format("?mapdxoa={0}", mapdxoa);

            string url = "http://192.168.163.101/CNLTTICHHOP/api/chitietpd";
            string methot = "Delete";
            bool kq = Service.Post_Put_Delete(methot, url, pra);
            return kq;
        }

        public bool XoaPhieuDatBanAn(string mapdxoa)
        {
            
            string pra = string.Format("?mapdxoa={0}", mapdxoa);

            string url = "http://192.168.163.101/CNLTTICHHOP/api/phieudatbanan";
            string methot = "Delete";
            bool kq = Service.Post_Put_Delete(methot, url, pra);
            return kq;
        }


        public void XoaPDBanAnChuaThanhToan(string mapdxoa)
        {
            bool kq = XoaChiTietPhieuDat(mapdxoa);
            if (kq == false)
            {
                MessageBox.Show("Xóa Thất Bại");
                return;
            }
            kq = XoaPhieuDatBanAn(mapdxoa);
            if(kq==false)
            {
                MessageBox.Show("Xóa Thất Bại");
            }
            else
            {
                MessageBox.Show("Xóa Thành Công");
                LoadPhieuDatBanAnChuaThanhToan();
            }
        }




        private void buttonThanhToan_Click(object sender, EventArgs e)
        {

            
            TaoHoaDon();
            LoadPhieuDatBanAnChuaThanhToan();
            LoadHoaDonThanhToan();



        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (listViewPhieuDat.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Bạn Chưa Chọn Phiếu đặt nào");
                return;
            }

            ListViewItem lt = listViewPhieuDat.SelectedItems[0];
            string mapd = lt.SubItems[0].Text;
            XoaPDBanAnChuaThanhToan(mapd);
            
        }
    }
}
