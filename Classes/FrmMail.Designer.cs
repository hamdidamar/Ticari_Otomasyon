namespace Ticari_Otomasyon
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.txtmailadres = new DevExpress.XtraEditors.TextEdit();
            this.txtmailkonu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.rchmailmesaj = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Btngonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailadres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailkonu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(35, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi :";
            // 
            // txtmailadres
            // 
            this.txtmailadres.Location = new System.Drawing.Point(139, 130);
            this.txtmailadres.Name = "txtmailadres";
            this.txtmailadres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtmailadres.Properties.Appearance.Options.UseFont = true;
            this.txtmailadres.Size = new System.Drawing.Size(240, 26);
            this.txtmailadres.TabIndex = 1;
            // 
            // txtmailkonu
            // 
            this.txtmailkonu.Location = new System.Drawing.Point(139, 171);
            this.txtmailkonu.Name = "txtmailkonu";
            this.txtmailkonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtmailkonu.Properties.Appearance.Options.UseFont = true;
            this.txtmailkonu.Size = new System.Drawing.Size(240, 26);
            this.txtmailkonu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(77, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu :";
            // 
            // rchmailmesaj
            // 
            this.rchmailmesaj.Location = new System.Drawing.Point(139, 217);
            this.rchmailmesaj.Name = "rchmailmesaj";
            this.rchmailmesaj.Size = new System.Drawing.Size(240, 144);
            this.rchmailmesaj.TabIndex = 4;
            this.rchmailmesaj.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(77, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 100);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(124, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail Gönderme Paneli";
            // 
            // Btngonder
            // 
            this.Btngonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btngonder.Appearance.Options.UseFont = true;
            this.Btngonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btngonder.ImageOptions.Image")));
            this.Btngonder.Location = new System.Drawing.Point(165, 391);
            this.Btngonder.Name = "Btngonder";
            this.Btngonder.Size = new System.Drawing.Size(178, 23);
            this.Btngonder.TabIndex = 7;
            this.Btngonder.Text = "GÖNDER";
            this.Btngonder.Click += new System.EventHandler(this.Btngonder_Click);
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 462);
            this.Controls.Add(this.Btngonder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rchmailmesaj);
            this.Controls.Add(this.txtmailkonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmailadres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAİL";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmailadres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailkonu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtmailadres;
        private DevExpress.XtraEditors.TextEdit txtmailkonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchmailmesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton Btngonder;
        private System.Windows.Forms.Label label4;
    }
}