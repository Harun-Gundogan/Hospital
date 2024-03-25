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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        private void label2_Click(object sender, EventArgs e)
        {
            Lbltc.Text = tc;
        }

       
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {   
            // ad soyad çekme

            Lbltc.Text = tc;
            SqlCommand komut = new SqlCommand("select hasta_ad, hasta_soyad from Tbl_Hasta where hasta_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Lbladsoyad.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();

            // randevu geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevu where hasta_tc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // branş çekme

            SqlCommand komut2 = new SqlCommand("select brans_ad from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]); 
            }
            bgl.baglanti().Close();

          
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("SELECT doktor_ad, doktor_soyad FROM Tbl_Doktor INNER JOIN Tbl_Brans ON Tbl_Doktor.brans_id = Tbl_Brans.brans_id WHERE Tbl_Brans.brans_ad = @p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevu_durum=0 and randevu_brans='" + CmbBrans.Text + "'" , bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle frm = new FrmHastaBilgiDuzenle();
            frm.tc = Lbltc.Text;
            frm.Show();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("update tbl_randevu set randevu_durum=1, hasta_tc=@p1, hasta_sikayet=@p2 where randevu_id=@p3", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", Lbltc.Text);
            komut4.Parameters.AddWithValue("@p2", RtxtSikayet.Text);
            komut4.Parameters.AddWithValue("@p3", txtid.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void BtnAnamenu_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            this.Close();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void BtnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAnamenu_Click_1(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Close();
        }
    }
}
