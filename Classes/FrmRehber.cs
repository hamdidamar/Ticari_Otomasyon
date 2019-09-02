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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            //Müşteri Bilgileri Getirme
            DataTable dtmusteri = new DataTable();
            SqlDataAdapter damusteri = new SqlDataAdapter("SELECT MusteriID,MusteriAd,MusteriSoyad,MusteriTelefon,MusteriTelefon2,MusteriMail FROM TBL_MUSTERILER ",bgl.baglanti());
            damusteri.Fill(dtmusteri);
            grdrehbermusteriler.DataSource = dtmusteri;

            //Firma Bilgileri Getirme
            DataTable dtfirma = new DataTable();
            SqlDataAdapter dafirma = new SqlDataAdapter("SELECT FirmaID,FirmaAd,FirmaYetkiliAdSoyad,FirmaTelefon1,FirmaTelefon2,FirmaTelefon3,FirmaMail,FirmaFax FROM TBL_FIRMALAR ", bgl.baglanti());
            dafirma.Fill(dtfirma);
            grdrehberfirmalar.DataSource = dtfirma;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmmail = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null )
            {
                frmmail.mail = dr["MusteriMail"].ToString();
            }
            frmmail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmmail = new FrmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                frmmail.mail = dr["FirmaMail"].ToString();
            }
            frmmail.Show();
        }
    }
}
