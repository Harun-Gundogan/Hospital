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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string tc;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == "" || txtSifre.Text == "" || txtSoyad.Text == "" || mTxtTC.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("update tbl_doktor set doktor_ad=@p1, doktor_soyad=@p2,doktor_sifre=@p3 where doktor_tc=@p4", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p4", mTxtTC.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            try
            {
                mTxtTC.Text = tc;
                SqlCommand komut = new SqlCommand("select * from tbl_doktor where doktor_tc=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mTxtTC.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtAd.Text = dr[1].ToString();
                    txtSoyad.Text = dr[2].ToString();
                    txtSifre.Text = dr[5].ToString();

                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        
    }
}
