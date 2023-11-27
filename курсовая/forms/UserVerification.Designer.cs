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
            this.userVerificationTable = new System.Windows.Forms.DataGridView();
            this.userlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approve = new System.Windows.Forms.Button();
            this.Disapprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userVerificationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userVerificationTable
            // 
            this.userVerificationTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.userVerificationTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userVerificationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userVerificationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userlogin,
            this.PIB,
            this.Approved});
            this.userVerificationTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userVerificationTable.Location = new System.Drawing.Point(38, 51);
            this.userVerificationTable.Name = "userVerificationTable";
            this.userVerificationTable.RowHeadersWidth = 52;
            this.userVerificationTable.RowTemplate.Height = 25;
            this.userVerificationTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userVerificationTable.Size = new System.Drawing.Size(677, 434);
            this.userVerificationTable.TabIndex = 1;
            // 
            // userlogin
            // 
            this.userlogin.HeaderText = "user";
            this.userlogin.MinimumWidth = 5;
            this.userlogin.Name = "userlogin";
            this.userlogin.Width = 126;
            // 
            // PIB
            // 
            this.PIB.HeaderText = "ПІБ";
            this.PIB.MinimumWidth = 9;
            this.PIB.Name = "PIB";
            this.PIB.Width = 126;
            // 
            // Approved
            // 
            this.Approved.HeaderText = "Затверджено";
            this.Approved.MinimumWidth = 7;
            this.Approved.Name = "Approved";
            this.Approved.Width = 126;
            // 
            // Approve
            // 
            this.Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Approve.Location = new System.Drawing.Point(733, 180);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(138, 46);
            this.Approve.TabIndex = 2;
            this.Approve.Text = "Підтверджено";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Disapprove
            // 
            this.Disapprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disapprove.Location = new System.Drawing.Point(733, 314);
            this.Disapprove.Name = "Disapprove";
            this.Disapprove.Size = new System.Drawing.Size(138, 45);
            this.Disapprove.TabIndex = 3;
            this.Disapprove.Text = "Відхилено";
            this.Disapprove.UseVisualStyleBackColor = true;
            this.Disapprove.Click += new System.EventHandler(this.Disapprove_Click);
            // 
            // UserVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 516);
            this.Controls.Add(this.Disapprove);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.userVerificationTable);
            this.Name = "UserVerification";
            this.Text = "UserVerification";
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