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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            grdbankalar.DataSource = dt;
        }
        void SehirListele()
        {
            SqlCommand cmd = new SqlCommand("SELECT SEHIR FROM TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbbankail.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtbankaid.Text = "";
            txtbankaad.Text = "";
            txtbankasube.Text = "";
            txtbankaiban.Text = "";
            txtbankahesapno.Text = "";
            txtbankayetkili.Text = "";
            mskbankatarih.Text = "";
            txtbankahesapturu.Text = "";
            cmbbankail.Text = "";
            cmbbankailce.Text = "";
            mskbankatel.Text = "";
            cmbbankabifrma.Text = "";
        }

        void firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FirmaID,FirmaAd FROM TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            cmbbankabifrma.Properties.NullText = "Lütfen Firma Seçiniz";
            cmbbankabifrma.Properties.ValueMember = "FirmaID";
            cmbbankabifrma.Properties.DisplayMember = "FirmaAd";
            cmbbankabifrma.Properties.DataSource = dt;
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            SehirListele();
            firmalistesi();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            //Verileri kaydetme
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_BANKALAR (BankaAd,BankaSube,BankaIBAN,BankaHesapNo,BankaYetkili,BankaTarih,BankaHesapTuru,BankaIl,BankaIlce,BankaTelefon,FirmaID) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtbankaad.Text);
            cmd.Parameters.AddWithValue("@p2", txtbankasube.Text);
            cmd.Parameters.AddWithValue("@p3", txtbankaiban.Text);
            cmd.Parameters.AddWithValue("@p4", txtbankahesapno.Text);
            cmd.Parameters.AddWithValue("@p5", txtbankayetkili.Text);
            cmd.Parameters.AddWithValue("@p6", mskbankatarih.Text);
            cmd.Parameters.AddWithValue("@p7", txtbankahesapturu.Text);
            cmd.Parameters.AddWithValue("@p8", cmbbankail.Text);
            cmd.Parameters.AddWithValue("@p9", cmbbankailce.Text);
            cmd.Parameters.AddWithValue("@p10", mskbankatel.Text);
            cmd.Parameters.AddWithValue("@p11", cmbbankabifrma.EditValue); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("Banka sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Verileri güncelleme
            SqlCommand cmd = new SqlCommand("UPDATE TBL_BANKALAR SET BankaAd = @p1,BankaSube = @p2,BankaIBAN = @p3,BankaHesapNo = @p4,BankaYetkili = @p5,BankaTarih = @p6,BankaHesapTuru = @p7,BankaIl = @p8,BankaIlce =@p9,BankaTelefon = @p10, FirmaID = @p11 WHERE BankaID = @p12", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtbankaad.Text);
            cmd.Parameters.AddWithValue("@p2", txtbankasube.Text);
            cmd.Parameters.AddWithValue("@p3", txtbankaiban.Text);
            cmd.Parameters.AddWithValue("@p4", txtbankahesapno.Text);
            cmd.Parameters.AddWithValue("@p5", txtbankayetkili.Text);
            cmd.Parameters.AddWithValue("@p6", mskbankatarih.Text);
            cmd.Parameters.AddWithValue("@p7", txtbankahesapturu.Text);
            cmd.Parameters.AddWithValue("@p8", cmbbankail.Text);
            cmd.Parameters.AddWithValue("@p9", cmbbankailce.Text);
            cmd.Parameters.AddWithValue("@p10", mskbankatel.Text);
            cmd.Parameters.AddWithValue("@p11", cmbbankabifrma.EditValue);
            cmd.Parameters.AddWithValue("@p12", int.Parse(txtbankaid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Verileri silme 
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_BANKALAR WHERE BankaID = @p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txtbankaid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Banka silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
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
                txtbankaid.Text = dr["BankaID"].ToString();
                txtbankaad.Text = dr["BankaAd"].ToString();
                txtbankasube.Text = dr["BankaSube"].ToString();
                txtbankaiban.Text = dr["BankaIBAN"].ToString();
                txtbankahesapno.Text = dr["BankaHesapNo"].ToString();
                txtbankayetkili.Text = dr["BankaYetkili"].ToString();
                mskbankatarih.Text = dr["BankaTarih"].ToString();
                txtbankahesapturu.Text = dr["BankaHesapTuru"].ToString();
                cmbbankail.Text = dr["BankaIl"].ToString();
                cmbbankailce.Text = dr["BankaIlce"].ToString();
                mskbankatel.Text = dr["BankaTelefon"].ToString();
                cmbbankabifrma.Text = dr["FirmaID"].ToString();

            }
        }

        private void cmbbankail_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbankailce.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT ILCE FROM TBL_ILCELER WHERE SEHIR = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbbankail.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbbankailce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
    }
}
