using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.Text;

namespace SoftwareEng2024
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnTogglePassword.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnTogglePassword.Text = "Show";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to retrieve the hashed password and memberId from the database
                    string query = @"
                SELECT U.PasswordHash, M.MemberID 
                FROM Users U
                INNER JOIN Members M ON U.UserID = M.UserID
                WHERE U.Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if the query returned a result
                            {
                                string storedPasswordHash = reader["PasswordHash"].ToString();
                                int memberId = Convert.ToInt32(reader["MemberID"]);
                                string inputPasswordHash = HashPassword(password);

                                if (storedPasswordHash == inputPasswordHash)
                                {
                                    MessageBox.Show("Login successful!");

                                    // Pass the MemberID to the Memberdashboard
                                    Memberdashboard memberDashboard = new Memberdashboard(memberId--);
                                    memberDashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display it for debugging
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Redirecting to Forgot Password page.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate to Forgot Password form
            var forgotPassword = new ForgotPassword(); // Ensure ForgotPassword form exists
            forgotPassword.Show();
            this.Hide();
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }

        

        private void lnkReturnToMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
