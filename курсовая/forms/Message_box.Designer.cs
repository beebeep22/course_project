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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NotReadRespondedRequestsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // NotReadRespondedRequestsTable
            // 
            this.NotReadRespondedRequestsTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.NotReadRespondedRequestsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotReadRespondedRequestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotReadRespondedRequestsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Topic,
            this.responseStatus});
            this.NotReadRespondedRequestsTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotReadRespondedRequestsTable.Location = new System.Drawing.Point(32, 36);
            this.NotReadRespondedRequestsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NotReadRespondedRequestsTable.Name = "NotReadRespondedRequestsTable";
            this.NotReadRespondedRequestsTable.RowHeadersWidth = 51;
            this.NotReadRespondedRequestsTable.RowTemplate.Height = 24;
            this.NotReadRespondedRequestsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotReadRespondedRequestsTable.Size = new System.Drawing.Size(252, 319);
            this.NotReadRespondedRequestsTable.TabIndex = 0;
            // 
            // NotificationsTable
            // 
            this.NotificationsTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.NotificationsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotificationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotificationsTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotificationsTable.Location = new System.Drawing.Point(348, 36);
            this.NotificationsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NotificationsTable.Name = "NotificationsTable";
            this.NotificationsTable.RowHeadersWidth = 51;
            this.NotificationsTable.RowTemplate.Height = 24;
            this.NotificationsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotificationsTable.Size = new System.Drawing.Size(264, 319);
            this.NotificationsTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Відповіді на заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(346, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Повідомлення";
            // 
            // Topic
            // 
            this.Topic.DataPropertyName = "Topic";
            this.Topic.HeaderText = "Тема";
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            // 
            // responseStatus
            // 
            this.responseStatus.DataPropertyName = "Response";
            this.responseStatus.HeaderText = "Статус";
            this.responseStatus.Name = "responseStatus";
            this.responseStatus.ReadOnly = true;
            // 
            // Message_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(648, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotificationsTable);
            this.Controls.Add(this.NotReadRespondedRequestsTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Message_box";
            this.Text = "Message_box";
            this.Load += new System.EventHandler(this.Message_box_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotReadRespondedRequestsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NotReadRespondedRequestsTable;
        private System.Windows.Forms.DataGridView NotificationsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseStatus;
    }
}