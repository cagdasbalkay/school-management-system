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
    public partial class FrmDersIslemleri : Form
    {
        public FrmDersIslemleri()
        {
            InitializeComponent();
        }
        DataSet2TableAdapters.LESSONSTableAdapter ds = new DataSet2TableAdapters.LESSONSTableAdapter();

        
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ListLessons();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.AddLesson(tbDersAd.Text);
            MessageBox.Show("Ders eklendi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ListLessons();
            dataGridView1.Columns[0].Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DeleteLesson(byte.Parse(tbDersId.Text));
            MessageBox.Show("Ders silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.UpdateLesson(tbDersAd.Text, byte.Parse(tbDersId.Text));
            MessageBox.Show("Ders güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tbDersId.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
           tbDersAd.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
    }

