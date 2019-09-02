namespace Ticari_Otomasyon
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.grdurunler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.nudadet = new System.Windows.Forms.NumericUpDown();
            this.rchdetay = new System.Windows.Forms.RichTextBox();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txturunsatisfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txturunalisfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txturunmodel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txturunmarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txturunad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mskyil = new System.Windows.Forms.MaskedTextBox();
            this.txturunid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdurunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudadet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunsatisfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunalisfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunmodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdurunler
            // 
            this.grdurunler.Location = new System.Drawing.Point(0, 0);
            this.grdurunler.MainView = this.gridView1;
            this.grdurunler.Name = "grdurunler";
            this.grdurunler.Size = new System.Drawing.Size(998, 557);
            this.grdurunler.TabIndex = 0;
            this.grdurunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.MintCream;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.grdurunler;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Btntemizle);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.nudadet);
            this.groupControl1.Controls.Add(this.rchdetay);
            this.groupControl1.Controls.Add(this.Btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txturunsatisfiyat);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txturunalisfiyat);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txturunmodel);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txturunmarka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txturunad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.mskyil);
            this.groupControl1.Controls.Add(this.txturunid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1005, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 557);
            this.groupControl1.TabIndex = 1;
            // 
            // Btntemizle
            // 
            this.Btntemizle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btntemizle.Appearance.Options.UseFont = true;
            this.Btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btntemizle.ImageOptions.Image")));
            this.Btntemizle.Location = new System.Drawing.Point(5, 487);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(111, 31);
            this.Btntemizle.TabIndex = 34;
            this.Btntemizle.Text = "TEMİZLE";
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(222, 439);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(131, 31);
            this.BtnGuncelle.TabIndex = 23;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(121, 437);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(90, 33);
            this.BtnSil.TabIndex = 22;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // nudadet
            // 
            this.nudadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudadet.Location = new System.Drawing.Point(176, 247);
            this.nudadet.Name = "nudadet";
            this.nudadet.Size = new System.Drawing.Size(154, 24);
            this.nudadet.TabIndex = 21;
            // 
            // rchdetay
            // 
            this.rchdetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchdetay.Location = new System.Drawing.Point(176, 358);
            this.rchdetay.Name = "rchdetay";
            this.rchdetay.Size = new System.Drawing.Size(154, 63);
            this.rchdetay.TabIndex = 20;
            this.rchdetay.Text = "";
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet.Appearance.Options.UseFont = true;
            this.Btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnkaydet.ImageOptions.Image")));
            this.Btnkaydet.Location = new System.Drawing.Point(5, 439);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(102, 31);
            this.Btnkaydet.TabIndex = 19;
            this.Btnkaydet.Text = "KAYDET";
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(103, 361);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "DETAY : ";
            // 
            // txturunsatisfiyat
            // 
            this.txturunsatisfiyat.Location = new System.Drawing.Point(176, 324);
            this.txturunsatisfiyat.Name = "txturunsatisfiyat";
            this.txturunsatisfiyat.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunsatisfiyat.Properties.Appearance.Options.UseFont = true;
            this.txturunsatisfiyat.Size = new System.Drawing.Size(154, 24);
            this.txturunsatisfiyat.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(67, 327);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "SATIŞ FİYAT : ";
            // 
            // txturunalisfiyat
            // 
            this.txturunalisfiyat.Location = new System.Drawing.Point(176, 291);
            this.txturunalisfiyat.Name = "txturunalisfiyat";
            this.txturunalisfiyat.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunalisfiyat.Properties.Appearance.Options.UseFont = true;
            this.txturunalisfiyat.Size = new System.Drawing.Size(154, 24);
            this.txturunalisfiyat.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(78, 294);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(85, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "ALIŞ FİYAT : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(131, 208);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "YIL : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(112, 249);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "ADET : ";
            // 
            // txturunmodel
            // 
            this.txturunmodel.Location = new System.Drawing.Point(176, 169);
            this.txturunmodel.Name = "txturunmodel";
            this.txturunmodel.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunmodel.Properties.Appearance.Options.UseFont = true;
            this.txturunmodel.Size = new System.Drawing.Size(154, 24);
            this.txturunmodel.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(101, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "MODEL : ";
            // 
            // txturunmarka
            // 
            this.txturunmarka.Location = new System.Drawing.Point(176, 126);
            this.txturunmarka.Name = "txturunmarka";
            this.txturunmarka.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunmarka.Properties.Appearance.Options.UseFont = true;
            this.txturunmarka.Size = new System.Drawing.Size(154, 24);
            this.txturunmarka.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(100, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "MARKA : ";
            // 
            // txturunad
            // 
            this.txturunad.EditValue = "";
            this.txturunad.Location = new System.Drawing.Point(176, 82);
            this.txturunad.Name = "txturunad";
            this.txturunad.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunad.Properties.Appearance.Options.UseFont = true;
            this.txturunad.Size = new System.Drawing.Size(154, 24);
            this.txturunad.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(135, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "AD :";
            // 
            // mskyil
            // 
            this.mskyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskyil.Location = new System.Drawing.Point(176, 208);
            this.mskyil.Name = "mskyil";
            this.mskyil.Size = new System.Drawing.Size(154, 24);
            this.mskyil.TabIndex = 2;
            // 
            // txturunid
            // 
            this.txturunid.Location = new System.Drawing.Point(176, 39);
            this.txturunid.Name = "txturunid";
            this.txturunid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunid.Properties.Appearance.Options.UseFont = true;
            this.txturunid.Size = new System.Drawing.Size(154, 24);
            this.txturunid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(141, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdurunler);
            this.Name = "FrmUrunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdurunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudadet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunsatisfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunalisfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunmodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdurunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.NumericUpDown nudadet;
        private System.Windows.Forms.RichTextBox rchdetay;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txturunsatisfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txturunalisfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txturunmodel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txturunmarka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txturunad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox mskyil;
        private DevExpress.XtraEditors.TextEdit txturunid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton Btntemizle;
    }
}