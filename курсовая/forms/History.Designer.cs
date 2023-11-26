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
            this.requestTopic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfRequests
            // 
            this.listOfRequests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listOfRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestTopic,
            this.ResponseStatus});
            this.listOfRequests.Location = new System.Drawing.Point(37, 41);
            this.listOfRequests.Name = "listOfRequests";
            this.listOfRequests.RowHeadersWidth = 51;
            this.listOfRequests.Size = new System.Drawing.Size(377, 344);
            this.listOfRequests.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(444, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Обраний вміст запиту:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(444, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Обраний вміст відповіді на запит:";
            // 
            // txtRequestContent
            // 
            this.txtRequestContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRequestContent.Location = new System.Drawing.Point(446, 71);
            this.txtRequestContent.Multiline = true;
            this.txtRequestContent.Name = "txtRequestContent";
            this.txtRequestContent.Size = new System.Drawing.Size(148, 32);
            this.txtRequestContent.TabIndex = 4;
            // 
            // txtResponseContent
            // 
            this.txtResponseContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResponseContent.Location = new System.Drawing.Point(446, 206);
            this.txtResponseContent.Multiline = true;
            this.txtResponseContent.Name = "txtResponseContent";
            this.txtResponseContent.Size = new System.Drawing.Size(148, 34);
            this.txtResponseContent.TabIndex = 6;
            // 
            // requestTopic
            // 
            this.requestTopic.DataPropertyName = "Topic";
            this.requestTopic.HeaderText = "Тема запиту";
            this.requestTopic.MinimumWidth = 6;
            this.requestTopic.Name = "requestTopic";
            this.requestTopic.ReadOnly = true;
            this.requestTopic.Width = 200;
            // 
            // ResponseStatus
            // 
            this.ResponseStatus.DataPropertyName = "Response";
            this.ResponseStatus.HeaderText = "Статус";
            this.ResponseStatus.MinimumWidth = 6;
            this.ResponseStatus.Name = "ResponseStatus";
            this.ResponseStatus.ReadOnly = true;
            this.ResponseStatus.Width = 120;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 419);
            this.Controls.Add(this.txtResponseContent);
            this.Controls.Add(this.txtRequestContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfRequests);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn requestTopic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponseStatus;
    }
}