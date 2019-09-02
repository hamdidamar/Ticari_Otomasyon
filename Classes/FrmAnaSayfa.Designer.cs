namespace Ticari_Otomasyon
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_azalanstoklar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grd_ajanda = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.grd_fihrist = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grd_firmahareketler = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.wb_doviz = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstbx_haberler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_azalanstoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ajanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_fihrist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_firmahareketler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grd_azalanstoklar);
            this.groupControl1.Location = new System.Drawing.Point(3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(466, 260);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Azalan Stoklar";
            // 
            // grd_azalanstoklar
            // 
            this.grd_azalanstoklar.Location = new System.Drawing.Point(5, 23);
            this.grd_azalanstoklar.MainView = this.gridView1;
            this.grd_azalanstoklar.Name = "grd_azalanstoklar";
            this.grd_azalanstoklar.Size = new System.Drawing.Size(456, 232);
            this.grd_azalanstoklar.TabIndex = 0;
            this.grd_azalanstoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_azalanstoklar;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grd_ajanda);
            this.groupControl3.Location = new System.Drawing.Point(475, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(442, 260);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Ajanda";
            // 
            // grd_ajanda
            // 
            this.grd_ajanda.Location = new System.Drawing.Point(5, 23);
            this.grd_ajanda.MainView = this.gridView2;
            this.grd_ajanda.Name = "grd_ajanda";
            this.grd_ajanda.Size = new System.Drawing.Size(432, 232);
            this.grd_ajanda.TabIndex = 0;
            this.grd_ajanda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grd_ajanda;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.grd_fihrist);
            this.groupControl4.Location = new System.Drawing.Point(475, 268);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(442, 231);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Fihrist";
            // 
            // grd_fihrist
            // 
            this.grd_fihrist.Location = new System.Drawing.Point(5, 23);
            this.grd_fihrist.MainView = this.gridView3;
            this.grd_fihrist.Name = "grd_fihrist";
            this.grd_fihrist.Size = new System.Drawing.Size(432, 203);
            this.grd_fihrist.TabIndex = 0;
            this.grd_fihrist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grd_fihrist;
            this.gridView3.Name = "gridView3";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grd_firmahareketler);
            this.groupControl2.Location = new System.Drawing.Point(3, 268);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(471, 231);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Son 10 Hareket";
            // 
            // grd_firmahareketler
            // 
            this.grd_firmahareketler.Location = new System.Drawing.Point(5, 23);
            this.grd_firmahareketler.MainView = this.gridView4;
            this.grd_firmahareketler.Name = "grd_firmahareketler";
            this.grd_firmahareketler.Size = new System.Drawing.Size(461, 203);
            this.grd_firmahareketler.TabIndex = 0;
            this.grd_firmahareketler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grd_firmahareketler;
            this.gridView4.Name = "gridView4";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(923, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(447, 492);
            this.xtraTabControl1.TabIndex = 5;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.wb_doviz);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(441, 461);
            this.xtraTabPage1.Text = "Döviz Kurları";
            // 
            // wb_doviz
            // 
            this.wb_doviz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_doviz.Location = new System.Drawing.Point(0, 0);
            this.wb_doviz.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_doviz.Name = "wb_doviz";
            this.wb_doviz.Size = new System.Drawing.Size(441, 461);
            this.wb_doviz.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.pictureBox1);
            this.xtraTabPage2.Controls.Add(this.lstbx_haberler);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(441, 461);
            this.xtraTabPage2.Text = "Haberler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lstbx_haberler
            // 
            this.lstbx_haberler.FormattingEnabled = true;
            this.lstbx_haberler.HorizontalScrollbar = true;
            this.lstbx_haberler.Location = new System.Drawing.Point(5, 75);
            this.lstbx_haberler.Name = "lstbx_haberler";
            this.lstbx_haberler.Size = new System.Drawing.Size(431, 381);
            this.lstbx_haberler.TabIndex = 2;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmAnaSayfa";
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_azalanstoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ajanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_fihrist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_firmahareketler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_azalanstoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl grd_ajanda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl grd_fihrist;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grd_firmahareketler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.WebBrowser wb_doviz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstbx_haberler;
    }
}