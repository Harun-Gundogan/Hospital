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
        
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MtxtTc.Text = tc;
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hasta_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MtxtTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MtxtTc.Text = dr[3].ToString();
                MtxtTel.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_hasta set hasta_ad=@p1, hasta_soyad=@p2,hasta_telefon=@p3,hasta_sifre=@p4,hasta_cinsiyet=@p5 where hasta_tc=@p6",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MtxtTel.Text); ;
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", MtxtTc.Text); 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıtlar güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

       
    }
}
