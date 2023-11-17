namespace курсовая.forms
{
    partial class Account_admin
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
            this.patronymic = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.avatarka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(218, 108);
            this.patronymic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(114, 20);
            this.patronymic.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(218, 63);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(114, 20);
            this.name.TabIndex = 5;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(218, 21);
            this.surname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(114, 20);
            this.surname.TabIndex = 4;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // avatarka
            // 
            this.avatarka.Image = global::курсовая.Properties.Resources.user3;
            this.avatarka.Location = new System.Drawing.Point(46, 21);
            this.avatarka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avatarka.Name = "avatarka";
            this.avatarka.Size = new System.Drawing.Size(112, 121);
            this.avatarka.TabIndex = 7;
            this.avatarka.UseVisualStyleBackColor = true;
            // 
            // Account_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.avatarka);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Account_admin";
            this.Text = "Account_admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Button avatarka;
    }
}