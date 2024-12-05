namespace SoftwareEng2024
{
    partial class MyBenefits
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
            this.benefitsView = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.benefitsView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 511);
            this.panel1.TabIndex = 0;
            // 
            // benefitsView
            // 
            this.benefitsView.BackColor = System.Drawing.Color.IndianRed;
            this.benefitsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.benefitsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benefitsView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.benefitsView.Location = new System.Drawing.Point(0, 0);
            this.benefitsView.Name = "benefitsView";
            this.benefitsView.Size = new System.Drawing.Size(859, 511);
            this.benefitsView.TabIndex = 0;
            // 
            // MyBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 511);
            this.Controls.Add(this.panel1);
            this.Name = "MyBenefits";
            this.Text = "MyBenefits";
            this.Load += new System.EventHandler(this.MyBenefits_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView benefitsView;
    }
}