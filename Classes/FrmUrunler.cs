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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            grdurunler.DataSource = dt;
        }
        void temizle()
        {
            txturunid.Text = "";
            txturunad.Text = "";
            txturunalisfiyat.Text = "";
            txturunmarka.Text = "";
            txturunmodel.Text = "";
            txturunsatisfiyat.Text = "";
            mskyil.Text = "";
            rchdetay.Text = "";
            nudadet.Value = 0;
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            //Verileri kaydetme
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_URUNLER (UrunAd,UrunMarka,UrunModel,UrunYil,UrunAdet,UrunMaliyet,UrunSatisFiyat,UrunDetay) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txturunad.Text);
            cmd.Parameters.AddWithValue("@p2", txturunmarka.Text);
            cmd.Parameters.AddWithValue("@p3", txturunmodel.Text);
            cmd.Parameters.AddWithValue("@p4", mskyil.Text);
            cmd.Parameters.AddWithValue("@p5", int.Parse(nudadet.Value.ToString()));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txturunalisfiyat.Text));
            cmd.Parameters.AddWithValue("@p7",decimal.Parse(txturunalisfiyat.Text));
            cmd.Parameters.AddWithValue("@p8",txturunsatisfiyat.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ürün sisteme eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Verileri silme 
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_URUNLER WHERE UrunID = @p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txturunid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ürün silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            listele();
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Gridwievdeki verileri form araçlarına yazdırma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txturunid.Text = dr["UrunID"].ToString();
            txturunad.Text = dr["UrunAd"].ToString();
            txturunmarka.Text = dr["UrunMarka"].ToString();
            txturunmodel.Text = dr["UrunModel"].ToString();
            mskyil.Text = dr["UrunYil"].ToString();
            nudadet.Value =decimal.Parse( dr["UrunAdet"].ToString());
            txturunalisfiyat.Text = dr["UrunMaliyet"].ToString();
            txturunsatisfiyat.Text = dr["UrunSatisFiyat"].ToString();
            rchdetay.Text = dr["UrunDetay"].ToString();


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Verileri güncelleme
            SqlCommand cmd = new SqlCommand("UPDATE TBL_URUNLER SET UrunAd = @p1,UrunMarka = @p2,UrunModel = @p3,UrunYil = @p4,UrunAdet = @p5,UrunMaliyet = @p6,UrunSatisFiyat = @p7,UrunDetay = @p8 WHERE UrunID = @p9",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txturunad.Text);
            cmd.Parameters.AddWithValue("@p2", txturunmarka.Text);
            cmd.Parameters.AddWithValue("@p3", txturunmodel.Text);
            cmd.Parameters.AddWithValue("@p4", mskyil.Text);
            cmd.Parameters.AddWithValue("@p5", int.Parse(nudadet.Value.ToString()));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txturunalisfiyat.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txturunalisfiyat.Text));
            cmd.Parameters.AddWithValue("@p8", txturunsatisfiyat.Text);
            cmd.Parameters.AddWithValue("@p9", int.Parse(txturunid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ürün Bilgisi Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();
            bgl.baglanti().Close();
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
