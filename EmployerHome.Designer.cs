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
            this.addVacancy_button.Location = new System.Drawing.Point(281, 167);
            this.addVacancy_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addVacancy_button.Name = "addVacancy_button";
            this.addVacancy_button.Size = new System.Drawing.Size(168, 66);
            this.addVacancy_button.TabIndex = 0;
            this.addVacancy_button.Text = "Add Vacany";
            this.addVacancy_button.UseVisualStyleBackColor = false;
            this.addVacancy_button.Click += new System.EventHandler(this.addVacancy_button_Click);
            // 
            // BtnViewApplicants
            // 
            this.BtnViewApplicants.Location = new System.Drawing.Point(891, 92);
            this.BtnViewApplicants.Name = "BtnViewApplicants";
            this.BtnViewApplicants.Size = new System.Drawing.Size(127, 23);
            this.BtnViewApplicants.TabIndex = 1;
            this.BtnViewApplicants.Text = "View Applicants";
            this.BtnViewApplicants.UseVisualStyleBackColor = true;
            this.BtnViewApplicants.Click += new System.EventHandler(this.BtnViewApplicants_Click);
            // 
            // EmployerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnViewApplicants);
            this.Controls.Add(this.addVacancy_button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployerHome";
            this.Text = "EmployerHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVacancy_button;
        private System.Windows.Forms.Button BtnViewApplicants;
    }
}