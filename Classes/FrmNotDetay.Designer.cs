namespace Ticari_Otomasyon
{
    partial class FrmNotDetay
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
            this.rchnotdeyat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchnotdeyat
            // 
            this.rchnotdeyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rchnotdeyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchnotdeyat.Location = new System.Drawing.Point(0, 0);
            this.rchnotdeyat.Name = "rchnotdeyat";
            this.rchnotdeyat.ReadOnly = true;
            this.rchnotdeyat.Size = new System.Drawing.Size(659, 417);
            this.rchnotdeyat.TabIndex = 0;
            this.rchnotdeyat.Text = "";
            // 
            // FrmNotDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 417);
            this.Controls.Add(this.rchnotdeyat);
            this.Name = "FrmNotDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOT DETAY";
            this.Load += new System.EventHandler(this.FrmNotDetay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchnotdeyat;
    }
}