namespace Ticari_Otomasyon
{
    partial class FrmFaturaUrunDetay
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
            this.grdfaturaurundetay = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdfaturaurundetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdfaturaurundetay
            // 
            this.grdfaturaurundetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdfaturaurundetay.Location = new System.Drawing.Point(0, 0);
            this.grdfaturaurundetay.MainView = this.gridView1;
            this.grdfaturaurundetay.Name = "grdfaturaurundetay";
            this.grdfaturaurundetay.Size = new System.Drawing.Size(867, 367);
            this.grdfaturaurundetay.TabIndex = 0;
            this.grdfaturaurundetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdfaturaurundetay;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // FrmFaturaUrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 367);
            this.Controls.Add(this.grdfaturaurundetay);
            this.Name = "FrmFaturaUrunDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA ÜRÜN DETAY";
            this.Load += new System.EventHandler(this.FrmFaturaUrunDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdfaturaurundetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdfaturaurundetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}