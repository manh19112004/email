using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;

namespace EmailSenderReceiverApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
            if (!string.IsNullOrEmpty(txtAttachment.Text) && System.IO.File.Exists(txtAttachment.Text))
            {
                Attachment attachment = new Attachment(txtAttachment.Text);
                mail.Attachments.Add(attachment);
            }
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(txtFrom.Text, txtPassword.Text)
                };
                smtp.Send(mail);
                MessageBox.Show("✅ Email đã được gửi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Gửi email lỗi: " + ex.Message);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                lstInbox.Items.Clear();
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(txtFrom.Text, txtPassword.Text);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    int count = Math.Min(10, inbox.Count); // lấy 10 email mới nhất
                    for (int i = inbox.Count - count; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        lstInbox.Items.Add($"{message.Date.LocalDateTime.ToShortDateString()} - {message.Subject}");
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi nhận email: " + ex.Message);
            }
        }
    }
}

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = openFileDialog.FileName;
            }
        }
