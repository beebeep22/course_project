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
            ((System.ComponentModel.ISupportInitialize)(this.NotReadRespondedRequestsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // NotReadRespondedRequestsTable
            // 
            this.NotReadRespondedRequestsTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.NotReadRespondedRequestsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotReadRespondedRequestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotReadRespondedRequestsTable.Location = new System.Drawing.Point(43, 44);
            this.NotReadRespondedRequestsTable.Name = "NotReadRespondedRequestsTable";
            this.NotReadRespondedRequestsTable.RowHeadersWidth = 51;
            this.NotReadRespondedRequestsTable.RowTemplate.Height = 24;
            this.NotReadRespondedRequestsTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NotReadRespondedRequestsTable.Size = new System.Drawing.Size(352, 393);
            this.NotReadRespondedRequestsTable.TabIndex = 0;
            // 
            // NotificationsTable
            // 
            this.NotificationsTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.NotificationsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotificationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotificationsTable.Location = new System.Drawing.Point(464, 44);
            this.NotificationsTable.Name = "NotificationsTable";
            this.NotificationsTable.RowHeadersWidth = 51;
            this.NotificationsTable.RowTemplate.Height = 24;
            this.NotificationsTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NotificationsTable.Size = new System.Drawing.Size(352, 393);
            this.NotificationsTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Відповіді на заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(461, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Повідомлення";
            // 
            // Message_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(864, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotificationsTable);
            this.Controls.Add(this.NotReadRespondedRequestsTable);
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
    }
}