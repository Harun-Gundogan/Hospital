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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifre.Text == "" || mtxtTC.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("select * from Tbl_Sekreter where sekreter_tc=@p1 and sekreter_sifre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", mtxtTC.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        FrmSekreterDetay frm = new FrmSekreterDetay();
                        frm.tc = mtxtTC.Text;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("hatalı giriş");
                    }
                    bgl.baglanti().Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Close();
        }
    }
}
