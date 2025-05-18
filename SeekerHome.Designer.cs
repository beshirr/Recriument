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
            this.SuspendLayout();
            // 
            // searchTextHolder
            // 
            this.searchTextHolder.Location = new System.Drawing.Point(192, 73);
            this.searchTextHolder.Name = "searchTextHolder";
            this.searchTextHolder.Size = new System.Drawing.Size(376, 22);
            this.searchTextHolder.TabIndex = 0;
            this.searchTextHolder.Text = "Search by job title, loaction or keywords (e.g. Sales in Cairo)";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(574, 72);
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
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(457, 308);
            this.lstJobs.TabIndex = 2;
            // 
            // SeekerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextHolder);
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
    }
}