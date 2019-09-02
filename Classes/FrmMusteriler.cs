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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            grdmusteriler.DataSource = dt;
        }
        void SehirListele()
        {
            SqlCommand cmd = new SqlCommand("SELECT SEHIR FROM TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbmusteriil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtmusteriid.Text = "";
            txtmusteriad.Text = "";
            mskmusteritc.Text = "";
            txtmusterisoyad.Text = "";
            mskmusteritel1.Text = "";
            mskmusteritel2.Text = "";
            txtmusterimail.Text = "";
            cmbmusteriil.Text = "";
            cmbmusteriilce.Text = "";
            rchmusteriadres.Text = "";
            txtmusterivergidairesi.Text = "";
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            SehirListele();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            //Verileri kaydetme
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_MUSTERILER (MusteriAd,MusteriSoyad,MusteriTelefon,MusteriTelefon2,MusteriTC,MusteriMail,MusteriSehir,MusteriIlce,MusteriAdres,MusteriVergiDaire) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtmusteriad.Text);
            cmd.Parameters.AddWithValue("@p2", txtmusterisoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskmusteritel1.Text);
            cmd.Parameters.AddWithValue("@p4", mskmusteritel2.Text);
            cmd.Parameters.AddWithValue("@p5", mskmusteritc.Text);
            cmd.Parameters.AddWithValue("@p6", txtmusterimail.Text);
            cmd.Parameters.AddWithValue("@p7", cmbmusteriil.Text);
            cmd.Parameters.AddWithValue("@p8", cmbmusteriilce.Text);
            cmd.Parameters.AddWithValue("@p9", txtmusterivergidairesi.Text);
            cmd.Parameters.AddWithValue("@p10", rchmusteriadres.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Müşteri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Verileri silme 
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_MUSTERILER WHERE MusteriID = @p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txtmusteriid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Müşteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Verileri güncelleme
            SqlCommand cmd = new SqlCommand("UPDATE TBL_MUSTERILER SET MusteriAd = @p1,MusteriSoyad = @p2,MusteriTelefon = @p3,MusteriTelefon2 = @p4,MusteriTC = @p5,MusteriMail = @p6,MusteriSehir = @p7,MusteriIlce = @p8,MusteriVergiDaire =@p9,MusteriAdres =@p10 WHERE MusteriID = @p11", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtmusteriad.Text);
            cmd.Parameters.AddWithValue("@p2", txtmusterisoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskmusteritel1.Text);
            cmd.Parameters.AddWithValue("@p4", mskmusteritel2.Text);
            cmd.Parameters.AddWithValue("@p5", mskmusteritc.Text);
            cmd.Parameters.AddWithValue("@p6", txtmusterimail.Text);
            cmd.Parameters.AddWithValue("@p7", cmbmusteriil.Text);
            cmd.Parameters.AddWithValue("@p8", cmbmusteriilce.Text);
            cmd.Parameters.AddWithValue("@p9", txtmusterivergidairesi.Text);
            cmd.Parameters.AddWithValue("@p10", rchmusteriadres.Text);
            cmd.Parameters.AddWithValue("@p11", int.Parse(txtmusteriid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Müşteri Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            bgl.baglanti().Close();
        }

        private void cmbmusteriil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmusteriilce.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT ILCE FROM TBL_ILCELER WHERE SEHIR = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbmusteriil.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbmusteriilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtmusteriid.Text = dr["MusteriID"].ToString();
                txtmusteriad.Text = dr["MusteriAd"].ToString();
                txtmusterisoyad.Text = dr["MusteriSoyad"].ToString();
                mskmusteritel1.Text = dr["MusteriTelefon"].ToString();
                mskmusteritel2.Text = dr["MusteriTelefon2"].ToString();
                mskmusteritc.Text = dr["MusteriTC"].ToString();
                txtmusterimail.Text = dr["MusteriMail"].ToString();
                cmbmusteriil.Text = dr["MusteriSehir"].ToString();
                cmbmusteriilce.Text = dr["MusteriIlce"].ToString();
                txtmusterivergidairesi.Text = dr["MusteriVergiDaire"].ToString();
                rchmusteriadres.Text = dr["MusteriAdres"].ToString();

            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
