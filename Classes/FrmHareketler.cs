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
    public partial class FrmHareketler : Form
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void FHlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            grdhareketlerfirmalar.DataSource = dt;
        }
        void MHlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            grdhareketlermusteriler.DataSource = dt;
        }
        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            FHlistele();
            MHlistele();
        }
    }
}
