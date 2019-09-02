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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            grdnotlar.DataSource = dt;
        }
        void temizle()
        {
            txtnotlarid.Text = "";
            txtnotlarhitap.Text = "";
            txtnotlarbaslik.Text = "";
            txtnotlarolusturan.Text = "";
            msknotlarsaat.Text = "";
            msknotlartarih.Text = "";
            rchnotlardetay.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_NOTLAR (NotTarih,NotSaat,NotBaslik,NotDetay,NotOlusturan,NotHitap) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", msknotlartarih.Text);
            cmd.Parameters.AddWithValue("@p2", msknotlarsaat.Text);
            cmd.Parameters.AddWithValue("@p3", txtnotlarbaslik.Text);
            cmd.Parameters.AddWithValue("@p4", rchnotlardetay.Text);
            cmd.Parameters.AddWithValue("@p5", txtnotlarolusturan.Text);
            cmd.Parameters.AddWithValue("@p6", txtnotlarhitap.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Not sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Verileri silme 
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_NOTLAR WHERE NotID = @p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txtnotlarid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Not silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_NOTLAR SET NotTarih = @p1,NotSaat = @p2,NotBaslik = @p3,NotDetay = @p4,NotOlusturan =  @p5,NotHitap = @p6 WHERE NotID = @p7 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", msknotlartarih.Text);
            cmd.Parameters.AddWithValue("@p2", msknotlarsaat.Text);
            cmd.Parameters.AddWithValue("@p3", txtnotlarbaslik.Text);
            cmd.Parameters.AddWithValue("@p4", rchnotlardetay.Text);
            cmd.Parameters.AddWithValue("@p5", txtnotlarolusturan.Text);
            cmd.Parameters.AddWithValue("@p6", txtnotlarhitap.Text);
            cmd.Parameters.AddWithValue("@p7", txtnotlarid.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtnotlarid.Text = dr["NotID"].ToString();
                msknotlartarih.Text = dr["NotTarih"].ToString();
                msknotlarsaat.Text = dr["NotSaat"].ToString();
                txtnotlarbaslik.Text = dr["NotBaslik"].ToString();
                rchnotlardetay.Text = dr["NotDetay"].ToString(); 
                txtnotlarolusturan.Text = dr["NotOlusturan"].ToString();
                txtnotlarhitap.Text = dr["NotHitap"].ToString();
                
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay frmnotdetay = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frmnotdetay.metin = dr["NotDetay"].ToString();
            }
            frmnotdetay.Show();
        }
    }
}
