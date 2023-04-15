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
    public partial class FrmSinavNotlari : Form
    {
        public FrmSinavNotlari()
        {
            InitializeComponent();
        }
        

        DataSet2TableAdapters.GRADESTableAdapter ds2 = new DataSet2TableAdapters.GRADESTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT \r\nLESSONS.LESSON AS [DERS], STUDENTS.NAME AS [AD], STUDENTS.SURNAME AS [SOYAD], GRADES.ID AS [NOT ID],\r\nGRADES.STUDENTID AS [OGRENCI ID], GRADES.EXAM1 AS[SINAV 1],GRADES.EXAM2 AS[SINAV 2],GRADES.EXAM3 AS[SINAV 3],\r\nGRADES.PROJECT AS[PROJE], GRADES.AGP AS [ORTALAMA] , GRADES.STATE AS[DURUM]\r\nFROM GRADES INNER JOIN LESSONS\r\nON GRADES.LESSONID = LESSONS.ID INNER JOIN\r\nSTUDENTS ON GRADES.STUDENTID = STUDENTS.ID\r\nWHERE GRADES.STUDENTID = @STUDENTID", baglanti);

            komut.Parameters.AddWithValue("@STUDENTID", int.Parse(tbOgrencid.Text));

            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=CAGDAS\SQLEXPRESS;Initial Catalog= SCHOOL;Integrated Security=True");
        private void FrmSinavNotlari_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM LESSONS", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbDers.DisplayMember = "LESSON";
            cbDers.ValueMember = "ID";
            cbDers.DataSource = dt;
            baglanti.Close();
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowIndex = e.RowIndex;

            notid = int.Parse(
                dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());

            tbOgrencid.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            tbSinav1.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            tbSinav2.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            tbSinav3.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            tbProje.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            tbOrtalama.Text = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            tbDurum.Text = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
        }
        
        int sinav1, sinav2, sinav3, proje;

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double ortalama;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            sinav1 = int.Parse(tbSinav1.Text);
            sinav2 = int.Parse(tbSinav2.Text);
            sinav3 = int.Parse(tbSinav3.Text);
            proje = int.Parse(tbProje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4.00;
            tbOrtalama.Text = ortalama.ToString();

            if(ortalama >= 50)
            {
                tbDurum.Text = "True";
            }
            else
            {
                tbDurum.Text = "False";
            }
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds2.UpdateGrade(byte.Parse(cbDers.SelectedValue.ToString()), int.Parse(tbOgrencid.Text), byte.Parse(tbSinav1.Text), byte.Parse(tbSinav2.Text), byte.Parse(tbSinav3.Text), byte.Parse(tbProje.Text), decimal.Parse(tbOrtalama.Text), bool.Parse(tbDurum.Text),notid);
        }
    }
}
