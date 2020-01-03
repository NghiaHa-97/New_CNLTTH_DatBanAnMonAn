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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonDatBanAn_Click(object sender, EventArgs e)
        {
            DatBanAnMonAn db = new DatBanAnMonAn();
            this.Hide();
            db.ShowDialog();
            this.Show();
            
        }

        private void buttonHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon fr = new FormHoaDon();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buttonDatBanAn.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            buttonHoaDon.PerformClick();
        }
    }
}
