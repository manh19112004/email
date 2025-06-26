using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmailSenderReceiverApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtFrom;
        private TextBox txtPassword;
        private TextBox txtTo;
        private TextBox txtSubject;
        private TextBox txtBody;
        private Button btnSend;
        private Button btnReceive;
        private Button btnAttach;
        private ListBox lstInbox;
        private TextBox txtEmailDetail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            Font defaultFont = new Font("Segoe UI", 10F);
            int margin = 10;
            int width = 360;

            txtFrom = new TextBox();
            txtPassword = new TextBox();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            txtBody = new TextBox();
            btnSend = new Button();
            btnAttach = new Button();
            btnReceive = new Button();
            lstInbox = new ListBox();
            txtEmailDetail = new TextBox();

            // txtFrom
            txtFrom.Font = defaultFont;
            txtFrom.Location = new Point(margin, 20);
            txtFrom.Size = new Size(width, 27);
            txtFrom.PlaceholderText = "Địa chỉ Gmail của bạn";
            txtFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // txtPassword
            txtPassword.Font = defaultFont;
            txtPassword.Location = new Point(margin, 55);
            txtPassword.Size = new Size(width, 27);
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Mật khẩu ứng dụng Gmail";
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // txtTo
            txtTo.Font = defaultFont;
            txtTo.Location = new Point(margin, 90);
            txtTo.Size = new Size(width, 27);
            txtTo.PlaceholderText = "Địa chỉ người nhận";
            txtTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // txtSubject
            txtSubject.Font = defaultFont;
            txtSubject.Location = new Point(margin, 125);
            txtSubject.Size = new Size(width, 27);
            txtSubject.PlaceholderText = "Tiêu đề email";
            txtSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // txtBody
            txtBody.Font = defaultFont;
            txtBody.Location = new Point(margin, 160);
            txtBody.Size = new Size(width, 100);
            txtBody.Multiline = true;
            txtBody.ScrollBars = ScrollBars.Vertical;
            txtBody.PlaceholderText = "Soạn nội dung email...";
            txtBody.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // btnAttach
            btnAttach.Font = defaultFont;
            btnAttach.Location = new Point(margin, 270);
            btnAttach.Size = new Size(130, 30);
            btnAttach.Text = "📎 Đính kèm";
            btnAttach.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnAttach.Click += new EventHandler(this.btnAttach_Click);

            // btnSend
            btnSend.Font = defaultFont;
            btnSend.Location = new Point(150, 270);
            btnSend.Size = new Size(100, 30);
            btnSend.Text = "✉️ Gửi";
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Click += new EventHandler(this.btnSend_Click);

            // btnReceive
            btnReceive.Font = defaultFont;
            btnReceive.Location = new Point(260, 270);
            btnReceive.Size = new Size(110, 30);
            btnReceive.Text = "📥 Nhận";
            btnReceive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReceive.Click += new EventHandler(this.btnReceive_Click);

            // lstInbox
            lstInbox.Font = new Font("Segoe UI", 9F);
            lstInbox.Location = new Point(margin, 310);
            lstInbox.Size = new Size(width, 100);
            lstInbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstInbox.SelectedIndexChanged += new EventHandler(this.lstInbox_SelectedIndexChanged);

            // txtEmailDetail
            txtEmailDetail.Font = new Font("Segoe UI", 9F);
            txtEmailDetail.Location = new Point(margin, 420);
            txtEmailDetail.Size = new Size(width, 120);
            txtEmailDetail.Multiline = true;
            txtEmailDetail.ReadOnly = true;
            txtEmailDetail.ScrollBars = ScrollBars.Vertical;
            txtEmailDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // Form
            this.Text = "Gmail Style - Gửi & Nhận Email";
            this.ClientSize = new Size(400, 580);
            this.MinimumSize = new Size(400, 580);
            this.Controls.AddRange(new Control[] {
                txtFrom, txtPassword, txtTo, txtSubject, txtBody,
                btnAttach, btnSend, btnReceive,
                lstInbox, txtEmailDetail
            });
        }
    }
}
