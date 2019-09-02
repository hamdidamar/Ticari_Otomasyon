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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_GIDERLER",bgl.baglanti());
            da.Fill(dt);
            grdgiderler.DataSource = dt;
        }
        void temizle()
        {
            txtgiderlerid.Text = "";
            cmbgiderleray.Text = "";
            cmbgiderleryil.Text = "";
            txtgiderlerelektrik.Text = "";
            txtgiderlersu.Text = "";
            txtgiderlerdogalgaz.Text = "";
            txtgiderlerinternet.Text = "";
            txtgiderlermaaslar.Text = "";
            txtgiderlerekstra.Text = "";
            rchtxtgiderlernotlar.Text = "";
            
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderlistesi();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            //Verileri kaydetme
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_GIDERLER (GiderAy,GiderYil,GiderElektrik,GiderSu,GiderDogalgaz,GiderInternet,GiderMaaslar,GiderEkstra,GiderNotlar) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbgiderleray.Text);
            cmd.Parameters.AddWithValue("@p2", cmbgiderleryil.Text);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtgiderlerelektrik.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtgiderlersu.Text));
            cmd.Parameters.AddWithValue("@p5", decimal.Parse(txtgiderlerdogalgaz.Text));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txtgiderlerinternet.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txtgiderlermaaslar.Text));
            cmd.Parameters.AddWithValue("@p8", decimal.Parse(txtgiderlerekstra.Text));
            cmd.Parameters.AddWithValue("@p9", rchtxtgiderlernotlar.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Giderler sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Verileri silme 
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_GIDERLER WHERE GiderID = @p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txtgiderlerid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Giderler silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            giderlistesi();
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Verileri güncelleme
            SqlCommand cmd = new SqlCommand("UPDATE TBL_GIDERLER SET GiderAy = @p1,GiderYil = @p2,GiderElektrik = @p3,GiderSu = @p4,GiderDogalgaz = @p5,GiderInternet = @p6,GiderMaaslar = @p7,GiderEkstra = @p8,GiderNotlar =@p9 WHERE GiderID = @p10", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbgiderleray.Text);
            cmd.Parameters.AddWithValue("@p2", cmbgiderleryil.Text);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtgiderlerelektrik.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtgiderlersu.Text));
            cmd.Parameters.AddWithValue("@p5", decimal.Parse(txtgiderlerdogalgaz.Text));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txtgiderlerinternet.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txtgiderlermaaslar.Text));
            cmd.Parameters.AddWithValue("@p8", decimal.Parse(txtgiderlerekstra.Text));
            cmd.Parameters.AddWithValue("@p9", rchtxtgiderlernotlar.Text);
            cmd.Parameters.AddWithValue("@p10", int.Parse(txtgiderlerid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Gider Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            giderlistesi();
            bgl.baglanti().Close();
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtgiderlerid.Text = dr["GiderID"].ToString();
                cmbgiderleray.Text = dr["GiderAy"].ToString();
                cmbgiderleryil.Text = dr["GiderYil"].ToString();
                txtgiderlerelektrik.Text = dr["GiderElektrik"].ToString();
                txtgiderlersu.Text = dr["GiderSu"].ToString();
                txtgiderlerdogalgaz.Text = dr["GiderDogalgaz"].ToString();
                txtgiderlerinternet.Text = dr["GiderInternet"].ToString();
                txtgiderlermaaslar.Text = dr["GiderMaaslar"].ToString();
                txtgiderlerekstra.Text = dr["GiderEkstra"].ToString();
                rchtxtgiderlernotlar.Text = dr["GiderNotlar"].ToString();

            }
        }
    }
}
