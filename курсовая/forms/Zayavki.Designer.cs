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
            this.application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createnotif = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userRequestsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхідні заявки";
            // 
            // userRequestsTable
            // 
            this.userRequestsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userRequestsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userRequestsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userRequestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userRequestsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.application,
            this.ResponseStatusColumn,
            this.applicantName});
            this.userRequestsTable.Location = new System.Drawing.Point(65, 68);
            this.userRequestsTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userRequestsTable.Name = "userRequestsTable";
            this.userRequestsTable.RowHeadersWidth = 51;
            this.userRequestsTable.RowTemplate.Height = 24;
            this.userRequestsTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userRequestsTable.Size = new System.Drawing.Size(701, 277);
            this.userRequestsTable.TabIndex = 1;
            this.userRequestsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userRequestsTable_CellContentClick);
            // 
            // application
            // 
            this.application.DataPropertyName = "Topic";
            this.application.HeaderText = "Тема запиту";
            this.application.MinimumWidth = 6;
            this.application.Name = "application";
            this.application.Width = 150;
            // 
            // ResponseStatusColumn
            // 
            this.ResponseStatusColumn.DataPropertyName = "Response";
            this.ResponseStatusColumn.HeaderText = "Статус";
            this.ResponseStatusColumn.MinimumWidth = 6;
            this.ResponseStatusColumn.Name = "ResponseStatusColumn";
            this.ResponseStatusColumn.Width = 125;
            // 
            // applicantName
            // 
            this.applicantName.DataPropertyName = "ApplicantObj";
            this.applicantName.HeaderText = "Ім\'я заявника";
            this.applicantName.MinimumWidth = 6;
            this.applicantName.Name = "applicantName";
            this.applicantName.ReadOnly = true;
            this.applicantName.Width = 150;
            // 
            // createnotif
            // 
            this.createnotif.Location = new System.Drawing.Point(597, 372);
            this.createnotif.Name = "createnotif";
            this.createnotif.Size = new System.Drawing.Size(169, 49);
            this.createnotif.TabIndex = 3;
            this.createnotif.Text = "Створення повідомлення";
            this.createnotif.UseVisualStyleBackColor = true;
            this.createnotif.Click += new System.EventHandler(this.createnotif_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(343, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Відповісти на запит";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createnotif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userRequestsTable);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name = "Zayavki";
            this.Text = "Zayavki";
            ((System.ComponentModel.ISupportInitialize)(this.userRequestsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userRequestsTable;
        private DataGridViewTextBoxColumn application;
        private DataGridViewTextBoxColumn ResponseStatusColumn;
        private DataGridViewTextBoxColumn applicantName;
        private Button createnotif;
        private Button button1;
    }
}