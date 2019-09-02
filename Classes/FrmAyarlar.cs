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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_ADMIN", bgl.baglanti());
            da.Fill(dt);
            grdayarlar.DataSource = dt;
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            txtkullanicad.Text = "";
            txtsifre.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtkullanicad.Text = dr["KullaniciAd"].ToString();
                txtsifre.Text = dr["KullaniciSifre"].ToString();
            }
        }

        private void txtkullanicad_TextChanged(object sender, EventArgs e)
        {
            if (txtkullanicad.Text !="" )
            {
                Btnislem.Text = "Güncelle";
            }
            else
            {
                Btnislem.Text = "Kaydet";
            }
        }

        private void Btnislem_Click(object sender, EventArgs e)
        {
            if (Btnislem.Text == "Kaydet")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TBL_ADMIN VALUES (@p1,@p2)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtkullanicad.Text);
                cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Kaydedildi ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                bgl.baglanti().Close();
                listele();
            }
            if (Btnislem.Text == "Güncelle")
            {
                SqlCommand cmd = new SqlCommand("UPDATE TBL_ADMIN SET KullaniciSifre=@p2 WHERE KullaniciAd=@p1", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtkullanicad.Text);
                cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglanti().Close();
                listele();
            }
        }
    }
}
