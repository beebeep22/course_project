using System.Drawing;
using System.Windows.Forms;

namespace курсовая.forms
{
    partial class Zayavki
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
            this.label1 = new System.Windows.Forms.Label();
            this.userRequestsTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userRequestsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус заявок";
            // 
            // userRequestsTable
            // 
            this.userRequestsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userRequestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userRequestsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.application,
            this.ResponseStatusColumn,
            this.applicantName});
            this.userRequestsTable.Location = new System.Drawing.Point(49, 81);
            this.userRequestsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userRequestsTable.Name = "userRequestsTable";
            this.userRequestsTable.RowHeadersWidth = 51;
            this.userRequestsTable.RowTemplate.Height = 24;
            this.userRequestsTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userRequestsTable.Size = new System.Drawing.Size(504, 198);
            this.userRequestsTable.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Respond on selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // application
            // 
            this.application.DataPropertyName = "Topic";
            this.application.HeaderText = "Request topic";
            this.application.MinimumWidth = 6;
            this.application.Name = "application";
            this.application.Width = 125;
            // 
            // ResponseStatusColumn
            // 
            this.ResponseStatusColumn.DataPropertyName = "Response";
            this.ResponseStatusColumn.HeaderText = "Status";
            this.ResponseStatusColumn.MinimumWidth = 6;
            this.ResponseStatusColumn.Name = "ResponseStatusColumn";
            this.ResponseStatusColumn.Width = 125;
            // 
            // applicantName
            // 
            this.applicantName.DataPropertyName = "ApplicantObj";
            this.applicantName.HeaderText = "Applicant Name";
            this.applicantName.Name = "applicantName";
            this.applicantName.ReadOnly = true;
            // 
            // Zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userRequestsTable);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Zayavki";
            this.Text = "Zayavki";
            ((System.ComponentModel.ISupportInitialize)(this.userRequestsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userRequestsTable;
        private Button button1;
        private DataGridViewTextBoxColumn application;
        private DataGridViewTextBoxColumn ResponseStatusColumn;
        private DataGridViewTextBoxColumn applicantName;
    }
}