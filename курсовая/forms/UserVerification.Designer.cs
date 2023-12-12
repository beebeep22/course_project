namespace курсовая.forms
{
    partial class UserVerification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userVerificationTable = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approve = new System.Windows.Forms.Button();
            this.Disapprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userVerificationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userVerificationTable
            // 
            this.userVerificationTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.userVerificationTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userVerificationTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userVerificationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userVerificationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.fullName,
            this.isApproved});
            this.userVerificationTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userVerificationTable.Location = new System.Drawing.Point(65, 52);
            this.userVerificationTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userVerificationTable.Name = "userVerificationTable";
            this.userVerificationTable.RowHeadersWidth = 51;
            this.userVerificationTable.RowTemplate.Height = 24;
            this.userVerificationTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userVerificationTable.Size = new System.Drawing.Size(647, 434);
            this.userVerificationTable.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "Username";
            this.userName.HeaderText = "Логін";
            this.userName.MinimumWidth = 4;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 125;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "UserDetails";
            this.fullName.HeaderText = "ПІБ";
            this.fullName.MinimumWidth = 8;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 125;
            // 
            // isApproved
            // 
            this.isApproved.DataPropertyName = "UserDetails";
            this.isApproved.HeaderText = "Затверджено";
            this.isApproved.MinimumWidth = 6;
            this.isApproved.Name = "isApproved";
            this.isApproved.ReadOnly = true;
            this.isApproved.Width = 125;
            // 
            // Approve
            // 
            this.Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Approve.Location = new System.Drawing.Point(718, 166);
            this.Approve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(137, 46);
            this.Approve.TabIndex = 1;
            this.Approve.Text = "Підтверджено";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Disapprove
            // 
            this.Disapprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disapprove.Location = new System.Drawing.Point(718, 300);
            this.Disapprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disapprove.Name = "Disapprove";
            this.Disapprove.Size = new System.Drawing.Size(137, 46);
            this.Disapprove.TabIndex = 2;
            this.Disapprove.Text = "Відхилено";
            this.Disapprove.UseVisualStyleBackColor = true;
            this.Disapprove.Click += new System.EventHandler(this.Disapprove_Click);
            // 
            // UserVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 516);
            this.Controls.Add(this.Disapprove);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.userVerificationTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserVerification";
            this.Text = "UserVerification";
            this.Load += new System.EventHandler(this.UserVerification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userVerificationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userVerificationTable;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.Button Disapprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn isApproved;
    }
}