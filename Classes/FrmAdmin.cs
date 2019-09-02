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

namespace Ticari_Otomasyon
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
        
        private void BtnGirisYap_MouseHover_1(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.LightSeaGreen;
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_ADMIN WHERE KullaniciAd = @p1 AND KullaniciSifre = @p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtkullanicad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul frmanamodul = new FrmAnaModul();
                frmanamodul.Show();
                frmanamodul.kullanici = txtkullanicad.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
