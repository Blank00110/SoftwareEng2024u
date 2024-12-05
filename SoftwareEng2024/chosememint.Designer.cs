namespace SoftwareEng2024
{
    partial class chosememint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbInterests = new System.Windows.Forms.ComboBox();
            this.cmbMembershipType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbMembershipType);
            this.panel1.Controls.Add(this.cmbInterests);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // cmbInterests
            // 
            this.cmbInterests.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbInterests.FormattingEnabled = true;
            this.cmbInterests.Location = new System.Drawing.Point(131, 151);
            this.cmbInterests.Name = "cmbInterests";
            this.cmbInterests.Size = new System.Drawing.Size(167, 24);
            this.cmbInterests.TabIndex = 0;
            // 
            // cmbMembershipType
            // 
            this.cmbMembershipType.FormattingEnabled = true;
            this.cmbMembershipType.Location = new System.Drawing.Point(373, 151);
            this.cmbMembershipType.Name = "cmbMembershipType";
            this.cmbMembershipType.Size = new System.Drawing.Size(316, 24);
            this.cmbMembershipType.TabIndex = 1;
            this.cmbMembershipType.SelectedIndexChanged += new System.EventHandler(this.cmbMembershipType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chosememint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "chosememint";
            this.Text = "chosememint";
            this.Load += new System.EventHandler(this.chosememint_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMembershipType;
        private System.Windows.Forms.ComboBox cmbInterests;
        private System.Windows.Forms.Button button1;
    }
}