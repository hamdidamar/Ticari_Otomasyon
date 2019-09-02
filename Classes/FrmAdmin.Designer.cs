namespace Ticari_Otomasyon
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtkullanicad = new DevExpress.XtraEditors.TextEdit();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullanicad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Ad:";
            // 
            // txtkullanicad
            // 
            this.txtkullanicad.Location = new System.Drawing.Point(149, 216);
            this.txtkullanicad.Name = "txtkullanicad";
            this.txtkullanicad.Properties.Appearance.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullanicad.Properties.Appearance.Options.UseFont = true;
            this.txtkullanicad.Size = new System.Drawing.Size(103, 24);
            this.txtkullanicad.TabIndex = 1;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(149, 258);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Properties.Appearance.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Properties.Appearance.Options.UseFont = true;
            this.txtsifre.Properties.UseSystemPasswordChar = true;
            this.txtsifre.Size = new System.Drawing.Size(103, 24);
            this.txtsifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(98, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "TİCARİ OTOMASYON - 2019";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.Location = new System.Drawing.Point(149, 304);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(103, 31);
            this.BtnGirisYap.TabIndex = 6;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            this.BtnGirisYap.MouseHover += new System.EventHandler(this.BtnGirisYap_MouseHover_1);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 600);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkullanicad);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtkullanicad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtkullanicad;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGirisYap;
    }
}