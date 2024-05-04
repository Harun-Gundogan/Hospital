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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChkDurum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            try
            {
                lblTC.Text = tc;

                //id
                SqlCommand komut = new SqlCommand("select (sekreter_ad +' '+ sekreter_soyad) as 'd' from tbl_sekreter where sekreter_tc=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblTC.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lblAd.Text = dr[0] + " ";


                }

                //branş
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select brans_ad as 'Branş' from tbl_brans", bgl.baglanti());
                da.Fill(dt);
                dataBrans.DataSource = dt;

                //doktorları listeye alma
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("select (doktor_ad + ' ' + doktor_soyad) as 'Doktor', Tbl_Brans.brans_ad as 'Branş' from Tbl_Doktor INNER JOIN Tbl_Brans ON Tbl_Doktor.brans_id = Tbl_Brans.brans_id", bgl.baglanti());
                da2.Fill(dt2);
                dataDoktor.DataSource = dt2;

                //branşı combobox'a aktarma
                SqlCommand komut2 = new SqlCommand("select brans_ad from tbl_brans", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    cmbBrans.Items.Add(dr2[0]);
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                          
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtxtSaat.Text == "" || txtTarih.Text == "" || cmbBrans.Text == "" || cmbDoktor.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevu (randevu_tarih, randevu_saat, randevu_brans, randevu_doktor) values (@p1, @p2, @p3, @p4)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@p1", txtTarih.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", mtxtSaat.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", cmbDoktor.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Randevu Oluşturuşdu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmRandevuListesi frm = new FrmRandevuListesi();
                    frm.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           



        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
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

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
          
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtxtDuyuru.Text == "")
                {
                    MessageBox.Show("Lütfen Duyuru Yazınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into tbl_duyuru values (@p1)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", rtxtDuyuru.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           
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
            try
            {
                SqlCommand komut2 = new SqlCommand("SELECT doktor_id FROM Tbl_Doktor INNER JOIN Tbl_Brans ON Tbl_Doktor.brans_id = Tbl_Brans.brans_id WHERE Tbl_Brans.brans_ad = @p2",

                bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", lblInfo.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    cmbDoktor.Items.Add(dr2[0]);
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
