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
using System.Xml;

namespace Ticari_Otomasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void azalanstoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UrunAd,SUM(UrunAdet) AS 'Kalan Stok Sayıları' FROM TBL_URUNLER GROUP BY UrunAd HAVING SUM(UrunAdet) <=20 ORDER BY SUM(UrunAdet)", bgl.baglanti());
            da.Fill(dt);
            grd_azalanstoklar.DataSource = dt;
        }
        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 8 NotTarih,NotSaat,NotBaslik FROM TBL_NOTLAR ORDER BY NotID DESC", bgl.baglanti());
            da.Fill(dt);
            grd_ajanda.DataSource = dt;
        }
        void sonhareketler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC SonFirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            grd_firmahareketler.DataSource = dt;
        }
        void fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT FirmaAd,FirmaTelefon1 FROM TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            grd_fihrist.DataSource = dt;
        }
        void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa/");
            while (xmloku.Read())//hata varsa internet bağlantısını kontrol et
            {
                if (xmloku.Name == "title")
                {
                    lstbx_haberler.Items.Add(xmloku.ReadString());
                }
            }
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            azalanstoklar();
            ajanda();
            sonhareketler();
            fihrist();
            wb_doviz.Navigate("http://www.tcmb.gov.tr/kurlar/today.xml");
            haberler();
            
        }
    }
}
