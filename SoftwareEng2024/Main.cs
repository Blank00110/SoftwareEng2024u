﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SoftwareEng2024
{
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Navigate to Signup Page
            var signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            AboutUs AboutUsForm = new AboutUs();
            AboutUsForm.Show();


        }
        private string GenerateGuestID()
        {
            string guestID = null;

            try
            {
                // Connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"]?.ConnectionString;

                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("The connection string is missing or incorrect.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the last GuestID and increment it
                    string querySelect = "SELECT TOP 1 GuestID FROM Guests ORDER BY ID DESC";

                    using (SqlCommand commandSelect = new SqlCommand(querySelect, connection))
                    {
                        object result = commandSelect.ExecuteScalar();

                        if (result != null && result.ToString().StartsWith("Guest"))
                        {
                            string lastGuestID = result.ToString();
                            int lastGuestNumber = int.Parse(lastGuestID.Substring(5)); // Extract numeric part
                            guestID = $"Guest{lastGuestNumber + 1}";
                        }
                        else
                        {
                            guestID = "Guest1001"; // Start with Guest1001
                        }
                    }

                    // Insert the new GuestID
                    string queryInsert = "INSERT INTO Guests (GuestID) VALUES (@GuestID)";
                    using (SqlCommand commandInsert = new SqlCommand(queryInsert, connection))
                    {
                        commandInsert.Parameters.AddWithValue("@GuestID", guestID);
                        commandInsert.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guestID = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guestID = null;
            }

            return guestID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
