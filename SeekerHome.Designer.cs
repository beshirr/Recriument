namespace recruitment
{
    partial class SeekerHome
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
            this.searchTextHolder = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.updateInfo_button = new System.Windows.Forms.Button();
            this.btnViewApplications = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTextHolder
            // 
            this.searchTextHolder.Location = new System.Drawing.Point(192, 73);
            this.searchTextHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextHolder.Name = "searchTextHolder";
            this.searchTextHolder.Size = new System.Drawing.Size(376, 22);
            this.searchTextHolder.TabIndex = 0;
            this.searchTextHolder.Text = "Search by job title, loaction or keywords (e.g. Sales in Cairo)";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(573, 71);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // lstJobs
            // 
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 16;
            this.lstJobs.Location = new System.Drawing.Point(192, 113);
            this.lstJobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(457, 308);
            this.lstJobs.TabIndex = 2;
            // 
            // updateInfo_button
            // 
            this.updateInfo_button.Location = new System.Drawing.Point(-1, 0);
            this.updateInfo_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateInfo_button.Name = "updateInfo_button";
            this.updateInfo_button.Size = new System.Drawing.Size(95, 28);
            this.updateInfo_button.TabIndex = 3;
            this.updateInfo_button.Text = "Update info";
            this.updateInfo_button.UseVisualStyleBackColor = true;
            this.updateInfo_button.Click += new System.EventHandler(this.updateInfo_button_Click);
            // 
            // btnViewApplications
            // 
            this.btnViewApplications.Location = new System.Drawing.Point(12, 398);
            this.btnViewApplications.Name = "btnViewApplications";
            this.btnViewApplications.Size = new System.Drawing.Size(138, 23);
            this.btnViewApplications.TabIndex = 4;
            this.btnViewApplications.Text = "Your Applications";
            this.btnViewApplications.UseVisualStyleBackColor = true;
            this.btnViewApplications.Click += new System.EventHandler(this.btnViewApplications_Click);
            // 
            // SeekerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewApplications);
            this.Controls.Add(this.updateInfo_button);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextHolder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SeekerHome";
            this.Text = "SeekerHome";
            this.Load += new System.EventHandler(this.SeekerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextHolder;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.Button updateInfo_button;
        private System.Windows.Forms.Button btnViewApplications;
    }
}