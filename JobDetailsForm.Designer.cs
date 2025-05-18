namespace Recruitment
{
    partial class JobDetailsForm
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
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.applybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(39, 38);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(44, 16);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "label1";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(39, 158);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(44, 16);
            this.lblSkills.TabIndex = 2;
            this.lblSkills.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(39, 128);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label1";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(39, 97);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(44, 16);
            this.lblExperience.TabIndex = 4;
            this.lblExperience.Text = "label1";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(39, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(44, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "label1";
            // 
            // applybtn
            // 
            this.applybtn.Location = new System.Drawing.Point(659, 396);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(75, 23);
            this.applybtn.TabIndex = 6;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = true;
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applybtn);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblSalary);
            this.Name = "JobDetailsForm";
            this.Text = "JobDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button applybtn;
    }
}