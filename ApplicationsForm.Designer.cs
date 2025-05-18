namespace Recriument
{
    partial class ApplicationsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.aPPLICATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recruitmentDataSet = new Recriument.recruitmentDataSet();
            this.aPPLICATIONTableAdapter = new Recriument.recruitmentDataSetTableAdapters.APPLICATIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewApplications
            // 
            this.dataGridViewApplications.AutoGenerateColumns = true;
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.DataSource = this.aPPLICATIONBindingSource;
            this.dataGridViewApplications.Location = new System.Drawing.Point(34, 56);
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.RowHeadersWidth = 51;
            this.dataGridViewApplications.RowTemplate.Height = 24;
            this.dataGridViewApplications.Size = new System.Drawing.Size(681, 150);
            this.dataGridViewApplications.TabIndex = 0;
            this.dataGridViewApplications.Columns.Clear();
            // 
            // aPPLICATIONBindingSource
            // 
            this.aPPLICATIONBindingSource.DataMember = "APPLICATION";
            this.aPPLICATIONBindingSource.DataSource = this.recruitmentDataSet;
            // 
            // recruitmentDataSet
            // 
            this.recruitmentDataSet.DataSetName = "recruitmentDataSet";
            this.recruitmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPLICATIONTableAdapter
            // 
            this.aPPLICATIONTableAdapter.ClearBeforeFill = true;
            // 
            // ApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewApplications);
            this.Name = "ApplicationsForm";
            this.Text = "ApplicationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewApplications;
        private recruitmentDataSet recruitmentDataSet;
        private System.Windows.Forms.BindingSource aPPLICATIONBindingSource;
        private recruitmentDataSetTableAdapters.APPLICATIONTableAdapter aPPLICATIONTableAdapter;
    }
}