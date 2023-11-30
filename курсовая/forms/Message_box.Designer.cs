namespace курсовая.forms
{
    partial class Message_box
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
            this.NotReadRespondedRequestsTable = new System.Windows.Forms.DataGridView();
            this.NotificationsTable = new System.Windows.Forms.DataGridView();
            this.topicResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NotReadRespondedRequestsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // NotReadRespondedRequestsTable
            // 
            this.NotReadRespondedRequestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotReadRespondedRequestsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topicResponse,
            this.status});
            this.NotReadRespondedRequestsTable.Location = new System.Drawing.Point(43, 44);
            this.NotReadRespondedRequestsTable.Name = "NotReadRespondedRequestsTable";
            this.NotReadRespondedRequestsTable.RowHeadersWidth = 51;
            this.NotReadRespondedRequestsTable.RowTemplate.Height = 24;
            this.NotReadRespondedRequestsTable.Size = new System.Drawing.Size(337, 393);
            this.NotReadRespondedRequestsTable.TabIndex = 0;
            // 
            // NotificationsTable
            // 
            this.NotificationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotificationsTable.Location = new System.Drawing.Point(480, 44);
            this.NotificationsTable.Name = "NotificationsTable";
            this.NotificationsTable.RowHeadersWidth = 51;
            this.NotificationsTable.RowTemplate.Height = 24;
            this.NotificationsTable.Size = new System.Drawing.Size(337, 393);
            this.NotificationsTable.TabIndex = 1;
            // 
            // topicResponse
            // 
            this.topicResponse.HeaderText = "Тема заявки";
            this.topicResponse.MinimumWidth = 6;
            this.topicResponse.Name = "topicResponse";
            this.topicResponse.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // Message_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 516);
            this.Controls.Add(this.NotificationsTable);
            this.Controls.Add(this.NotReadRespondedRequestsTable);
            this.Name = "Message_box";
            this.Text = "Message_box";
            this.Load += new System.EventHandler(this.Message_box_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotReadRespondedRequestsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NotReadRespondedRequestsTable;
        private System.Windows.Forms.DataGridView NotificationsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}