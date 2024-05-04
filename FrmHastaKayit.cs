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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == "" || txtSoyad.Text == "" || mtxtTC.Text == "" || mtxtTel.Text ==|| txtSifre.Text == "" || cmbCinsiyet.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into Tbl_Hasta (hasta_ad, hasta_soyad, hasta_tc, hasta_telefon, hasta_sifre, hasta_cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", mtxtTC.Text);
                    komut.Parameters.AddWithValue("@p4", mtxtTel.Text);
                    komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kaydınız oluşturulmuştur, Şifreniz: " + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
            
        }
    }
}
