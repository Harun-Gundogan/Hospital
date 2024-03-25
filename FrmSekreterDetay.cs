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
using System.Reflection;

namespace Hastane_Otomasyonu
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;
        
        SqlBaglanti bgl = new SqlBaglanti();
       
      
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text= tc;
      
            //id
            SqlCommand komut = new SqlCommand("select (sekreter_ad +' '+ sekreter_soyad) as 'd' from tbl_sekreter where sekreter_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[0] + " ";


            }

            //branş
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select brans_ad as 'Branş' from tbl_brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktorları listeye alma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktor_ad + ' ' + doktor_soyad) as 'Doktor', Tbl_Brans.brans_ad as 'Branş' from Tbl_Doktor INNER JOIN Tbl_Brans ON Tbl_Doktor.brans_id = Tbl_Brans.brans_id", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşı combobox'a aktarma
            SqlCommand komut2 = new SqlCommand("select brans_ad from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();                 
        }

       
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (MtxtSaat.Text==""||tarih.Text==""||CmbBrans.Text==""||CmbDoktor.Text=="")
            {
                MessageBox.Show("Lütfen İlgili Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevu (randevu_tarih, randevu_saat, randevu_brans, randevu_doktor) values (@p1, @p2, @p3, @p4)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", tarih.Text);
                komutkaydet.Parameters.AddWithValue("@p2", MtxtSaat.Text);
                komutkaydet.Parameters.AddWithValue("@p3", CmbBrans.Text);
                komutkaydet.Parameters.AddWithValue("@p4", CmbDoktor.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu Oluşturuşdu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmRandevuListesi frm = new FrmRandevuListesi();
                frm.Show();
            }



        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT doktor_ad, doktor_soyad FROM Tbl_Doktor INNER JOIN Tbl_Brans ON Tbl_Doktor.brans_id = Tbl_Brans.brans_id WHERE Tbl_Brans.brans_ad = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            
          
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            if (RtxtDuyuru.Text == "")
            {
                MessageBox.Show("Lütfen Duyuru Yazınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into tbl_duyuru values (@p1)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", RtxtDuyuru.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Duyuru Oluşturuldu","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();

        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();
        }

        private void BtnRandevuListele_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();

        }

        private void BtnAnamenu_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Close();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
             SqlCommand komut2 = new SqlCommand("SELECT doktor_id FROM Tbl_Doktor INNER JOIN Tbl_Brans ON Tbl_Doktor.brans_id = Tbl_Brans.brans_id WHERE Tbl_Brans.brans_ad = @p2",
                 
bgl.baglanti());
            komut2.Parameters.AddWithValue("@p2", label2.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbDoktor.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        
    }
}
