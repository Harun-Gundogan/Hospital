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
using System.Data.SqlClient;
using System.Net.Configuration;
using System.Linq.Expressions;

namespace Hastane_Otomasyonu
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void listele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_doktor", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            try
            {
                listele();

                SqlCommand komut2 = new SqlCommand("select * from tbl_brans", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    cmbBrans.Items.Add(dr2[1]);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == "" || txtSoyad.Text == "" || cmbBrans.Text == "" || mtxtTC.Text == "" || txtSifre.Text == "" || cmbCinsiyet.Text == "")
                {
                    MessageBox.Show("Lüfen boşalanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlCommand komut = new SqlCommand("insert into tbl_doktor (doktor_ad, doktor_soyad, doktor_brans, doktor_tc, doktor_sifre, doktor_cinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    komut.Parameters.AddWithValue("@p4", mtxtTC.Text);
                    komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtxtTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == "" || txtSoyad.Text == "" || cmbBrans.Text == "" || mtxtTC.Text == "" || txtSifre.Text == "" || cmbCinsiyet.Text == "")
                {
                    MessageBox.Show("Lüfen boşalanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("delete from tbl_doktor where doktor_tc=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", mtxtTC.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == "" || txtSoyad.Text == "" || cmbBrans.Text == "" || mtxtTC.Text == "" || txtSifre.Text == "" || cmbCinsiyet.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("update tbl_doktor set doktor_ad=@p1, doktor_soyad=@p2, doktor_brans=@p3, doktor_sifre=@p5, doktor_cinsiyet=@p6 where doktor_tc=@p4", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    komut.Parameters.AddWithValue("@p4", mtxtTC.Text);
                    komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Güncellenidi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MtxtTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
