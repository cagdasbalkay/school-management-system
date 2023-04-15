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
    public partial class FrmKulupIslemleri : Form
    {
        public FrmKulupIslemleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ID AS ID, CLUB AS Kulüp FROM CLUBS ", Veritabani.Baglan());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Veritabani.Baglan();
            SqlCommand komut = new SqlCommand("INSERT INTO CLUBS (CLUB) VALUES (@p1)", Veritabani.Baglan());

            komut.Parameters.AddWithValue("@p1", tbKulupAd.Text);
            komut.ExecuteNonQuery();
            Veritabani.Baglan().Close();
            MessageBox.Show("Kulüp eklendi !");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Veritabani.Baglan();
            SqlCommand komut = new SqlCommand("DELETE FROM CLUBS WHERE ID = @P1", Veritabani.Baglan());
            komut.Parameters.AddWithValue("@p1", tbKulupId.Text);
            komut.ExecuteNonQuery();
            Veritabani.Baglan().Close();
            MessageBox.Show("Kulüp silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Veritabani.Baglan();
            SqlCommand komut = new SqlCommand("UPDATE CLUBS SET CLUB = @p1 WHERE ID = @p2", Veritabani.Baglan());
            komut.Parameters.AddWithValue("@p1", tbKulupAd.Text);
            komut.Parameters.AddWithValue("@p2", tbKulupId.Text);
            komut.ExecuteNonQuery();
            Veritabani.Baglan().Close();
            MessageBox.Show("Kulüp güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satirNo = dataGridView1.SelectedCells[0].RowIndex;

            tbKulupId.Text = dataGridView1.Rows[satirNo].Cells[0].Value.ToString();
            tbKulupAd.Text = dataGridView1.Rows[satirNo].Cells[1].Value.ToString();
        }
    }
}
