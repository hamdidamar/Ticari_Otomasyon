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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            grdpersoneller.DataSource = dt;
        }
        void SehirListele()
        {
            SqlCommand cmd = new SqlCommand("SELECT SEHIR FROM TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbpersonelil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtpersonelid.Text = "";
            txtpersonelad.Text = "";
            txtpersonelsoyad.Text = "";
            mskpersoneltc.Text = "";
            txtpersonelgorev.Text = "";
            mskpersoneltel1.Text = "";
            txtpersonelmail.Text = "";
            cmbpersonelil.Text = "";
            cmbpersonelilce.Text = "";
            rchpersoneladres.Text = "";
            txtpersonelgorev.Text = "";
        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            listele();
            SehirListele();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            //Verileri kaydetme
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_PERSONELLER (PersonelAd,PersonelSoyad,PersonelTelefon,PersonelTC,PersonelMail,PersonelSehir,PersonelIlce,PersonelAdres,PersonelGorev) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            cmd.Parameters.AddWithValue("@p2", txtpersonelsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskpersoneltel1.Text);
            cmd.Parameters.AddWithValue("@p4", mskpersoneltc.Text);
            cmd.Parameters.AddWithValue("@p5", txtpersonelmail.Text);
            cmd.Parameters.AddWithValue("@p6", cmbpersonelil.Text);
            cmd.Parameters.AddWithValue("@p7", cmbpersonelilce.Text);
            cmd.Parameters.AddWithValue("@p8", rchpersoneladres.Text);
            cmd.Parameters.AddWithValue("@p9", txtpersonelgorev.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Verileri silme 
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_PERSONELLER WHERE PersonelID = @p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txtpersonelid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Verileri güncelleme
            SqlCommand cmd = new SqlCommand("UPDATE TBL_PERSONELLER SET PersonelAd = @p1,PersonelSoyad = @p2,PersonelTelefon = @p3,PersonelTC = @p4,PersonelMail = @p5,PersonelSehir = @p6,PersonelIlce = @p7,PersonelAdres = @p8,PersonelGorev =@p9 WHERE PersonelID = @p10", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            cmd.Parameters.AddWithValue("@p2", txtpersonelsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskpersoneltel1.Text);
            cmd.Parameters.AddWithValue("@p4", mskpersoneltc.Text);
            cmd.Parameters.AddWithValue("@p5", txtpersonelmail.Text);
            cmd.Parameters.AddWithValue("@p6", cmbpersonelil.Text);
            cmd.Parameters.AddWithValue("@p7", cmbpersonelilce.Text);
            cmd.Parameters.AddWithValue("@p8", rchpersoneladres.Text);
            cmd.Parameters.AddWithValue("@p9", txtpersonelgorev.Text);
            cmd.Parameters.AddWithValue("@p10",int.Parse(txtpersonelid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            bgl.baglanti().Close();
        }

        private void cmbpersonelil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbpersonelilce.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT ILCE FROM TBL_ILCELER WHERE SEHIR = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbpersonelil.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbpersonelilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtpersonelid.Text = dr["PersonelID"].ToString();
                txtpersonelad.Text = dr["PersonelAd"].ToString();
                txtpersonelsoyad.Text = dr["PersonelSoyad"].ToString();
                mskpersoneltel1.Text = dr["PersonelTelefon"].ToString();
                mskpersoneltc.Text = dr["PersonelTC"].ToString();
                txtpersonelmail.Text = dr["PersonelMail"].ToString();
                cmbpersonelil.Text = dr["PersonelSehir"].ToString();
                cmbpersonelilce.Text = dr["PersonelIlce"].ToString();
                txtpersonelgorev.Text = dr["PersonelGorev"].ToString();
                rchpersoneladres.Text = dr["PersonelAdres"].ToString();

            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
