namespace Ticari_Otomasyon
{
    partial class FrmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
            this.cmbpersonelilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbpersonelil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskpersoneltc = new System.Windows.Forms.MaskedTextBox();
            this.mskpersoneltel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtpersonelgorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.rchpersoneladres = new System.Windows.Forms.RichTextBox();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtpersonelmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdpersoneller = new DevExpress.XtraGrid.GridControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtpersonelsoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtpersonelad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtpersonelid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btntemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbpersonelilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbpersonelil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelgorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdpersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbpersonelilce
            // 
            this.cmbpersonelilce.Location = new System.Drawing.Point(175, 310);
            this.cmbpersonelilce.Name = "cmbpersonelilce";
            this.cmbpersonelilce.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbpersonelilce.Properties.Appearance.Options.UseFont = true;
            this.cmbpersonelilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbpersonelilce.Size = new System.Drawing.Size(154, 24);
            this.cmbpersonelilce.TabIndex = 32;
            // 
            // cmbpersonelil
            // 
            this.cmbpersonelil.Location = new System.Drawing.Point(175, 280);
            this.cmbpersonelil.Name = "cmbpersonelil";
            this.cmbpersonelil.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbpersonelil.Properties.Appearance.Options.UseFont = true;
            this.cmbpersonelil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbpersonelil.Size = new System.Drawing.Size(154, 24);
            this.cmbpersonelil.TabIndex = 31;
            this.cmbpersonelil.SelectedIndexChanged += new System.EventHandler(this.cmbpersonelil_SelectedIndexChanged);
            // 
            // mskpersoneltc
            // 
            this.mskpersoneltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskpersoneltc.Location = new System.Drawing.Point(175, 208);
            this.mskpersoneltc.Mask = "00000000000";
            this.mskpersoneltc.Name = "mskpersoneltc";
            this.mskpersoneltc.Size = new System.Drawing.Size(154, 24);
            this.mskpersoneltc.TabIndex = 30;
            // 
            // mskpersoneltel1
            // 
            this.mskpersoneltel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskpersoneltel1.Location = new System.Drawing.Point(176, 169);
            this.mskpersoneltel1.Mask = "(999) 000-0000";
            this.mskpersoneltel1.Name = "mskpersoneltel1";
            this.mskpersoneltel1.Size = new System.Drawing.Size(154, 24);
            this.mskpersoneltel1.TabIndex = 28;
            // 
            // txtpersonelgorev
            // 
            this.txtpersonelgorev.Location = new System.Drawing.Point(176, 340);
            this.txtpersonelgorev.Name = "txtpersonelgorev";
            this.txtpersonelgorev.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelgorev.Properties.Appearance.Options.UseFont = true;
            this.txtpersonelgorev.Size = new System.Drawing.Size(154, 24);
            this.txtpersonelgorev.TabIndex = 27;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(95, 346);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(66, 18);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "GÖREV : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(98, 388);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(63, 18);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "ADRES : ";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(224, 448);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(129, 31);
            this.BtnGuncelle.TabIndex = 23;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(132, 448);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(86, 31);
            this.BtnSil.TabIndex = 22;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // rchpersoneladres
            // 
            this.rchpersoneladres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchpersoneladres.Location = new System.Drawing.Point(175, 370);
            this.rchpersoneladres.Name = "rchpersoneladres";
            this.rchpersoneladres.Size = new System.Drawing.Size(154, 63);
            this.rchpersoneladres.TabIndex = 20;
            this.rchpersoneladres.Text = "";
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet.Appearance.Options.UseFont = true;
            this.Btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnkaydet.ImageOptions.Image")));
            this.Btnkaydet.Location = new System.Drawing.Point(15, 448);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(111, 31);
            this.Btnkaydet.TabIndex = 19;
            this.Btnkaydet.Text = "KAYDET";
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(117, 313);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "İLÇE : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(138, 279);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(23, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "İL : ";
            // 
            // txtpersonelmail
            // 
            this.txtpersonelmail.Location = new System.Drawing.Point(175, 250);
            this.txtpersonelmail.Name = "txtpersonelmail";
            this.txtpersonelmail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelmail.Properties.Appearance.Options.UseFont = true;
            this.txtpersonelmail.Size = new System.Drawing.Size(154, 24);
            this.txtpersonelmail.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(116, 253);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "MAIL : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(129, 208);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "TC : ";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdpersoneller;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grdpersoneller
            // 
            this.grdpersoneller.Location = new System.Drawing.Point(1, 2);
            this.grdpersoneller.MainView = this.gridView1;
            this.grdpersoneller.Name = "grdpersoneller";
            this.grdpersoneller.Size = new System.Drawing.Size(998, 557);
            this.grdpersoneller.TabIndex = 4;
            this.grdpersoneller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(74, 172);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TELEFON1 : ";
            // 
            // txtpersonelsoyad
            // 
            this.txtpersonelsoyad.Location = new System.Drawing.Point(176, 126);
            this.txtpersonelsoyad.Name = "txtpersonelsoyad";
            this.txtpersonelsoyad.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelsoyad.Properties.Appearance.Options.UseFont = true;
            this.txtpersonelsoyad.Size = new System.Drawing.Size(154, 24);
            this.txtpersonelsoyad.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(100, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "SOYAD : ";
            // 
            // txtpersonelad
            // 
            this.txtpersonelad.EditValue = "";
            this.txtpersonelad.Location = new System.Drawing.Point(176, 82);
            this.txtpersonelad.Name = "txtpersonelad";
            this.txtpersonelad.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelad.Properties.Appearance.Options.UseFont = true;
            this.txtpersonelad.Size = new System.Drawing.Size(154, 24);
            this.txtpersonelad.TabIndex = 4;
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
            // txtpersonelid
            // 
            this.txtpersonelid.Location = new System.Drawing.Point(176, 39);
            this.txtpersonelid.Name = "txtpersonelid";
            this.txtpersonelid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelid.Properties.Appearance.Options.UseFont = true;
            this.txtpersonelid.Size = new System.Drawing.Size(154, 24);
            this.txtpersonelid.TabIndex = 1;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Btntemizle);
            this.groupControl1.Controls.Add(this.cmbpersonelilce);
            this.groupControl1.Controls.Add(this.cmbpersonelil);
            this.groupControl1.Controls.Add(this.mskpersoneltc);
            this.groupControl1.Controls.Add(this.mskpersoneltel1);
            this.groupControl1.Controls.Add(this.txtpersonelgorev);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.rchpersoneladres);
            this.groupControl1.Controls.Add(this.Btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtpersonelmail);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtpersonelsoyad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtpersonelad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtpersonelid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1005, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 557);
            this.groupControl1.TabIndex = 5;
            // 
            // Btntemizle
            // 
            this.Btntemizle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btntemizle.Appearance.Options.UseFont = true;
            this.Btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btntemizle.ImageOptions.Image")));
            this.Btntemizle.Location = new System.Drawing.Point(15, 497);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(111, 31);
            this.Btntemizle.TabIndex = 33;
            this.Btntemizle.Text = "TEMİZLE";
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // FrmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdpersoneller);
            this.Name = "FrmPersoneller";
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbpersonelilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbpersonelil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelgorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdpersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbpersonelilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbpersonelil;
        private System.Windows.Forms.MaskedTextBox mskpersoneltc;
        private System.Windows.Forms.MaskedTextBox mskpersoneltel1;
        private DevExpress.XtraEditors.TextEdit txtpersonelgorev;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private System.Windows.Forms.RichTextBox rchpersoneladres;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtpersonelmail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdpersoneller;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtpersonelsoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtpersonelad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtpersonelid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btntemizle;
    }
}