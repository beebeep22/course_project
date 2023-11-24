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
            this.avatar_admin = new System.Windows.Forms.PictureBox();
            this.avatarka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(291, 133);
            this.patronymic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(151, 22);
            this.patronymic.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(291, 78);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 22);
            this.name.TabIndex = 5;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(291, 26);
            this.surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(151, 22);
            this.surname.TabIndex = 4;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // avatar_admin
            // 
            this.avatar_admin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.avatar_admin.BackgroundImage = global::курсовая.Properties.Resources.user64;
            this.avatar_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.avatar_admin.Location = new System.Drawing.Point(70, 26);
            this.avatar_admin.Name = "avatar_admin";
            this.avatar_admin.Size = new System.Drawing.Size(136, 145);
            this.avatar_admin.TabIndex = 47;
            this.avatar_admin.TabStop = false;
            // 
            // avatarka
            // 
            this.avatarka.FlatAppearance.BorderSize = 0;
            this.avatarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avatarka.ForeColor = System.Drawing.SystemColors.Highlight;
            this.avatarka.Location = new System.Drawing.Point(70, 170);
            this.avatarka.Name = "avatarka";
            this.avatarka.Size = new System.Drawing.Size(136, 28);
            this.avatarka.TabIndex = 46;
            this.avatarka.Text = "Змінити фото";
            this.avatarka.UseVisualStyleBackColor = true;
            this.avatarka.Click += new System.EventHandler(this.avatarka_Click);
            // 
            // Account_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avatar_admin);
            this.Controls.Add(this.avatarka);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account_admin";
            this.Text = "Account_admin";
            ((System.ComponentModel.ISupportInitialize)(this.avatar_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.PictureBox avatar_admin;
        private System.Windows.Forms.Button avatarka;
    }
}