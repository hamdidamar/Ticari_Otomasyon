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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdfirmalar.DataSource = dt;
        }
        void temizle()
        {
            txtfirmaid.Text = "";
            txtfirmaad.Text = "";
            txtfirmaygorev.Text = "";
            txtfirmayetkili.Text = "";
            txtfirmaytc.Text = "";
            txtfirmasektor.Text = "";
            mskfirmatel1.Text = "";
            mskfirmatel2.Text = "";
            mskfirmatel3.Text = "";
            txtfirmamail.Text = "";
            mskfirmafax.Text = "";
            cmbfirmail.Text = "";
            cmbfirmailce.Text = "";
            rchfirmaadres.Text = "";
            txtfirmavergidairesi.Text = "";
        }
        void SehirListele()
        {
            SqlCommand cmd = new SqlCommand("SELECT SEHIR FROM TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbfirmail.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void kodaciklamalar()
        {
            SqlCommand cmd = new SqlCommand("SELECT FIRMAKOD1 FROM TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rchfirmakod1.Text = dr[0].ToString();

            }
            bgl.baglanti().Close();
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            listele();
            SehirListele();
            kodaciklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtfirmaid.Text = dr["FirmaID"].ToString();
                txtfirmaad.Text = dr["FirmaAd"].ToString();
                txtfirmaygorev.Text = dr["FirmaYetkiliGorev"].ToString();
                txtfirmayetkili.Text = dr["FirmaYetkiliAdSoyad"].ToString();
                txtfirmaytc.Text = dr["FirmaYetkiliTC"].ToString();
                txtfirmasektor.Text = dr["FirmaSektor"].ToString();
                mskfirmatel1.Text = dr["FirmaTelefon1"].ToString();
                mskfirmatel2.Text = dr["FirmaTelefon2"].ToString();
                mskfirmatel3.Text = dr["FirmaTelefon3"].ToString();
                txtfirmamail.Text = dr["FirmaMail"].ToString();
                mskfirmafax.Text = dr["FirmaFax"].ToString(); 
                cmbfirmail.Text = dr["FirmaSehir"].ToString();
                cmbfirmailce.Text = dr["FirmaIlce"].ToString();
                rchfirmaadres.Text = dr["FirmaAdres"].ToString();
                txtfirmavergidairesi.Text = dr["FirmaVergiDairesi"].ToString();
                rchfirmakod1.Text = dr["FirmaOzelKod"].ToString();
                rchfirmakod2.Text = dr["FirmaOzelKod2"].ToString();
                rchfirmakod3.Text = dr["FirmaOzelKod3"].ToString();
            }
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_FIRMALAR (FirmaAd,FirmaYetkiliGorev,FirmaYetkiliAdSoyad,FirmaYetkiliTC,FirmaSektor,FirmaTelefon1,FirmaTelefon2,FirmaTelefon3,FirmaMail,FirmaFax,FirmaSehir,FirmaIlce,FirmaAdres,FirmaVergiDairesi) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", bgl.baglanti());
            //,FirmaOzelKod,FirmaOzelKod2,FirmaOzelKod3 ve ,@p15,@p16,@p17 eklenecek
            cmd.Parameters.AddWithValue("@p1", txtfirmaad.Text);
            cmd.Parameters.AddWithValue("@p2", txtfirmaygorev.Text);
            cmd.Parameters.AddWithValue("@p3", txtfirmayetkili.Text);
            cmd.Parameters.AddWithValue("@p4", txtfirmaytc.Text);
            cmd.Parameters.AddWithValue("@p5", txtfirmasektor.Text);
            cmd.Parameters.AddWithValue("@p6", mskfirmatel1.Text);
            cmd.Parameters.AddWithValue("@p7", mskfirmatel2.Text);
            cmd.Parameters.AddWithValue("@p8", mskfirmatel3.Text);
            cmd.Parameters.AddWithValue("@p9", txtfirmamail.Text);
            cmd.Parameters.AddWithValue("@p10", mskfirmafax.Text);
            cmd.Parameters.AddWithValue("@p11", cmbfirmail.Text);
            cmd.Parameters.AddWithValue("@p12", cmbfirmailce.Text);
            cmd.Parameters.AddWithValue("@p13", rchfirmaadres.Text);
            cmd.Parameters.AddWithValue("@p14", txtfirmavergidairesi.Text);
            //cmd.Parameters.AddWithValue("@p15", rchfirmakod1.Text);
            //cmd.Parameters.AddWithValue("@p16", rchfirmakod2.Text);
            //cmd.Parameters.AddWithValue("@p17", rchfirmakod3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Firma sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_FIRMALAR WHERE FirmaID = @p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txtfirmaid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Firma silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_FIRMALAR SET FirmaAd= @p1,FirmaYetkiliGorev= @p2,FirmaYetkiliAdSoyad= @p3,FirmaYetkiliTC= @p4,FirmaSektor= @p5,FirmaTelefon1= @p6,FirmaTelefon2= @p7,FirmaTelefon3= @p8,FirmaMail= @p9,FirmaFax= @p10,FirmaSehir= @p11,FirmaIlce= @p12,FirmaAdres= @p13,FirmaVergiDairesi= @p14,FirmaOzelKod= @p15,FirmaOzelKod2= @p16,FirmaOzelKod3= @p17 WHERE FirmaID = @p18", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtfirmaad.Text);
            cmd.Parameters.AddWithValue("@p2", txtfirmaygorev.Text);
            cmd.Parameters.AddWithValue("@p3", txtfirmayetkili.Text);
            cmd.Parameters.AddWithValue("@p4", txtfirmaytc.Text);
            cmd.Parameters.AddWithValue("@p5", txtfirmasektor.Text);
            cmd.Parameters.AddWithValue("@p6", mskfirmatel1.Text);
            cmd.Parameters.AddWithValue("@p7", mskfirmatel2.Text);
            cmd.Parameters.AddWithValue("@p8", mskfirmatel3.Text);
            cmd.Parameters.AddWithValue("@p9", txtfirmamail.Text);
            cmd.Parameters.AddWithValue("@p10", mskfirmafax.Text);
            cmd.Parameters.AddWithValue("@p11", cmbfirmail.Text);
            cmd.Parameters.AddWithValue("@p12", cmbfirmailce.Text);
            cmd.Parameters.AddWithValue("@p13", rchfirmaadres.Text);
            cmd.Parameters.AddWithValue("@p14", txtfirmavergidairesi.Text);
            cmd.Parameters.AddWithValue("@p15", rchfirmakod1.Text);
            cmd.Parameters.AddWithValue("@p16", rchfirmakod2.Text);
            cmd.Parameters.AddWithValue("@p17", rchfirmakod3.Text);
            cmd.Parameters.AddWithValue("@p18", int.Parse(txtfirmaid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Firma Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            bgl.baglanti().Close();
        }

        private void cmbfirmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbfirmailce.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT ILCE FROM TBL_ILCELER WHERE SEHIR = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbfirmail.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbfirmailce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
