using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementProject
{
    public partial class FrmOgrenciGiris : Form
    {
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }

        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(tbOgrenciNumara.Text) || string.IsNullOrWhiteSpace(tbOgrenciNumara.Text)) 
            {
                MessageBox.Show("Bu alan boş bırakılamaz!");
                return;
            }
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM STUDENTS WHERE ID = @STUDENTID", Veritabani.Baglan());
            komut.Parameters.AddWithValue("@STUDENTID", int.Parse(tbOgrenciNumara.Text));

            int sorguSonucu = (int)komut.ExecuteScalar();
            if (sorguSonucu > 0)
            {
                FrmOgrenciNotlar frmOgrenciNotlar = new FrmOgrenciNotlar();
                frmOgrenciNotlar.numara = tbOgrenciNumara.Text;
                frmOgrenciNotlar.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show("Girdiğiniz öğrenci numarasına sahip bir öğrenci mevcut değildir!");

            Veritabani.Baglan().Close();
            
               
        }
        

        private void lblAnaMenuyeDon_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
        }

        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        {  
            tbOgrenciNumara.Focus();
        }
    }
}
