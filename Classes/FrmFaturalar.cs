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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_FATURABILGI", bgl.baglanti());
            da.Fill(dt);
            grdfaturalar.DataSource = dt;
        }
        void temizle()
        {
            txtfaturaseri.Text = "";
            txtfaturasirano.Text = "";
            mskfaturatarih.Text = "";
            mskfaturasaat.Text = "";
            txtfaturavergidairesi.Text = "";
            txtfaturaalici.Text = "";
            txtfaturateden.Text = "";
            txtfaturatalan.Text = "";
            txtfaturaurunad.Text = "";
            txtfaturaurunfiyat.Text = "";
            txtfaturaurunid.Text = "";
            txtfaturaurunmiktar.Text = "";
            txtfaturauruntutar.Text = "";
            txtfaturavergidairesi.Text = "";
            txtfaturafaturaid.Text = "";
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtfaturafaturaid.Text == "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TBL_FATURABILGI (FaturaSeri,FaturaSiraNo,FaturaTarih,FaturaSaat,FaturaVergiDairesi,FaturaAlici,FaturaTeslimEden,FaturaTeslimAlan) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtfaturaseri.Text);
                cmd.Parameters.AddWithValue("@p2", txtfaturasirano.Text);
                cmd.Parameters.AddWithValue("@p3", mskfaturatarih.Text);
                cmd.Parameters.AddWithValue("@p4", mskfaturasaat.Text);
                cmd.Parameters.AddWithValue("@p5", txtfaturavergidairesi.Text);
                cmd.Parameters.AddWithValue("@p6", txtfaturaalici.Text);
                cmd.Parameters.AddWithValue("@p7", txtfaturateden.Text);
                cmd.Parameters.AddWithValue("@p8", txtfaturatalan.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                listele();

            }
            if (txtfaturafaturaid.Text != "")
            {
                SqlCommand cmd2 = new SqlCommand("INSERT INTO TBL_FATURADETAY (UrunAd,Miktar,Fiyat,Tutar,FaturaID) VALUES (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                cmd2.Parameters.AddWithValue("@p1", txtfaturaurunad.Text);
                cmd2.Parameters.AddWithValue("@p2",int.Parse(txtfaturaurunmiktar.Text));
                cmd2.Parameters.AddWithValue("@p3", double.Parse(txtfaturaurunfiyat.Text));
                cmd2.Parameters.AddWithValue("@p4", double.Parse(txtfaturauruntutar.Text));
                cmd2.Parameters.AddWithValue("@p5",int.Parse(txtfaturafaturaid.Text));
                cmd2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Detay Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }
        

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtfaturaid.Text = dr["FaturaID"].ToString();
                txtfaturaseri.Text = dr["FaturaSeri"].ToString();
                txtfaturasirano.Text = dr["FaturaSiraNo"].ToString();
                mskfaturatarih.Text = dr["FaturaTarih"].ToString();
                mskfaturasaat.Text = dr["FaturaSaat"].ToString();
                txtfaturavergidairesi.Text = dr["FaturaVergiDairesi"].ToString();
                txtfaturaalici.Text = dr["FaturaAlici"].ToString();
                txtfaturateden.Text = dr["FaturaTeslimEden"].ToString();
                txtfaturatalan.Text = dr["FaturaTeslimAlan"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_FATURABILGI WHERE FaturaID = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtfaturaid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();

        }

        private void Btntemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_FATURABILGI SET FaturaSeri =@p1,FaturaSiraNo=@p2,FaturaTarih=@p3,FaturaSaat=@p4,FaturaVergiDairesi=@p5,FaturaAlici=@p6,FaturaTeslimEden=@p7,FaturaTeslimAlan=@p8 WHERE FaturaID = @p9", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtfaturaseri.Text);
            cmd.Parameters.AddWithValue("@p2", txtfaturasirano.Text);
            cmd.Parameters.AddWithValue("@p3", mskfaturatarih.Text);
            cmd.Parameters.AddWithValue("@p4", mskfaturasaat.Text);
            cmd.Parameters.AddWithValue("@p5", txtfaturavergidairesi.Text);
            cmd.Parameters.AddWithValue("@p6", txtfaturaalici.Text);
            cmd.Parameters.AddWithValue("@p7", txtfaturateden.Text);
            cmd.Parameters.AddWithValue("@p8", txtfaturatalan.Text);
            cmd.Parameters.AddWithValue("@p9", int.Parse(txtfaturaid.Text));
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay frmfaturaurundetay = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frmfaturaurundetay.urunid = dr["FaturaID"].ToString();
            }
            frmfaturaurundetay.Show();
        }
    }
}
