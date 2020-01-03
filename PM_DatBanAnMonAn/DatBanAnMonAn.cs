using DatBanAn_MonAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using PM_DatBanAnMonAn.Public;
namespace PM_DatBanAnMonAn
{
    public partial class DatBanAnMonAn : Form
    {
        public DatBanAnMonAn()
        {
            InitializeComponent();
            LoadBanAn();
            LoadMonAn();
            LoadNhanVien();
            LoadMaKH();
            LoadMaPhieuDat();
        }

        public List<BanAn> ListBanAn()
        {
            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(List<BanAn>));
            string url = "http://192.168.163.101/CNLTTICHHOP/api/banan";
            List<BanAn> list = Service.Get(url, data) as List<BanAn>;
            return list;
        }
        public void LoadMonAn()
        {

            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(List<MonAnTenLoai>));
            string url = "http://192.168.163.101/CNLTTICHHOP/api/monan/danhsach";
            List<MonAnTenLoai> list = Service.Get(url, data) as List<MonAnTenLoai>;
            listViewMonAn.Items.Clear();
            list.ForEach(x =>
            {
                ListViewItem lt = new ListViewItem(x.MaMA.ToString());
                lt.SubItems.Add(x.TenMonAn);
                lt.SubItems.Add(x.DonGia.ToString());
                lt.SubItems.Add(x.TenLoai);
                listViewMonAn.Items.Add(lt);

            });
        }
        public void LoadBanAn()
        {
            List<BanAn> list = ListBanAn();
            list.ForEach(x =>
            {
                ListViewItem lt = new ListViewItem(x.MaBan.ToString());
                lt.SubItems.Add(x.TenBan);
                lt.SubItems.Add(x.SoChoNgoi.ToString());
                lt.SubItems.Add(x.TrangThai.ToString());
                listViewBanAn.Items.Add(lt);

            });
        }
        public void ChonMonAn()
        {
            if (listViewMonAn.SelectedItems.Count <= 0)
            {
                return;
            }
            ListViewItem lt = listViewMonAn.SelectedItems[0];
            string MaMA = lt.Text;

            string TenMonAn = lt.SubItems[1].Text;
            int DonGia = int.Parse(lt.SubItems[2].Text);
            ChonSoluongMonAn Formchon = new ChonSoluongMonAn();
            Formchon.labelGia.Text = DonGia * (int)Formchon.numericUpDownSoLuong.Value + "";
            Formchon.DonGia = DonGia;
            foreach(string x in checkedListBoxDS.Items)
            {
                if(int.Parse(x.Split('-')[0])==int.Parse(MaMA))
                {
                    MessageBox.Show("Bạn đã chọn món ăn này");
                    return;
                }
                
            }

                if (Formchon.ShowDialog() == DialogResult.OK)
            {
                string DS = MaMA + " - " + TenMonAn + " - " + (int)Formchon.numericUpDownSoLuong.Value + " - " + Formchon.labelGia.Text;
                checkedListBoxDS.Items.Add(DS);
            }
        }
        public void LoadNhanVien()
        {

            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(List<NhanVien>),
                new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat("yyyy-MM-ddTHH:mm:ss") }); 
            string url = "http://192.168.163.101/CNLTTICHHOP/api/nhanvien";
            List<NhanVien> list = Service.Get(url, data) as List<NhanVien>;
            list.ForEach(x=>
            {
                comboBoxNV.Items.Add(x.MaNV + " - " + x.HoTen);
            }
            );
        }
        public void LoadMaPhieuDat()
        {
            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(int));
            string url = "http://192.168.163.101/CNLTTICHHOP/api/phieudatbanan/mamax";
            int gt =(int) Service.Get(url, data);
            labelMaPhieuDat.Text = gt + 1 + "";
        }

        public void LoadMaKH()
        {
            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(int));
            string url = "http://192.168.163.101/CNLTTICHHOP/api/khachhang/mamax";
            int gt = (int)Service.Get(url, data);
            labelMaKH.Text = gt + 1 + "";
        }
        /// <summary>
        /// Đặt bàn ăn
        /// </summary>
        /// <returns></returns>
        public bool TaoKhachHang()
        {
            string pra = string.Format("?makh={0}&ten={1}&sdt={2}", labelMaKH.Text, textBoxKH.Text, textBoxSDT.Text);

            string url = "http://192.168.163.101/CNLTTICHHOP/api/Khachhang";
            string methot = "Post";
            bool kq = Service.Post_Put_Delete(methot, url, pra);
            return kq;
        }

        public bool TaoPhieuDatBanAn()
        {
            string ngaylap = dateTimePickerNgayDat.Text;
            string manv = comboBoxNV.Text.Split('-')[0];
            string maban = labelBanAnDat.Text.Split(':')[1].Split('-')[0];
            string pra = string.Format("?mapd={0}&ngaylap={1}&tongtien={2}&manv={3}&maban={4}&makh={5}",
                         labelMaPhieuDat.Text,ngaylap, labelTongTien.Text,manv,maban,labelMaKH.Text);

            string url = "http://192.168.163.101/CNLTTICHHOP/api/phieudatbanan";
            string methot = "Post";
            bool kq = Service.Post_Put_Delete(methot, url, pra);
            return kq;
        }

        public bool TaoChiTietPhieuDat()
        {
            
            string mapd = labelMaPhieuDat.Text;
            foreach (string ds in checkedListBoxDS.CheckedItems)
            {
                string mama = ds.Split('-')[0];
                string dongia = ds.Split('-')[3];
                string soluong = ds.Split('-')[2];

                string pra = string.Format("?mapd={0}&mama={1}&dongia={2}&soluong={3}",
                        mapd, mama,dongia,soluong );

                string url = "http://192.168.163.101/CNLTTICHHOP/api/chitietpd";
                string methot = "Post";
                bool kq = Service.Post_Put_Delete(methot, url, pra);
                if(kq==false)
                {
                    return false;
                }
            }
            return true;
        }











        private void listViewBanAn_DoubleClick(object sender, EventArgs e)
        {
            if (listViewBanAn.SelectedItems.Count <= 0)
            {
                return;
            }


            ListViewItem lt = listViewBanAn.SelectedItems[0];
            string MaBan = lt.Text;
            string TenBan = lt.SubItems[1].Text;
            MessageBox.Show("Bạn đã chọn bàn: " + MaBan + "--" + TenBan);
            labelBanAn.Text = "Mã :" + MaBan + "--" + TenBan;
            labelBanAnDat.Text= "Mã :" + MaBan + "--" + TenBan;

        }

        private void buttonTaiLaiBan_Click(object sender, EventArgs e)
        {
            listViewBanAn.Items.Clear();
            LoadBanAn();
        }

        private void buttonTimBan_Click(object sender, EventArgs e)
        {
            TimKiemBanAn FormTK = new TimKiemBanAn();
            FormTK.comboBoxTrangThaiBA.Items.Add("0-Bàn trống");
            FormTK.comboBoxTrangThaiBA.Items.Add("1-Bàn đã được đặt");
            //FormTK.Show();

            if (FormTK.ShowDialog() == DialogResult.OK)
            {
                int o;
                if (int.TryParse(FormTK.textBoxMaTimBA.Text, out o))
                {
                    DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(BanAn));
                    string url = "http://192.168.163.101/CNLTTICHHOP/api/banan?maban=" + FormTK.textBoxMaTimBA.Text;
                    BanAn ba = Service.Get(url, data) as BanAn;
                    if (ba == null) return;
                    listViewBanAn.Items.Clear();
                    ListViewItem lt = new ListViewItem(ba.MaBan.ToString());
                    lt.SubItems.Add(ba.TenBan);

                    lt.SubItems.Add(ba.SoChoNgoi.ToString());
                    lt.SubItems.Add(ba.TrangThai.ToString());
                    listViewBanAn.Items.Add(lt);
                    return;
                }
                if (FormTK.comboBoxTrangThaiBA.Text != "" && (int)FormTK.numericUpDownSoCho.Value == 0)
                {
                    string trangthai = FormTK.comboBoxTrangThaiBA.Text.Split('-')[0];
                    DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(List<BanAn>));
                    string url = "http://192.168.163.101/CNLTTICHHOP/api/banan?trangthai=" + trangthai;
                    List<BanAn> list = Service.Get(url, data) as List<BanAn>;
                    listViewBanAn.Items.Clear();
                    list.ForEach(x =>
                    {
                        ListViewItem lt = new ListViewItem(x.MaBan.ToString());
                        lt.SubItems.Add(x.TenBan);
                        lt.SubItems.Add(x.SoChoNgoi.ToString());
                        lt.SubItems.Add(x.TrangThai.ToString());
                        listViewBanAn.Items.Add(lt);

                    });

                }
                if (FormTK.comboBoxTrangThaiBA.Text != "" && (int)FormTK.numericUpDownSoCho.Value != 0)
                {
                    string trangthai = FormTK.comboBoxTrangThaiBA.Text.Split('-')[0];
                    int socho = (int)FormTK.numericUpDownSoCho.Value;
                    DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(List<BanAn>));
                    string url = "http://192.168.163.101/CNLTTICHHOP/api/banan?trangthai=" + trangthai + "&socho=" + socho;
                    List<BanAn> list = Service.Get(url, data) as List<BanAn>;
                    listViewBanAn.Items.Clear();
                    list.ForEach(x =>
                    {
                        ListViewItem lt = new ListViewItem(x.MaBan.ToString());
                        lt.SubItems.Add(x.TenBan);
                        lt.SubItems.Add(x.SoChoNgoi.ToString());
                        lt.SubItems.Add(x.TrangThai.ToString());
                        listViewBanAn.Items.Add(lt);

                    });
                    return;
                }
                if (FormTK.comboBoxTrangThaiBA.Text == "" && (int)FormTK.numericUpDownSoCho.Value != 0)
                {
                    int socho = (int)FormTK.numericUpDownSoCho.Value;
                    DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(List<BanAn>));
                    string url = "http://192.168.163.101/CNLTTICHHOP/api/banan?socho=" + socho;
                    List<BanAn> list = Service.Get(url, data) as List<BanAn>;
                    listViewBanAn.Items.Clear();
                    list.ForEach(x =>
                    {
                        ListViewItem lt = new ListViewItem(x.MaBan.ToString());
                        lt.SubItems.Add(x.TenBan);
                        lt.SubItems.Add(x.SoChoNgoi.ToString());
                        lt.SubItems.Add(x.TrangThai.ToString());
                        listViewBanAn.Items.Add(lt);

                    });

                }


            }
        }

        private void listViewMonAn_DoubleClick(object sender, EventArgs e)
        {

            ChonMonAn();

        }

        private void buttonTaiLaiMonAn_Click(object sender, EventArgs e)
        {
            LoadMonAn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChonMonAn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int items = checkedListBoxDS.Items.Count;
            for(int i=0;i<items;i++)
            {
                checkedListBoxDS.SetItemChecked(i,true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int items = checkedListBoxDS.Items.Count;
            for (int i = 0; i < items; i++)
            {
                checkedListBoxDS.SetItemChecked(i, false);
            }
        }

        private void buttonXoaListBox_Click(object sender, EventArgs e)
        {
            int items = checkedListBoxDS.Items.Count;
            for (int i = 0; i < items; i++)
            {
                if(checkedListBoxDS.GetItemChecked(i)==true)
                {
                    checkedListBoxDS.Items.RemoveAt(i);
                    items = checkedListBoxDS.Items.Count;
                    i--;
                }
            }
        }
        public int TongTien=0;

        private void buttonTT_Click(object sender, EventArgs e)
        {
            TongTien = 0;
            foreach(string x in checkedListBoxDS.CheckedItems)
            {
                TongTien += int.Parse(x.Split('-')[3]);

            }
            labelTongTien.Text = TongTien + "";
        }

        //button dat mon an ban an
        private void button6_Click(object sender, EventArgs e)
        {
            buttonTT.PerformClick();
            bool kq=TaoKhachHang();
            if (kq == false)
            {
                MessageBox.Show("Đặt Hàng thất bại");
                return;
            }
            kq=TaoPhieuDatBanAn();
            if (kq == false)
            {
                MessageBox.Show("Đặt Hàng thất bại");
                return;
            }
            kq = TaoChiTietPhieuDat();
            if(kq==true)
            {
                MessageBox.Show("Đặt Hàng Thành Công");
            }

        }
    }
}
