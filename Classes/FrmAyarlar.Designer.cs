namespace Ticari_Otomasyon
{
    partial class FrmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyarlar));
            this.grdayarlar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkullanicad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.Btnislem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdayarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdayarlar
            // 
            this.grdayarlar.Location = new System.Drawing.Point(1, 1);
            this.grdayarlar.MainView = this.gridView1;
            this.grdayarlar.Name = "grdayarlar";
            this.grdayarlar.Size = new System.Drawing.Size(792, 265);
            this.grdayarlar.TabIndex = 1;
            this.grdayarlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdayarlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // txtkullanicad
            // 
            this.txtkullanicad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullanicad.Location = new System.Drawing.Point(150, 297);
            this.txtkullanicad.Name = "txtkullanicad";
            this.txtkullanicad.Size = new System.Drawing.Size(147, 26);
            this.txtkullanicad.TabIndex = 4;
            this.txtkullanicad.TextChanged += new System.EventHandler(this.txtkullanicad_TextChanged);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(150, 340);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(147, 26);
            this.txtsifre.TabIndex = 5;
            // 
            // Btnislem
            // 
            this.Btnislem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btnislem.Appearance.Options.UseFont = true;
            this.Btnislem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnislem.ImageOptions.Image")));
            this.Btnislem.Location = new System.Drawing.Point(150, 378);
            this.Btnislem.Name = "Btnislem";
            this.Btnislem.Size = new System.Drawing.Size(147, 39);
            this.Btnislem.TabIndex = 6;
            this.Btnislem.Text = "Güncelle";
            this.Btnislem.Click += new System.EventHandler(this.Btnislem_Click);
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(794, 429);
            this.Controls.Add(this.Btnislem);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanicad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdayarlar);
            this.Name = "FrmAyarlar";
            this.Text = "AYARLAR";
            this.Load += new System.EventHandler(this.FrmAyarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdayarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdayarlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkullanicad;
        private System.Windows.Forms.TextBox txtsifre;
        private DevExpress.XtraEditors.SimpleButton Btnislem;
    }
}