using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailKit.Net.Smtp;
using MimeKit;


namespace WFA_MailApp
{
    public partial class Form1 : Form
    {

        #region Variables

        bool settings = false;
        string to = "";
        //string[] cc = new string[0];
        //string[] bcc = new string[0];
        string subject = "";

        string mailBody = "";

        string HTML = "";
        string SSL = "";

        string mail = "";
        string password = "";

        string smtp_address = "smtp.gmail.com";
        int smtp_host = 465;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void pcbSettings_Click(object sender, EventArgs e)
        {
            if (settings)
            {
                this.Height = 533;
                settings = false;
            }
            else
            {
                this.Height = 703;
                settings = true;
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {

            to = metroTextBox1.Text;
            //cc = metroTextBox2.Text;
            //bcc = metroTextBox3.Text;
            string[] cc = metroTextBox2.Text.Split(',');
            string[] bcc = metroTextBox3.Text.Split(',');

            subject = metroTextBox4.Text;
            mailBody = metroTextBox5.Text;

            HTML = metroTextBox6.Text;
            SSL = metroTextBox7.Text;
            
            mail = metroTextBox8.Text;
            password = metroTextBox9.Text;



            if (string.IsNullOrWhiteSpace(to))
            {
                errorProvider1.SetError(metroTextBox1, "Gönderilecek Mail Adresi Giriniz!");
            }
            else if (!string.IsNullOrWhiteSpace(cc[0]))
            {
                errorProvider1.Clear();

                for (int i = 0; i < cc.Length; i++)
                {
                    var mailMessage = new MimeMessage();
                    mailMessage.From.Add(MailboxAddress.Parse(mail));
                    mailMessage.To.Add(MailboxAddress.Parse(to));
                    mailMessage.Cc.Add(MailboxAddress.Parse(cc[i]));
                    mailMessage.Subject = subject;
                    mailMessage.Body = new TextPart("plain")
                    {
                        Text = mailBody.ToString()
                    };

                    using (var smtpClient = new SmtpClient())
                    {
                        smtpClient.Connect(smtp_address, smtp_host, true);
                        smtpClient.Authenticate(mail, password);
                        smtpClient.Send(mailMessage);
                        smtpClient.Disconnect(true);
                    }
                }
            }
            else if (!string.IsNullOrWhiteSpace(cc[0]) && !string.IsNullOrWhiteSpace(bcc[0])) 
            {
                errorProvider1.Clear();

                for (int i = 0; i < cc.Length; i++)
                {
                    for (int n = 0; n < bcc.Length; n++)
                    {
                        var mailMessage = new MimeMessage();
                        mailMessage.From.Add(MailboxAddress.Parse(mail));
                        mailMessage.To.Add(MailboxAddress.Parse(to));
                        mailMessage.Cc.Add(MailboxAddress.Parse(cc[i]));
                        mailMessage.Bcc.Add(MailboxAddress.Parse(bcc[n]));
                        mailMessage.Subject = subject;
                        mailMessage.Body = new TextPart("plain")
                        {
                            Text = mailBody.ToString()
                        };

                        using (var smtpClient = new SmtpClient())
                        {
                            smtpClient.Connect(smtp_address, smtp_host, true);
                            smtpClient.Authenticate(mail, password);
                            smtpClient.Send(mailMessage);
                            smtpClient.Disconnect(true);
                        }
                    }

                }
            }
            //else if (string.IsNullOrWhiteSpace(subject))
            //{

                //}
                //else if (string.IsNullOrWhiteSpace(mailBody))
                //{

                //}
            else
            {

                errorProvider1.Clear();


                var mailMessage = new MimeMessage();
                mailMessage.From.Add(MailboxAddress.Parse(mail));
                mailMessage.To.Add(MailboxAddress.Parse(to));
                mailMessage.Subject = subject;
                mailMessage.Body = new TextPart("plain")
                {
                    Text = mailBody.ToString()
                };

                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect(smtp_address, smtp_host, true);
                    smtpClient.Authenticate(mail, password);
                    smtpClient.Send(mailMessage);
                    smtpClient.Disconnect(true);
                }
            }

                


        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }
        }
    }
}
