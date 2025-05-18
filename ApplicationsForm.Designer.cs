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
            this.aPPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACANCYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNTERVIEWIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSACTIVEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dataGridViewApplications.AutoGenerateColumns = false;
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPPIDDataGridViewTextBoxColumn,
            this.vACANCYIDDataGridViewTextBoxColumn,
            this.iNTERVIEWIDDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.iSACTIVEDataGridViewCheckBoxColumn});
            this.dataGridViewApplications.DataSource = this.aPPLICATIONBindingSource;
            this.dataGridViewApplications.Location = new System.Drawing.Point(34, 56);
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.RowHeadersWidth = 51;
            this.dataGridViewApplications.RowTemplate.Height = 24;
            this.dataGridViewApplications.Size = new System.Drawing.Size(681, 150);
            this.dataGridViewApplications.TabIndex = 0;
            // 
            // aPPIDDataGridViewTextBoxColumn
            // 
            this.aPPIDDataGridViewTextBoxColumn.DataPropertyName = "APP_ID_";
            this.aPPIDDataGridViewTextBoxColumn.HeaderText = "APP_ID_";
            this.aPPIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPPIDDataGridViewTextBoxColumn.Name = "aPPIDDataGridViewTextBoxColumn";
            this.aPPIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPPIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // vACANCYIDDataGridViewTextBoxColumn
            // 
            this.vACANCYIDDataGridViewTextBoxColumn.DataPropertyName = "VACANCYID";
            this.vACANCYIDDataGridViewTextBoxColumn.HeaderText = "VACANCYID";
            this.vACANCYIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vACANCYIDDataGridViewTextBoxColumn.Name = "vACANCYIDDataGridViewTextBoxColumn";
            this.vACANCYIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNTERVIEWIDDataGridViewTextBoxColumn
            // 
            this.iNTERVIEWIDDataGridViewTextBoxColumn.DataPropertyName = "INTERVIEW_ID";
            this.iNTERVIEWIDDataGridViewTextBoxColumn.HeaderText = "INTERVIEW_ID";
            this.iNTERVIEWIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNTERVIEWIDDataGridViewTextBoxColumn.Name = "iNTERVIEWIDDataGridViewTextBoxColumn";
            this.iNTERVIEWIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "_STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "_STATUS";
            this.sTATUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSACTIVEDataGridViewCheckBoxColumn
            // 
            this.iSACTIVEDataGridViewCheckBoxColumn.DataPropertyName = "IS_ACTIVE";
            this.iSACTIVEDataGridViewCheckBoxColumn.HeaderText = "IS_ACTIVE";
            this.iSACTIVEDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.iSACTIVEDataGridViewCheckBoxColumn.Name = "iSACTIVEDataGridViewCheckBoxColumn";
            this.iSACTIVEDataGridViewCheckBoxColumn.Width = 125;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACANCYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTERVIEWIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSACTIVEDataGridViewCheckBoxColumn;
    }
}