using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtmailadres.Text = mail;
        }

        private void Btngonder_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("eposta@hotmail.com", "sifre");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com"; //hotmail için host
            istemci.EnableSsl = true;
            istemci.Timeout = 50000;
            message.To.Add(txtmailadres.Text);
            message.From = new MailAddress("eposta@hotmail.com","Görünecek Ad");
            message.Subject = txtmailkonu.Text;
            message.IsBodyHtml = true;
            message.Body = rchmailmesaj.Text;
            istemci.Send(message);
        }
        
    }
}
