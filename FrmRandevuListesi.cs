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
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu", bgl.baglanti());
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
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

      
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                dateTime.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                mtxtSaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                cmbDoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                cmcRandevu.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                txtTC.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                rtxtSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                rndID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
               
            
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void listele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
       

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(dateTime.Text == "" || mtxtSaat.Text == "" || cmbBrans.Text == "" || cmbDoktor.Text == "" || txtTC.Text == "" || cmcRandevu.Text == "" || rtxtSikayet.Text == "" || rndID.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("update tbl_randevu set randevu_tarih=@p1,randevu_saat=@p2,randevu_brans=@p3,randevu_doktor=@p4,randevu_durum=@p5,hasta_tc=@p6, hasta_sikayet=@p7 where randevu_id=@p8", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", dateTime.Text);
                    komut.Parameters.AddWithValue("@p2", mtxtSaat.Text);
                    komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    komut.Parameters.AddWithValue("@p4", cmbDoktor.Text);
                    komut.Parameters.AddWithValue("@p6", txtTC.Text);
                    komut.Parameters.AddWithValue("@p5", cmcRandevu.Text);
                    komut.Parameters.AddWithValue("@p7", rtxtSikayet.Text);
                    komut.Parameters.AddWithValue("@p8", rndID.Text);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (dateTime.Text == "" || mtxtSaat.Text == "" || cmbBrans.Text == "" || cmbDoktor.Text == "" || txtTC.Text == "" || cmcRandevu.Text == "" || rtxtSikayet.Text == "" || rndID.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("delete from tbl_randevu Where randevu_id=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", rndID.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    txtTC.Clear();
                    cmcRandevu.Items.Clear();
                    mtxtSaat.Clear();
                    cmbBrans.Items.Clear();
                    cmbDoktor.Items.Clear();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }
    }
}
