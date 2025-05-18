namespace Recriument
{
    partial class EmployerHome
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
            this.addVacancy_button = new System.Windows.Forms.Button();
            this.BtnViewApplicants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVacancy_button
            // 
            this.addVacancy_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addVacancy_button.Location = new System.Drawing.Point(263, 199);
            this.addVacancy_button.Name = "addVacancy_button";
            this.addVacancy_button.Size = new System.Drawing.Size(126, 54);
            this.addVacancy_button.TabIndex = 0;
            this.addVacancy_button.Text = "Add Vacany";
            this.addVacancy_button.UseVisualStyleBackColor = false;
            this.addVacancy_button.Click += new System.EventHandler(this.addVacancy_button_Click);
            // 
            // BtnViewApplicants
            // 
            this.BtnViewApplicants.Location = new System.Drawing.Point(394, 199);
            this.BtnViewApplicants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnViewApplicants.Name = "BtnViewApplicants";
            this.BtnViewApplicants.Size = new System.Drawing.Size(128, 54);
            this.BtnViewApplicants.TabIndex = 1;
            this.BtnViewApplicants.Text = "View Applicants";
            this.BtnViewApplicants.UseVisualStyleBackColor = true;
            this.BtnViewApplicants.Click += new System.EventHandler(this.BtnViewApplicants_Click);
            // 
            // EmployerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnViewApplicants);
            this.Controls.Add(this.addVacancy_button);
            this.Name = "EmployerHome";
            this.Text = "EmployerHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVacancy_button;
        private System.Windows.Forms.Button BtnViewApplicants;
    }
}