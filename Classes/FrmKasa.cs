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
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            grdkasamusterihareketler.DataSource = dt;
        }
        void firmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            grdkasafirmahareketler.DataSource = dt;
        }
        void cikishareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_GIDERLER ORDER BY GiderID ASC", bgl.baglanti());
            da.Fill(dt);
            grdkasacikis.DataSource = dt;
        }

        void toplamtutar()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(Tutar) FROM TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                lbltoplamtutar.Text = dr1[0].ToString() + " ₺";
            }
            bgl.baglanti().Close();
        }
        void odemeler()
        {
            //Son ay ödemeleri
            SqlCommand cmd2 = new SqlCommand("SELECT (GiderElektrik+GiderSu+GiderDogalgaz+GiderInternet+GiderEkstra) FROM TBL_GIDERLER ORDER BY GiderID ASC", bgl.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblodemeler.Text = dr2[0].ToString() + " ₺";
            }
            bgl.baglanti().Close();
        }
        void personelmaaslari()
        {
            SqlCommand cmd3 = new SqlCommand("SELECT GiderMaaslar FROM TBL_GIDERLER ORDER BY GiderID ASC", bgl.baglanti());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblpersonelmaaslari.Text = dr3[0].ToString() + " ₺";
            }
            bgl.baglanti().Close();
        }
        void musterisayisi()
        {
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lblmusterisayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void firmasayisi()
        {
            SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) FROM TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                lblfirmasayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void personelsayisi()
        {
            SqlCommand cmd8 = new SqlCommand("SELECT COUNT(*) FROM TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {
                lblpersonelsayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void stoksayisi()
        {
            SqlCommand cmd9 = new SqlCommand("SELECT SUM(UrunAdet) FROM TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = cmd9.ExecuteReader();
            while (dr9.Read())
            {
                lblstoksayisi.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void firmasehirsayisi()
        {
            SqlCommand cmd6 = new SqlCommand("SELECT COUNT(DISTINCT(FirmaSehir)) FROM TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                lblfsehirsayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void musterisehirsayisi()
        {
            SqlCommand cmd7 = new SqlCommand("SELECT COUNT(DISTINCT(MusteriSehir)) FROM TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                lblmsehirsayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void son4ayelektrik()
        {
            //ilk char kontrole son 4 ay elektrik bilgileri getirme
            groupControl10.Text = "Elektrik";
            chrt_aylar1.Series["Aylar"].Points.Clear();
            SqlCommand cmd10 = new SqlCommand("SELECT  TOP 4 GiderAy,GiderElektrik FROM TBL_GIDERLER ORDER BY GiderID DESC", bgl.baglanti());
            SqlDataReader dr10 = cmd10.ExecuteReader();
            while (dr10.Read())
            {
                chrt_aylar1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
            }
            bgl.baglanti().Close();

        }
        void son4aysu()
        {
            //ilk char kontrole son 4 ay su bilgileri getirme
            groupControl10.Text = "Su";
            chrt_aylar1.Series["Aylar"].Points.Clear();
            SqlCommand cmd11 = new SqlCommand("SELECT  TOP 4 GiderAy,GiderSu FROM TBL_GIDERLER ORDER BY GiderID DESC", bgl.baglanti());
            SqlDataReader dr11 = cmd11.ExecuteReader();
            while (dr11.Read())
            {
                chrt_aylar1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
            }
            bgl.baglanti().Close();
        }
        void son4aydogalgaz()
        {
            //ilk char kontrole son 4 ay su bilgileri getirme
            groupControl10.Text = "Doğalgaz";
            chrt_aylar1.Series["Aylar"].Points.Clear();
            SqlCommand cmd11 = new SqlCommand("SELECT  TOP 4 GiderAy,GiderDogalgaz FROM TBL_GIDERLER ORDER BY GiderID DESC", bgl.baglanti());
            SqlDataReader dr11 = cmd11.ExecuteReader();
            while (dr11.Read())
            {
                chrt_aylar1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
            }
            bgl.baglanti().Close();
        }

        void son4ayinternet()
        {
            //ilk char kontrole son 4 ay su bilgileri getirme
            groupControl10.Text = "İnternet";
            chrt_aylar1.Series["Aylar"].Points.Clear();
            SqlCommand cmd11 = new SqlCommand("SELECT  TOP 4 GiderAy,GiderInternet FROM TBL_GIDERLER ORDER BY GiderID DESC", bgl.baglanti());
            SqlDataReader dr11 = cmd11.ExecuteReader();
            while (dr11.Read())
            {
                chrt_aylar1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
            }
            bgl.baglanti().Close();
        }
        void son4ayekstra()
        {
            //ilk char kontrole son 4 ay su bilgileri getirme
            groupControl10.Text = "Ekstra";
            chrt_aylar1.Series["Aylar"].Points.Clear();
            SqlCommand cmd11 = new SqlCommand("SELECT  TOP 4 GiderAy,GiderEkstra FROM TBL_GIDERLER ORDER BY GiderID DESC", bgl.baglanti());
            SqlDataReader dr11 = cmd11.ExecuteReader();
            while (dr11.Read())
            {
                chrt_aylar1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
            }
            bgl.baglanti().Close();
        }
        public string kullanici;
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            musterihareket();
            firmahareket();
            cikishareket();
            toplamtutar();
            odemeler();
            personelmaaslari();
            musterisayisi();
            firmasayisi();
            firmasehirsayisi();
            musterisehirsayisi();
            personelsayisi();
            stoksayisi();
            son4ayelektrik();
            son4aysu();
            lblaktifkullanici.Text = kullanici;
        }
        int sayac1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac1++;
            if (sayac1 >= 0 && sayac1 <5)
            {
                son4ayelektrik();
            }
            if (sayac1 >=5 && sayac1 <10)
            {
                son4aysu();
            }
            if (sayac1 >=10 && sayac1 <15)
            {
                son4aydogalgaz();
            }
            if (sayac1 >= 15 && sayac1 <20)
            {
                son4ayinternet();
            }
            if (sayac1 >= 20 && sayac1 < 25)
            {
                son4ayekstra();
            }
            if (sayac1 == 26)
            {
                sayac1 = 0;
            }
        }
        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 >= 0 && sayac2 < 5)
            {
                son4ayinternet();
            }
            if (sayac2 >= 5 && sayac2 < 10)
            {
                son4ayekstra();
            }
            if (sayac2 >= 10 && sayac2 < 15)
            {
                son4aysu();
            }
            if (sayac2 >= 15 && sayac2 < 20)
            {
                son4ayekstra();
            }
            if (sayac2 >= 20 && sayac2 < 25)
            {
                son4ayelektrik();
            }
            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
}
