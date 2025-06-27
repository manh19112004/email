namespace GmailStyleWinFormsApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ListBox lstInbox;
        private System.Windows.Forms.TextBox txtEmailDetail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lstInbox = new System.Windows.Forms.ListBox();
            this.txtEmailDetail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.txtFrom.Location = new System.Drawing.Point(12, 12);
            this.txtFrom.Size = new System.Drawing.Size(360, 23);
            this.txtFrom.ReadOnly = true;

            this.txtPassword.Location = new System.Drawing.Point(12, 41);
            this.txtPassword.Size = new System.Drawing.Size(360, 23);
            this.txtPassword.ReadOnly = true;
            this.txtPassword.PasswordChar = '*';

            this.txtTo.Location = new System.Drawing.Point(12, 70);
            this.txtTo.Size = new System.Drawing.Size(360, 23);

            this.txtSubject.Location = new System.Drawing.Point(12, 99);
            this.txtSubject.Size = new System.Drawing.Size(360, 23);

            this.txtBody.Location = new System.Drawing.Point(12, 128);
            this.txtBody.Size = new System.Drawing.Size(360, 80);
            this.txtBody.Multiline = true;

            this.btnAttach.Location = new System.Drawing.Point(12, 214);
            this.btnAttach.Size = new System.Drawing.Size(120, 23);
            this.btnAttach.Text = "Đính kèm";
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);

            this.btnSend.Location = new System.Drawing.Point(138, 214);
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            this.btnReceive.Location = new System.Drawing.Point(219, 214);
            this.btnReceive.Size = new System.Drawing.Size(153, 23);
            this.btnReceive.Text = "Nhận Email (IMAP)";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);

            this.lstInbox.Location = new System.Drawing.Point(12, 243);
            this.lstInbox.Size = new System.Drawing.Size(360, 100);
            this.lstInbox.SelectedIndexChanged += new System.EventHandler(this.lstInbox_SelectedIndexChanged);

            this.txtEmailDetail.Location = new System.Drawing.Point(12, 349);
            this.txtEmailDetail.Size = new System.Drawing.Size(360, 100);
            this.txtEmailDetail.Multiline = true;
            this.txtEmailDetail.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lstInbox);
            this.Controls.Add(this.txtEmailDetail);
            this.Text = "Gửi & Nhận Email - Gmail Style";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}