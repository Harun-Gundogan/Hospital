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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            

            // doktor id
            SqlCommand komut2 = new SqlCommand("select (doktor_ad +' '+ doktor_soyad) as 'd' from tbl_doktor where doktor_tc=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label3.Text = dr2[0] + " ";
                

            }

            bgl.baglanti().Close();
            //randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevu_doktor='" + label3.Text + "'", bgl.baglanti()); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
            
        }


        private void BtnBilgi_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm = new FrmDoktorBilgiDuzenle();
            frm.tc = LblTC.Text;
            frm.Show();
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RtxtRandevuDetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();



        }

 
        private void BtnAnamenu_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Close();
        }
    }
}
