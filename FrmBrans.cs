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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

       private void listele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
                if (txtBransID.Text == "" || txtBransAd.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into tbl_brans (brans_ad) values (@p1)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBransID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBransID.Text == "" || txtBransAd.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("delete from tbl_brans Where brans_id=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtBransID.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    txtBransAd.Clear();
                    txtBransID.Clear();
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
                if (txtBransID.Text == "" || txtBransAd.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("update tbl_brans set brans_ad=@p1 where brans_id=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtBransID.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

       
    }
}
