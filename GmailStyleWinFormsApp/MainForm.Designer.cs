namespace GmailStyleWinFormsApp
{
    partial class MainForm
    {
        public partial class MainForm : Form
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();

            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));

            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F)); // txtFrom
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F)); // txtPassword
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F)); // txtTo
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F)); // txtSubject
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F)); // txtBody
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F)); // Buttons
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F)); // lstInbox
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F)); // txtEmailDetail
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F)); // padding bottom

            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);

            //
            // txtFrom
            //
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Controls.Add(this.txtFrom, 0, 0);
            this.tableLayoutPanel.SetColumnSpan(this.txtFrom, 3);

            //
            // txtPassword
            //
            this.txtPassword.ReadOnly = true;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Controls.Add(this.txtPassword, 0, 1);
            this.tableLayoutPanel.SetColumnSpan(this.txtPassword, 3);

            //
            // txtTo
            //
            this.txtTo.PlaceholderText = "Địa chỉ người nhận";
            this.txtTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Controls.Add(this.txtTo, 0, 2);
            this.tableLayoutPanel.SetColumnSpan(this.txtTo, 3);

            //
            // txtSubject
            //
            this.txtSubject.PlaceholderText = "Tiêu đề email";
            this.txtSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Controls.Add(this.txtSubject, 0, 3);
            this.tableLayoutPanel.SetColumnSpan(this.txtSubject, 3);

            //
            // txtBody
            //
            this.txtBody.Multiline = true;
            this.txtBody.PlaceholderText = "Soạn nội dung email...";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Controls.Add(this.txtBody, 0, 4);
            this.tableLayoutPanel.SetColumnSpan(this.txtBody, 3);

            //
            // Buttons
            //
            this.btnAttach.Text = "📎 Đính kèm";
            this.btnSend.Text = "✉️ Gửi";
            this.btnReceive.Text = "📥 Nhận Email";

            this.btnAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReceive.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);

            this.tableLayoutPanel.Controls.Add(this.btnAttach, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.btnSend, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.btnReceive, 2, 5);

            //
            // lstInbox
            //
            this.lstInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInbox.SelectedIndexChanged += new System.EventHandler(this.lstInbox_SelectedIndexChanged);
            this.tableLayoutPanel.Controls.Add(this.lstInbox, 0, 6);
            this.tableLayoutPanel.SetColumnSpan(this.lstInbox, 3);

            //
            // txtEmailDetail
            //
            this.txtEmailDetail.Multiline = true;
            this.txtEmailDetail.ReadOnly = true;
            this.txtEmailDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Controls.Add(this.txtEmailDetail, 0, 7);
            this.tableLayoutPanel.SetColumnSpan(this.txtEmailDetail, 3);

            //
            // MainForm
            //
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Gửi & Nhận Email - Gmail Style";

            this.ResumeLayout(true);
            this.PerformLayout();
        }
    }
}
