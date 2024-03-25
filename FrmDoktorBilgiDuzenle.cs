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
           
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktor set doktor_ad=@p1, doktor_soyad=@p2,doktor_sifre=@p3 where doktor_tc=@p4",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p4",MtxtTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MtxtTC.Text = tc;
            SqlCommand komut = new SqlCommand("select * from tbl_doktor where doktor_tc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MtxtTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                TxtSifre.Text = dr[5].ToString();

            }
            bgl.baglanti().Close();
        }

        
    }
}
