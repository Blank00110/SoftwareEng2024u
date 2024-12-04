namespace SoftwareEng2024
{
    partial class Profile
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblinterest = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblmembershiptype = new System.Windows.Forms.Label();
            this.lbljoindate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lbljoindate);
            this.panel1.Controls.Add(this.lblmembershiptype);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblinterest);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 473);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(37, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "PROFILE";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.IndianRed;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(38, 98);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 25);
            this.lblname.TabIndex = 18;
            this.lblname.Text = "NAME";
            // 
            // lblinterest
            // 
            this.lblinterest.AutoSize = true;
            this.lblinterest.BackColor = System.Drawing.Color.IndianRed;
            this.lblinterest.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblinterest.Location = new System.Drawing.Point(39, 150);
            this.lblinterest.Name = "lblinterest";
            this.lblinterest.Size = new System.Drawing.Size(96, 25);
            this.lblinterest.TabIndex = 19;
            this.lblinterest.Text = "INTEREST";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.IndianRed;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblemail.Location = new System.Drawing.Point(39, 206);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(67, 25);
            this.lblemail.TabIndex = 20;
            this.lblemail.Text = "EMAIL";
            // 
            // lblmembershiptype
            // 
            this.lblmembershiptype.AutoSize = true;
            this.lblmembershiptype.BackColor = System.Drawing.Color.IndianRed;
            this.lblmembershiptype.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembershiptype.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmembershiptype.Location = new System.Drawing.Point(39, 261);
            this.lblmembershiptype.Name = "lblmembershiptype";
            this.lblmembershiptype.Size = new System.Drawing.Size(179, 25);
            this.lblmembershiptype.TabIndex = 21;
            this.lblmembershiptype.Text = "MEMBERSHIP TYPE";
            // 
            // lbljoindate
            // 
            this.lbljoindate.AutoSize = true;
            this.lbljoindate.BackColor = System.Drawing.Color.IndianRed;
            this.lbljoindate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljoindate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbljoindate.Location = new System.Drawing.Point(38, 309);
            this.lbljoindate.Name = "lbljoindate";
            this.lbljoindate.Size = new System.Drawing.Size(105, 25);
            this.lbljoindate.TabIndex = 22;
            this.lbljoindate.Text = "JOIN DATE";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 473);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbljoindate;
        private System.Windows.Forms.Label lblmembershiptype;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblinterest;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label3;
    }
}