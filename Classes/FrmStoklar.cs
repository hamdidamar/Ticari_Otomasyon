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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            //chrt_stoklar.Series["srs_stoklar"].Points.AddPoint("İstanbul", 4);
            //chrt_stoklar.Series["srs_stoklar"].Points.AddPoint("İzmir", 6);
            //chrt_stoklar.Series["srs_stoklar"].Points.AddPoint("Ankara", 5);
            //chrt_stoklar.Series["srs_stoklar"].Points.AddPoint("Adana", 3);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UrunAd,SUM(UrunAdet) AS 'MİKTAR' FROM TBL_URUNLER GROUP BY UrunAd ", bgl.baglanti());
            da.Fill(dt);
            grdstoklar.DataSource = dt;

            //charta stok miktarı listeleme
            SqlCommand cmd = new SqlCommand("SELECT UrunAd,SUM(UrunAdet) AS 'MİKTAR' FROM TBL_URUNLER GROUP BY UrunAd", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chrt_stoklar.Series["srs_stoklar"].Points.AddPoint(Convert.ToString(dr[0]),Convert.ToInt32(dr[1]));
            }
            bgl.baglanti().Close();
        }
    }
}
