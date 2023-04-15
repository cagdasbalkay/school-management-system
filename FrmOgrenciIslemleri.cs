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
    public partial class FrmOgrenciIslemleri : Form
    {
        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DataSet2TableAdapters.STUDENTSTableAdapter ds2 = new DataSet2TableAdapters.STUDENTSTableAdapter();

        
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds2.ListStudents();
            dataGridView1.Columns[0].Visible = false;
            
            Veritabani.Baglan();
            SqlCommand komut = new SqlCommand("SELECT * FROM CLUBS", Veritabani.Baglan());
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbOgrenciKulup.DisplayMember = "CLUB";
            cbOgrenciKulup.ValueMember = "ID";
            cbOgrenciKulup.DataSource = dt;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds2.ListStudents();
        }

        string cinsiyet = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {  
            ds2.AddStudent(tbOgrenciAd.Text, tbOgrenciSoyad.Text, byte.Parse(cbOgrenciKulup.SelectedValue.ToString()),cinsiyet);
            MessageBox.Show("Öğrenci eklendi");
        }

        

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds2.DeleteStudent(int.Parse(tbOgrencid.Text));
            MessageBox.Show("Öğrenci silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tbOgrencid.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            tbOgrenciAd.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            tbOgrenciSoyad.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            cbOgrenciKulup.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            
            cinsiyet = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            if (cinsiyet == "Erkek")
            {
                rbErkek.Checked = true;
                rbKiz.Checked = false;
            }
            if (cinsiyet == "Kız")
            {
                rbKiz.Checked = true;
                rbErkek.Checked = false;
            }
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds2.UpdateStudent(tbOgrenciAd.Text, tbOgrenciSoyad.Text, cinsiyet, byte.Parse(cbOgrenciKulup.SelectedValue.ToString()), int.Parse(tbOgrencid.Text));
            MessageBox.Show("Öğrenci bilgileri güncellendi");
        }

        private void rbKiz_CheckedChanged(object sender, EventArgs e)
        {
            if(rbKiz.Checked == true)
            {
                cinsiyet = "Kız";
            }
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbErkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds2.GetStudent(tbArama.Text);
        }
    }
}
