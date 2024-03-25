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

namespace Hastane_Otomasyonu
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

         

          

            //branşı combobox'a aktarma
            SqlCommand komut2 = new SqlCommand("select brans_ad from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            SqlCommand komut = new SqlCommand("select brans_ad from tbl_brans", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr2.Read())
            {
                cmbDoktor.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

      
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbDoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            rTxtSikayet.Text=dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            randevu_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
        
       

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT doktor_ad, doktor_soyad FROM Tbl_Doktor INNER JOIN Tbl_Brans ON Tbl_Doktor.brans_id = Tbl_Brans.brans_id WHERE Tbl_Brans.brans_ad = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
        }
        private void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevu set randevu_tarih=@p1,randevu_saat=@p2,randevu_brans=@p3,randevu_doktor=@p4,randevu_durum=@p5,hasta_tc=@p6, hasta_sikayet=@p7 where randevu_id=@p8", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            komut.Parameters.AddWithValue("@p6", textBox1.Text);
            komut.Parameters.AddWithValue("@p5", comboBox3.Text);
            komut.Parameters.AddWithValue("@p7", rTxtSikayet.Text);
            komut.Parameters.AddWithValue("@p8", randevu_id.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_randevu Where randevu_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", randevu_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            textBox1.Clear();
            comboBox3.Items.Clear();
            maskedTextBox1.Clear();
            cmbBrans.Items.Clear();
            cmbDoktor.Items.Clear();
            
        }
    }
}
