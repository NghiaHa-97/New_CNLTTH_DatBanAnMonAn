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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadBanAn();
            LoadMonAn();
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
            if (Formchon.ShowDialog() == DialogResult.OK)
            {
                string DS = MaMA + " - " + TenMonAn + " - " + (int)Formchon.numericUpDownSoLuong.Value + " - " + Formchon.labelGia.Text;
                checkedListBoxDS.Items.Add(DS);
            }
        }
        public void LoadNhanVien()
        {

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
            labelBanAn.Text = "Ma:" + MaBan + "--" + TenBan;

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
    }
}
