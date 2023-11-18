namespace курсовая.forms
{
    partial class History
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
            this.listOfRequests = new System.Windows.Forms.DataGridView();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRequestContent = new System.Windows.Forms.TextBox();
            this.txtResponseContent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfRequests
            // 
            this.listOfRequests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listOfRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Topic,
            this.ResponseStatusColumn});
            this.listOfRequests.Location = new System.Drawing.Point(49, 50);
            this.listOfRequests.Margin = new System.Windows.Forms.Padding(4);
            this.listOfRequests.Name = "listOfRequests";
            this.listOfRequests.RowHeadersWidth = 51;
            this.listOfRequests.Size = new System.Drawing.Size(503, 423);
            this.listOfRequests.TabIndex = 0;
            // 
            // Topic
            // 
            this.Topic.DataPropertyName = "Topic";
            this.Topic.HeaderText = "Тема запиту";
            this.Topic.MinimumWidth = 6;
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            this.Topic.Width = 200;
            // 
            // ResponseStatusColumn
            // 
            this.ResponseStatusColumn.DataPropertyName = "Response";
            this.ResponseStatusColumn.HeaderText = "Статус";
            this.ResponseStatusColumn.MinimumWidth = 6;
            this.ResponseStatusColumn.Name = "ResponseStatusColumn";
            this.ResponseStatusColumn.ReadOnly = true;
            this.ResponseStatusColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(592, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Обраний вміст запиту:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(592, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Обраний вміст відповіді на запит:";
            // 
            // txtRequestContent
            // 
            this.txtRequestContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRequestContent.Location = new System.Drawing.Point(595, 99);
            this.txtRequestContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestContent.Multiline = true;
            this.txtRequestContent.Name = "txtRequestContent";
            this.txtRequestContent.Size = new System.Drawing.Size(196, 24);
            this.txtRequestContent.TabIndex = 4;
            // 
            // txtResponseContent
            // 
            this.txtResponseContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResponseContent.Location = new System.Drawing.Point(595, 253);
            this.txtResponseContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponseContent.Name = "txtResponseContent";
            this.txtResponseContent.Size = new System.Drawing.Size(196, 24);
            this.txtResponseContent.TabIndex = 6;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 516);
            this.Controls.Add(this.txtResponseContent);
            this.Controls.Add(this.txtRequestContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfRequests);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.listOfRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRequestContent;
        private System.Windows.Forms.TextBox txtResponseContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponseStatusColumn;
    }
}