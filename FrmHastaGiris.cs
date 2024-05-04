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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void LinkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frm = new FrmHastaKayit();
            frm.Show();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifre.Text == "" || mtxtTc.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SqlCommand komut = new SqlCommand("select * from Tbl_Hasta Where hasta_tc=@p1 and hasta_sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mtxtTc.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    FrmHastaDetay frm = new FrmHastaDetay();
                    frm.tc = mtxtTc.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Close();
        }
    }
}
