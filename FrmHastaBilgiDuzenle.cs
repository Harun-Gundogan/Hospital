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

namespace Hastane_Otomasyonu
{
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            try
            {
                mtxtTc.Text = tc;
                SqlCommand komut = new SqlCommand("select * from tbl_hasta where hasta_tc=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mtxtTc.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtAd.Text = dr[1].ToString();
                    txtSoyad.Text = dr[2].ToString();
                    mtxtTc.Text = dr[3].ToString();
                    mtxtTel.Text = dr[4].ToString();
                    txtSifre.Text = dr[5].ToString();
                    cmbCinsiyet.Text = dr[6].ToString();

                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == "" || txtSifre.Text == "" || txtSoyad.Text == "" || mtxtTc.Text == "" || mtxtTel.Text == "" || cmbCinsiyet.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("update tbl_hasta set hasta_ad=@p1, hasta_soyad=@p2,hasta_telefon=@p3,hasta_sifre=@p4,hasta_cinsiyet=@p5 where hasta_tc=@p6", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", mtxtTel.Text); ;
                    komut.Parameters.AddWithValue("@p4", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
                    komut.Parameters.AddWithValue("@p6", mtxtTc.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           

        }

       
    }
}
