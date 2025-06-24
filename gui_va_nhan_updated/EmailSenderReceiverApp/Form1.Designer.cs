namespace EmailSenderReceiverApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.ListBox lstInbox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.Button btnBrowse;

        private void InitializeComponent()
        {
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.lstInbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFrom
            this.txtFrom.Location = new System.Drawing.Point(12, 12);
            this.txtFrom.Size = new System.Drawing.Size(360, 23);
            this.txtFrom.PlaceholderText = "Email của bạn";
            // 
            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(12, 41);
            this.txtPassword.Size = new System.Drawing.Size(360, 23);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Mật khẩu ứng dụng";
            // 
            // txtTo
            this.txtTo.Location = new System.Drawing.Point(12, 70);
            this.txtTo.Size = new System.Drawing.Size(360, 23);
            this.txtTo.PlaceholderText = "Người nhận";
            // 
            // txtSubject
            this.txtSubject.Location = new System.Drawing.Point(12, 99);
            this.txtSubject.Size = new System.Drawing.Size(360, 23);
            this.txtSubject.PlaceholderText = "Tiêu đề";
            // 
            // txtBody
            this.txtBody.Location = new System.Drawing.Point(12, 128);
            this.txtBody.Multiline = true;
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(360, 100);
            this.txtBody.PlaceholderText = "Nội dung email...";
            // 
            // btnSend
            this.btnSend.Location = new System.Drawing.Point(297, 234);
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            this.btnReceive.Location = new System.Drawing.Point(12, 263);
            this.btnReceive.Size = new System.Drawing.Size(150, 23);
            this.btnReceive.Text = "Nhận Email (IMAP)";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // lstInbox
            this.lstInbox.FormattingEnabled = true;
            this.lstInbox.ItemHeight = 15;
            this.lstInbox.Location = new System.Drawing.Point(12, 292);
            this.lstInbox.Size = new System.Drawing.Size(360, 124);
            // 
            // Form1
            this.ClientSize = new System.Drawing.Size(384, 431);
            this.Controls.Add(this.lstInbox);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFrom);
            this.Text = "Gửi & Nhận Email";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}