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
    public partial class DCM : Form
    {
        public DCM()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ModuleName, Description, ContentURL FROM DigitalContentModules";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Hide the ContentURL column, keeping it for data access but not display
                dataGridView1.Columns["ContentURL"].Visible = false;

                // Add a Button Column for opening URLs
                if (dataGridView1.Columns["OpenURLButton"] == null)
                {
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.HeaderText = "Open Content";
                    buttonColumn.Text = "Go";
                    buttonColumn.Name = "OpenURLButton";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(buttonColumn);
                }

                // Auto-size columns for readability
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    string contentURL = dataGridView1.Rows[e.RowIndex].Cells["ContentURL"].Value?.ToString();

                    if (!string.IsNullOrEmpty(contentURL) && Uri.IsWellFormedUriString(contentURL, UriKind.Absolute))
                    {
                        // Open the URL in the default web browser
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = contentURL,
                            UseShellExecute = true // Ensures compatibility with modern systems
                        });
                    }
                    else
                    {
                        MessageBox.Show("The URL is empty or invalid.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while opening the URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
