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
            this.patronymic.Location = new System.Drawing.Point(291, 133);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(151, 22);
            this.patronymic.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(291, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 22);
            this.name.TabIndex = 5;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(291, 26);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(151, 22);
            this.surname.TabIndex = 4;
            // 
            // avatarka
            // 
            this.avatarka.Image = global::курсовая.Properties.Resources.user3;
            this.avatarka.Location = new System.Drawing.Point(61, 26);
            this.avatarka.Name = "avatarka";
            this.avatarka.Size = new System.Drawing.Size(150, 149);
            this.avatarka.TabIndex = 7;
            this.avatarka.UseVisualStyleBackColor = true;
            // 
            // Account_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avatarka);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
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