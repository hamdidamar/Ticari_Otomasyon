namespace Ticari_Otomasyon
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.Btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.msknotlarsaat = new System.Windows.Forms.MaskedTextBox();
            this.msknotlartarih = new System.Windows.Forms.MaskedTextBox();
            this.txtnotlarhitap = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.rchnotlardetay = new System.Windows.Forms.RichTextBox();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdnotlar = new DevExpress.XtraGrid.GridControl();
            this.txtnotlarbaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtnotlarolusturan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtnotlarid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotlarhitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdnotlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotlarbaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotlarolusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotlarid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btntemizle
            // 
            this.Btntemizle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btntemizle.Appearance.Options.UseFont = true;
            this.Btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btntemizle.ImageOptions.Image")));
            this.Btntemizle.Location = new System.Drawing.Point(152, 505);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(154, 31);
            this.Btntemizle.TabIndex = 34;
            this.Btntemizle.Text = "TEMİZLE";
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // msknotlarsaat
            // 
            this.msknotlarsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msknotlarsaat.Location = new System.Drawing.Point(151, 119);
            this.msknotlarsaat.Mask = "00:00";
            this.msknotlarsaat.Name = "msknotlarsaat";
            this.msknotlarsaat.Size = new System.Drawing.Size(154, 24);
            this.msknotlarsaat.TabIndex = 29;
            this.msknotlarsaat.ValidatingType = typeof(System.DateTime);
            // 
            // msknotlartarih
            // 
            this.msknotlartarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msknotlartarih.Location = new System.Drawing.Point(151, 72);
            this.msknotlartarih.Mask = "00/00/0000";
            this.msknotlartarih.Name = "msknotlartarih";
            this.msknotlartarih.Size = new System.Drawing.Size(154, 24);
            this.msknotlartarih.TabIndex = 28;
            this.msknotlartarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtnotlarhitap
            // 
            this.txtnotlarhitap.Location = new System.Drawing.Point(152, 236);
            this.txtnotlarhitap.Name = "txtnotlarhitap";
            this.txtnotlarhitap.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnotlarhitap.Properties.Appearance.Options.UseFont = true;
            this.txtnotlarhitap.Size = new System.Drawing.Size(154, 24);
            this.txtnotlarhitap.TabIndex = 27;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(152, 468);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(153, 31);
            this.BtnGuncelle.TabIndex = 23;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(151, 431);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(155, 31);
            this.BtnSil.TabIndex = 22;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // rchnotlardetay
            // 
            this.rchnotlardetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchnotlardetay.Location = new System.Drawing.Point(151, 284);
            this.rchnotlardetay.Name = "rchnotlardetay";
            this.rchnotlardetay.Size = new System.Drawing.Size(155, 104);
            this.rchnotlardetay.TabIndex = 20;
            this.rchnotlardetay.Text = "";
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet.Appearance.Options.UseFont = true;
            this.Btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnkaydet.ImageOptions.Image")));
            this.Btnkaydet.Location = new System.Drawing.Point(152, 394);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(153, 31);
            this.Btnkaydet.TabIndex = 19;
            this.Btnkaydet.Text = "KAYDET";
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(75, 284);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "DETAY :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(31, 204);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(100, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "OLUSTURAN :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(77, 239);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "HİTAP : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(73, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "BAŞLIK :";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdnotlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // grdnotlar
            // 
            this.grdnotlar.Location = new System.Drawing.Point(1, 2);
            this.grdnotlar.MainView = this.gridView1;
            this.grdnotlar.Name = "grdnotlar";
            this.grdnotlar.Size = new System.Drawing.Size(917, 557);
            this.grdnotlar.TabIndex = 4;
            this.grdnotlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtnotlarbaslik
            // 
            this.txtnotlarbaslik.Location = new System.Drawing.Point(151, 159);
            this.txtnotlarbaslik.Name = "txtnotlarbaslik";
            this.txtnotlarbaslik.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnotlarbaslik.Properties.Appearance.Options.UseFont = true;
            this.txtnotlarbaslik.Size = new System.Drawing.Size(154, 24);
            this.txtnotlarbaslik.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(82, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "SAAT : ";
            // 
            // txtnotlarolusturan
            // 
            this.txtnotlarolusturan.EditValue = "";
            this.txtnotlarolusturan.Location = new System.Drawing.Point(152, 198);
            this.txtnotlarolusturan.Name = "txtnotlarolusturan";
            this.txtnotlarolusturan.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnotlarolusturan.Properties.Appearance.Options.UseFont = true;
            this.txtnotlarolusturan.Size = new System.Drawing.Size(154, 24);
            this.txtnotlarolusturan.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "TARİH :";
            // 
            // txtnotlarid
            // 
            this.txtnotlarid.Location = new System.Drawing.Point(152, 29);
            this.txtnotlarid.Name = "txtnotlarid";
            this.txtnotlarid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnotlarid.Properties.Appearance.Options.UseFont = true;
            this.txtnotlarid.Size = new System.Drawing.Size(154, 24);
            this.txtnotlarid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(105, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Btntemizle);
            this.groupControl1.Controls.Add(this.msknotlarsaat);
            this.groupControl1.Controls.Add(this.msknotlartarih);
            this.groupControl1.Controls.Add(this.txtnotlarhitap);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.rchnotlardetay);
            this.groupControl1.Controls.Add(this.Btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtnotlarbaslik);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtnotlarolusturan);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtnotlarid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(924, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(446, 557);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = " ";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdnotlar);
            this.Name = "FrmNotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnotlarhitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdnotlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotlarbaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotlarolusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotlarid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btntemizle;
        private System.Windows.Forms.MaskedTextBox msknotlarsaat;
        private System.Windows.Forms.MaskedTextBox msknotlartarih;
        private DevExpress.XtraEditors.TextEdit txtnotlarhitap;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private System.Windows.Forms.RichTextBox rchnotlardetay;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdnotlar;
        private DevExpress.XtraEditors.TextEdit txtnotlarbaslik;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtnotlarolusturan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtnotlarid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}