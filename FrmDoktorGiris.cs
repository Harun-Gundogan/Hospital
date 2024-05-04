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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifre.Text==""||mtxtTc.Text=="")

                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("select * from tbl_doktor where doktor_tc=@p1 and doktor_sifre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", mtxtTc.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {

                        FrmDoktorDetay frm = new FrmDoktorDetay();
                        frm.tc = mtxtTc.Text;
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifre veya TC Kimlik Numarası Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    bgl.baglanti().Close();
                    this.Close();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Close();
        }
    }
}
