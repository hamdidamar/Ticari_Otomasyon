using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }
        FrmUrunler frmurunler;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmurunler == null || frmurunler.IsDisposed )
            {
                frmurunler = new FrmUrunler();
                frmurunler.MdiParent = this;
                frmurunler.Show();
            }
        }
        FrmMusteriler frmmusteriler;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmmusteriler == null || frmmusteriler.IsDisposed)
            {
                frmmusteriler = new FrmMusteriler();
                frmmusteriler.MdiParent = this;
                frmmusteriler.Show();
            }
        }
        FrmFirmalar frmfirmalar;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmfirmalar == null || frmfirmalar.IsDisposed)
            {
                frmfirmalar = new FrmFirmalar();
                frmfirmalar.MdiParent = this;
                frmfirmalar.Show();
            }
        }
        FrmPersoneller frmpersoneller;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmpersoneller == null || frmpersoneller.IsDisposed)
            {
                frmpersoneller = new FrmPersoneller();
                frmpersoneller.MdiParent = this;
                frmpersoneller.Show();
            }
        }
        FrmRehber frmrehber;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmrehber == null || frmrehber.IsDisposed)
            {
                frmrehber = new FrmRehber();
                frmrehber.MdiParent = this;
                frmrehber.Show();
            }
        }
        FrmGiderler frmgiderler;
        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmgiderler == null || frmgiderler.IsDisposed)
            {
                frmgiderler = new FrmGiderler();
                frmgiderler.MdiParent = this;
                frmgiderler.Show();
            }
        }
        FrmBankalar frmbankalar;
        private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmbankalar == null || frmbankalar.IsDisposed)
            {
                frmbankalar = new FrmBankalar();
                frmbankalar.MdiParent = this;
                frmbankalar.Show();
            }
        }
        FrmFaturalar frmfaturalar;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmfaturalar == null || frmfaturalar.IsDisposed)
            {
                frmfaturalar = new FrmFaturalar();
                frmfaturalar.MdiParent = this;
                frmfaturalar.Show();
            }
        }
        FrmNotlar frmnotlar ;
        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmnotlar == null || frmnotlar.IsDisposed)
            {
                frmnotlar = new FrmNotlar();
                frmnotlar.MdiParent = this;
                frmnotlar.Show();
            }
        }
        FrmHareketler frmhareketler;
        private void BtnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmhareketler == null || frmhareketler.IsDisposed)
            {
                frmhareketler = new FrmHareketler();
                frmhareketler.MdiParent = this;
                frmhareketler.Show();
            }
        }
        FrmRaporlar frmraporlar;
        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmraporlar == null || frmraporlar.IsDisposed)
            {
                frmraporlar = new FrmRaporlar();
                frmraporlar.MdiParent = this;
                frmraporlar.Show();
            }
        }
        FrmStoklar frmstoklar;
        private void BtnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmstoklar == null || frmstoklar.IsDisposed)
            {
                frmstoklar = new FrmStoklar();
                frmstoklar.MdiParent = this;
                frmstoklar.Show();
            }
        }
        FrmAyarlar frmayarlar;
        private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmayarlar == null || frmayarlar.IsDisposed)
            {
                frmayarlar = new FrmAyarlar();
                frmayarlar.Show();
            }
        }
        FrmKasa frmkasa;
        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmkasa == null || frmkasa.IsDisposed)
            {
                frmkasa = new FrmKasa();
                frmkasa.MdiParent = this;
                frmkasa.kullanici = kullanici;
                frmkasa.Show();
            }
        }
        public string kullanici;
        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (frmanasayfa == null || frmanasayfa.IsDisposed)
            {
                frmanasayfa = new FrmAnaSayfa();
                frmanasayfa.MdiParent = this;
                frmanasayfa.Show();
            }
        }
        FrmAnaSayfa frmanasayfa;
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmanasayfa == null || frmanasayfa.IsDisposed)
            {
                frmanasayfa = new FrmAnaSayfa();
                frmanasayfa.MdiParent = this;
                frmanasayfa.Show();
            }
        }
    }
}
