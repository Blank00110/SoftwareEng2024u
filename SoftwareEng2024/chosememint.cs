using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEng2024
{
    public partial class chosememint : Form
    {
        public chosememint()
        {
            InitializeComponent();
        }

        private void chosememint_Load(object sender, EventArgs e)
        {
            PopulateInterestComboBox();
            PopulateMembershipTypeComboBox();

        }
        private void PopulateMembershipTypeComboBox()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MembershipTypeID, TypeName FROM MembershipTypes";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbMembershipType.DataSource = dataTable;
                        cmbMembershipType.DisplayMember = "TypeName"; // Text to display
                        cmbMembershipType.ValueMember = "MembershipTypeID"; // Corresponding value
                        cmbMembershipType.SelectedIndex = -1; // Optional: Set default to empty
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading membership types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateInterestComboBox()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT InterestID, InterestName FROM Interests";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbInterests.DataSource = dataTable;
                        cmbInterests.DisplayMember = "InterestName"; // Text to display
                        cmbInterests.ValueMember = "InterestID"; // Corresponding value
                        cmbInterests.SelectedIndex = -1; // Optional: Set default to empty
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading interests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
