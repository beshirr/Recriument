﻿namespace recruitment
{
    partial class VacancyForm
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
            this.dgvVacancies = new System.Windows.Forms.DataGridView();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblJobDescription = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtJobDescription = new System.Windows.Forms.TextBox();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.chkIsVisible = new System.Windows.Forms.CheckBox();
            this.numExperience = new System.Windows.Forms.NumericUpDown();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVacancies
            // 
            this.dgvVacancies.AutoGenerateColumns = true;
            this.dgvVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancies.Location = new System.Drawing.Point(3, 2);
            this.dgvVacancies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVacancies.Name = "dgvVacancies";
            this.dgvVacancies.RowHeadersWidth = 51;
            this.dgvVacancies.RowTemplate.Height = 24;
            this.dgvVacancies.Size = new System.Drawing.Size(679, 210);
            this.dgvVacancies.TabIndex = 0;
            this.dgvVacancies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacancies_CellContentClick);
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(27, 245);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(59, 32);
            this.lblJobTitle.TabIndex = 1;
            this.lblJobTitle.Text = "Job Title\n\n";
            this.lblJobTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.AutoSize = true;
            this.lblJobDescription.Location = new System.Drawing.Point(27, 286);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(98, 16);
            this.lblJobDescription.TabIndex = 2;
            this.lblJobDescription.Text = "JobDescription";
            this.lblJobDescription.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(27, 322);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(39, 16);
            this.lblSkills.TabIndex = 3;
            this.lblSkills.Text = "Skills";
            this.lblSkills.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(27, 359);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(131, 16);
            this.lblExperience.TabIndex = 4;
            this.lblExperience.Text = "Years of  Experience";
            this.lblExperience.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(231, 245);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtJobTitle.TabIndex = 5;
            this.txtJobTitle.TextChanged += new System.EventHandler(this.txtJobTitle_TextChanged);
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.Location = new System.Drawing.Point(231, 286);
            this.txtJobDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJobDescription.Multiline = true;
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.Size = new System.Drawing.Size(100, 22);
            this.txtJobDescription.TabIndex = 6;
            this.txtJobDescription.TextChanged += new System.EventHandler(this.txtJobDescription_TextChanged);
            // 
            // txtSkills
            // 
            this.txtSkills.Location = new System.Drawing.Point(231, 322);
            this.txtSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.Size = new System.Drawing.Size(100, 22);
            this.txtSkills.TabIndex = 7;
            this.txtSkills.TextChanged += new System.EventHandler(this.txtSkills_TextChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(29, 393);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(46, 16);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "Salary";
            this.lblSalary.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkIsVisible
            // 
            this.chkIsVisible.AutoSize = true;
            this.chkIsVisible.Location = new System.Drawing.Point(231, 428);
            this.chkIsVisible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIsVisible.Name = "chkIsVisible";
            this.chkIsVisible.Size = new System.Drawing.Size(83, 20);
            this.chkIsVisible.TabIndex = 10;
            this.chkIsVisible.Text = "Is Visible\t";
            this.chkIsVisible.UseVisualStyleBackColor = true;
            this.chkIsVisible.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numExperience
            // 
            this.numExperience.Location = new System.Drawing.Point(231, 359);
            this.numExperience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numExperience.Name = "numExperience";
            this.numExperience.Size = new System.Drawing.Size(120, 22);
            this.numExperience.TabIndex = 11;
            this.numExperience.ValueChanged += new System.EventHandler(this.numExperience_ValueChanged);
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(231, 390);
            this.numSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(120, 22);
            this.numSalary.TabIndex = 12;
            this.numSalary.ValueChanged += new System.EventHandler(this.numSalary_ValueChanged);
            this.numSalary.Maximum = new decimal(new int[] {
                1000000, 0, 0, 0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(521, 286);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(521, 320);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(521, 353);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(496, 421);
            this.done_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(100, 28);
            this.done_button.TabIndex = 16;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // VacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.numExperience);
            this.Controls.Add(this.chkIsVisible);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSkills);
            this.Controls.Add(this.txtJobDescription);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblJobDescription);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.dgvVacancies);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VacancyForm";
            this.Text = "VacancyForm";
            this.Load += new System.EventHandler(this.VacancyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVacancies;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblJobDescription;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtJobDescription;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.CheckBox chkIsVisible;
        private System.Windows.Forms.NumericUpDown numExperience;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button done_button;
    }
}