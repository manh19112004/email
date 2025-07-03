using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GmailStyleWinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadLastLogin(); // Tự động load tài khoản đăng nhập gần nhất
        }
        private void SaveLoginInfo(string email, string password)
        {
            string connectionString = "Server=localhost;Database=GmailApp;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO UserAccounts (Email, Password) VALUES (@Email, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void LoadLastLogin()
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=GmailApp;Integrated Security=True";
                string connectionString = "Data Source=localhost;Initial Catalog=GmailApp;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 Email, Password FROM UserAccounts ORDER BY Id DESC", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtEmail.Text = reader.GetString(0);
                        txtPassword.Text = reader.GetString(1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải tài khoản đã lưu: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.");
                return;
            }

            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=GmailApp;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO UserAccounts (Email, Password) VALUES (@Email, @Password)", con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                }

                MainForm mainForm = new MainForm(email, password);
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
        }
    }
}
