using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_DatBanAnMonAn
{
    public partial class ChonSoluongMonAn : Form
    {
        public int DonGia { get; set; }
        public ChonSoluongMonAn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void numericUpDownSoLuong_ValueChanged(object sender, EventArgs e)
        {
            labelGia.Text = DonGia * (int)numericUpDownSoLuong.Value + "";
        }
    }
}
