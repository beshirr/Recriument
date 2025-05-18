namespace Recriument
{
    partial class ApplicantsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewApplicants;
        private System.Windows.Forms.Button btnSetInterview;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise.</param>
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewApplicants = new System.Windows.Forms.DataGridView();
            this.btnSetInterview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewApplicants
            // 
            this.dataGridViewApplicants.AllowUserToAddRows = false;
            this.dataGridViewApplicants.AllowUserToDeleteRows = false;
            this.dataGridViewApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplicants.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewApplicants.Name = "dataGridViewApplicants";
            this.dataGridViewApplicants.ReadOnly = true;
            this.dataGridViewApplicants.RowHeadersVisible = false;
            this.dataGridViewApplicants.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewApplicants.TabIndex = 0;
            // 
            // btnSetInterview
            // 
            this.btnSetInterview.Location = new System.Drawing.Point(12, 370);
            this.btnSetInterview.Name = "btnSetInterview";
            this.btnSetInterview.Size = new System.Drawing.Size(150, 30);
            this.btnSetInterview.TabIndex = 1;
            this.btnSetInterview.Text = "Set Interview";
            this.btnSetInterview.UseVisualStyleBackColor = true;
            this.btnSetInterview.Click += new System.EventHandler(this.btnSetInterview_Click);
            // 
            // ApplicantsForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnSetInterview);
            this.Controls.Add(this.dataGridViewApplicants);
            this.Name = "ApplicantsForm";
            this.Text = "Applicants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}