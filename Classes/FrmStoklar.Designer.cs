namespace Ticari_Otomasyon
{
    partial class FrmStoklar
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.chrt_stoklar = new DevExpress.XtraCharts.ChartControl();
            this.grdstoklar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_stoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdstoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chrt_stoklar
            // 
            this.chrt_stoklar.Legend.Name = "Default Legend";
            this.chrt_stoklar.Location = new System.Drawing.Point(468, 1);
            this.chrt_stoklar.Name = "chrt_stoklar";
            series1.LegendTextPattern = "{A}";
            series1.Name = "srs_stoklar";
            series1.View = pieSeriesView1;
            this.chrt_stoklar.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chrt_stoklar.Size = new System.Drawing.Size(903, 413);
            this.chrt_stoklar.TabIndex = 1;
            // 
            // grdstoklar
            // 
            this.grdstoklar.Location = new System.Drawing.Point(0, 0);
            this.grdstoklar.MainView = this.gridView1;
            this.grdstoklar.Name = "grdstoklar";
            this.grdstoklar.Size = new System.Drawing.Size(468, 561);
            this.grdstoklar.TabIndex = 3;
            this.grdstoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdstoklar;
            this.gridView1.Name = "gridView1";
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.grdstoklar);
            this.Controls.Add(this.chrt_stoklar);
            this.Name = "FrmStoklar";
            this.Text = "STOKLAR";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_stoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdstoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chrt_stoklar;
        private DevExpress.XtraGrid.GridControl grdstoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}