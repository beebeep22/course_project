namespace курсовая.forms
{
    partial class Settings
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
            this.deleteaccount = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteaccount
            // 
            this.deleteaccount.FlatAppearance.BorderSize = 0;
            this.deleteaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteaccount.ForeColor = System.Drawing.Color.Red;
            this.deleteaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteaccount.Location = new System.Drawing.Point(52, 156);
            this.deleteaccount.Name = "deleteaccount";
            this.deleteaccount.Size = new System.Drawing.Size(164, 38);
            this.deleteaccount.TabIndex = 4;
            this.deleteaccount.Text = "Видалити аккаунт";
            this.deleteaccount.UseVisualStyleBackColor = true;
            this.deleteaccount.Click += new System.EventHandler(this.deleteaccount_Click);
            // 
            // changePassword
            // 
            this.changePassword.FlatAppearance.BorderSize = 0;
            this.changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.changePassword.Location = new System.Drawing.Point(52, 68);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(164, 38);
            this.changePassword.TabIndex = 5;
            this.changePassword.Text = "Змінити пароль";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.deleteaccount);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deleteaccount;
        private System.Windows.Forms.Button changePassword;
    }
}