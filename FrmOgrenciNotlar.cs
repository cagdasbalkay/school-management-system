using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementProject
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        public string numara;
        public string ogrenciAd = "";
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("SELECT LESSON AS Ders, EXAM1 AS [Sınav 1], EXAM2 AS [Sınav 2], EXAM3 AS [Sınav 3], PROJECT AS [Proje], AGP AS [Ortalama], STATE AS [Durum] FROM GRADES INNER JOIN LESSONS ON GRADES.ID = LESSONS.ID WHERE STUDENTID = @p1", Veritabani.Baglan());
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand komut1 = new SqlCommand("SELECT NAME,SURNAME from STUDENTS WHERE ID=@p1", Veritabani.Baglan());

            komut1.Parameters.AddWithValue("@p1", numara);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())

            {

                this.Text = dr1[0] + " " + dr1[1].ToString();

            }
            Veritabani.Baglan().Close();

        }

        private void pctOgrenciNotlarKapa_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmOgrenciGiris frmOgrenciGiris = new FrmOgrenciGiris();
            frmOgrenciGiris.Show(); 
        }
    }
}
