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
    public partial class FrmFaturaUrunDetay : Form
    {
        public FrmFaturaUrunDetay()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_FATURADETAY WHERE FaturaID ='" + urunid + "'", bgl.baglanti());
            da.Fill(dt);
            grdfaturaurundetay.DataSource = dt;
        }
        private void FrmFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDuzenleme frmfaturaurunduzenleme = new FrmFaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frmfaturaurunduzenleme.urunid = dr["FaturaUrunID"].ToString();

            }
            frmfaturaurunduzenleme.Show();
        }
    }
}
