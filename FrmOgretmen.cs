using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementProject
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void btnKulupIslemleri_Click(object sender, EventArgs e)
        {
            FrmKulupIslemleri fr = new FrmKulupIslemleri();
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            FrmDersIslemleri fr = new FrmDersIslemleri();
            fr.Show();
        }

        private void btnSinavNotlari_Click(object sender, EventArgs e)
        {
            FrmSinavNotlari frm = new FrmSinavNotlari();
            frm.Show();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenciIslemleri frm = new FrmOgrenciIslemleri();
            frm.Show();
        }
    }
}
