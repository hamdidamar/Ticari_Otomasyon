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
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string urunid;
        private void FaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtfaturaurunid.Text = urunid;
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_FATURADETAY WHERE FaturaUrunID = @p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",urunid);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtfaturaurunad.Text = dr[1].ToString();
                txtfaturaurunmiktar.Text = dr[2].ToString();
                txtfaturaurunfiyat.Text = dr[3].ToString();
                txtfaturauruntutar.Text = dr[4].ToString();
                bgl.baglanti().Close();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_FATURADETAY SET UrunAd = @p1,Miktar = @p2,Fiyat = @p3,Tutar = @p4 WHERE FaturaUrunID = @p5", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtfaturaurunad.Text);
            cmd.Parameters.AddWithValue("@p2", txtfaturaurunmiktar.Text);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtfaturaurunfiyat.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtfaturauruntutar.Text));
            cmd.Parameters.AddWithValue("@p5", txtfaturaurunid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.None);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_FATURADETAY WHERE FaturaUrunID = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtfaturaurunid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
