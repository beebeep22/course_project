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
            this.createnotif = new System.Windows.Forms.Button();
            this.reply_request = new System.Windows.Forms.Button();
            this.filterByRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.requestTopic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userRequestsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
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
            this.requestTopic,
            this.responseStatusColumn,
            this.applicantUsername,
            this.applicantRegion});
            this.userRequestsTable.Location = new System.Drawing.Point(41, 61);
            this.userRequestsTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userRequestsTable.Name = "userRequestsTable";
            this.userRequestsTable.RowHeadersWidth = 51;
            this.userRequestsTable.RowTemplate.Height = 24;
            this.userRequestsTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userRequestsTable.Size = new System.Drawing.Size(649, 225);
            this.userRequestsTable.TabIndex = 1;
            // 
            // createnotif
            // 
            this.createnotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createnotif.Location = new System.Drawing.Point(429, 308);
            this.createnotif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createnotif.Name = "createnotif";
            this.createnotif.Size = new System.Drawing.Size(127, 40);
            this.createnotif.TabIndex = 3;
            this.createnotif.Text = "Створити повідомлення";
            this.createnotif.UseVisualStyleBackColor = true;
            this.createnotif.Click += new System.EventHandler(this.createnotif_Click);
            // 
            // reply_request
            // 
            this.reply_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reply_request.Location = new System.Drawing.Point(142, 308);
            this.reply_request.Name = "reply_request";
            this.reply_request.Size = new System.Drawing.Size(130, 40);
            this.reply_request.TabIndex = 2;
            this.reply_request.Text = "Відповісти на запит";
            this.reply_request.UseVisualStyleBackColor = true;
            this.reply_request.Click += new System.EventHandler(this.reply_request_Click);
            // 
            // filterByRegion
            // 
            this.filterByRegion.FormattingEnabled = true;
            this.filterByRegion.Location = new System.Drawing.Point(527, 32);
            this.filterByRegion.Name = "filterByRegion";
            this.filterByRegion.Size = new System.Drawing.Size(121, 21);
            this.filterByRegion.TabIndex = 4;
            this.filterByRegion.SelectedIndexChanged += new System.EventHandler(this.filterByRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фільтр за регіоном";
            // 
            // requestTopic
            // 
            this.requestTopic.DataPropertyName = "Topic";
            this.requestTopic.HeaderText = "Тема запиту";
            this.requestTopic.MinimumWidth = 6;
            this.requestTopic.Name = "requestTopic";
            this.requestTopic.ReadOnly = true;
            this.requestTopic.Width = 160;
            // 
            // responseStatusColumn
            // 
            this.responseStatusColumn.DataPropertyName = "Response";
            this.responseStatusColumn.HeaderText = "Статус";
            this.responseStatusColumn.Name = "responseStatusColumn";
            this.responseStatusColumn.ReadOnly = true;
            // 
            // applicantUsername
            // 
            this.applicantUsername.DataPropertyName = "ApplicantObj";
            this.applicantUsername.HeaderText = "Логін заявника";
            this.applicantUsername.MinimumWidth = 6;
            this.applicantUsername.Name = "applicantUsername";
            this.applicantUsername.ReadOnly = true;
            this.applicantUsername.Width = 125;
            // 
            // applicantRegion
            // 
            this.applicantRegion.DataPropertyName = "ApplicantObj";
            this.applicantRegion.HeaderText = "Регіон заявника";
            this.applicantRegion.MinimumWidth = 6;
            this.applicantRegion.Name = "applicantRegion";
            this.applicantRegion.ReadOnly = true;
            this.applicantRegion.Width = 175;
            // 
            // Zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterByRegion);
            this.Controls.Add(this.createnotif);
            this.Controls.Add(this.reply_request);
            this.Controls.Add(this.userRequestsTable);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name = "Zayavki";
            this.Text = "Zayavki";
            this.Load += new System.EventHandler(this.Zayavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRequestsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userRequestsTable;
        private Button createnotif;
        private Button reply_request;
        private ComboBox filterByRegion;
        private Label label2;
        private DataGridViewTextBoxColumn requestTopic;
        private DataGridViewTextBoxColumn responseStatusColumn;
        private DataGridViewTextBoxColumn applicantUsername;
        private DataGridViewTextBoxColumn applicantRegion;
    }
}