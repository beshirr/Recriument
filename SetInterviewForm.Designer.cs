        namespace Recriument
{
    partial class SetInterviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePickerInterview;
        private System.Windows.Forms.Button btnSave;

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
            this.dateTimePickerInterview = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerInterview
            // 
            this.dateTimePickerInterview.Location = new System.Drawing.Point(30, 30);
            this.dateTimePickerInterview.Name = "dateTimePickerInterview";
            this.dateTimePickerInterview.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerInterview.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Interview";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SetInterviewForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 120);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerInterview);
            this.Name = "SetInterviewForm";
            this.Text = "Set Interview";
            this.ResumeLayout(false);
        }

        #endregion
    }
}