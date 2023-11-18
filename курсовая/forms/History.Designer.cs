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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRequestContent = new System.Windows.Forms.TextBox();
            this.txtResponseContent = new System.Windows.Forms.TextBox();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfRequests
            // 
            this.listOfRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Topic,
            this.ResponseStatusColumn});
            this.listOfRequests.Location = new System.Drawing.Point(53, 41);
            this.listOfRequests.Name = "listOfRequests";
            this.listOfRequests.Size = new System.Drawing.Size(343, 339);
            this.listOfRequests.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected request content:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected request response content:";
            // 
            // txtRequestContent
            // 
            this.txtRequestContent.Location = new System.Drawing.Point(519, 141);
            this.txtRequestContent.Name = "txtRequestContent";
            this.txtRequestContent.Size = new System.Drawing.Size(100, 20);
            this.txtRequestContent.TabIndex = 4;
            // 
            // txtResponseContent
            // 
            this.txtResponseContent.Location = new System.Drawing.Point(519, 290);
            this.txtResponseContent.Name = "txtResponseContent";
            this.txtResponseContent.Size = new System.Drawing.Size(100, 20);
            this.txtResponseContent.TabIndex = 6;
            // 
            // Topic
            // 
            this.Topic.DataPropertyName = "Topic";
            this.Topic.HeaderText = "Request topic";
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            this.Topic.Width = 200;
            // 
            // ResponseStatusColumn
            // 
            this.ResponseStatusColumn.DataPropertyName = "Response";
            this.ResponseStatusColumn.HeaderText = "Status";
            this.ResponseStatusColumn.Name = "ResponseStatusColumn";
            this.ResponseStatusColumn.ReadOnly = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResponseContent);
            this.Controls.Add(this.txtRequestContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfRequests);
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