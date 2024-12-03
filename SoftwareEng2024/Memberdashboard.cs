using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEng2024
{
    public partial class Memberdashboard : Form
    {
        public Memberdashboard()
        {
            InitializeComponent();
        }

        private void CONBTN_Click(object sender, EventArgs e)
        {
            // Create an instance of the DCM form
            DCM dcmForm = new DCM();

            // Show the DCM form
            dcmForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Return to Main page
            var mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void ChatBox_Button_Click(object sender, EventArgs e)
        {
            var chatboxForm = new Form1();
            chatboxForm.Show();
            this.Hide();
        }
    }
}
