namespace курсовая.forms
{
    partial class log_in
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
            this.title = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.pasw = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.entrance = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.signin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(135, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(122, 24);
            this.title.TabIndex = 21;
            this.title.Text = "Авторизація";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(62, 170);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(45, 18);
            this.username.TabIndex = 23;
            this.username.Text = "Логін";
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.SystemColors.HighlightText;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(65, 191);
            this.login.MaximumSize = new System.Drawing.Size(244, 33);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(244, 33);
            this.login.TabIndex = 24;
            // 
            // pasw
            // 
            this.pasw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasw.AutoSize = true;
            this.pasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasw.Location = new System.Drawing.Point(62, 248);
            this.pasw.Name = "pasw";
            this.pasw.Size = new System.Drawing.Size(61, 18);
            this.pasw.TabIndex = 25;
            this.pasw.Text = "Пароль";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(65, 269);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(244, 33);
            this.password.TabIndex = 26;
            // 
            // showpassword
            // 
            this.showpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showpassword.AutoSize = true;
            this.showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showpassword.Location = new System.Drawing.Point(158, 308);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(151, 22);
            this.showpassword.TabIndex = 27;
            this.showpassword.Text = "Показати пароль";
            this.showpassword.UseVisualStyleBackColor = true;
            this.showpassword.CheckedChanged += new System.EventHandler(this.showpassword_CheckedChanged_1);
            // 
            // entrance
            // 
            this.entrance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entrance.BackColor = System.Drawing.Color.PaleGreen;
            this.entrance.FlatAppearance.BorderSize = 0;
            this.entrance.Location = new System.Drawing.Point(124, 356);
            this.entrance.Name = "entrance";
            this.entrance.Size = new System.Drawing.Size(133, 48);
            this.entrance.TabIndex = 28;
            this.entrance.Text = "Увійти";
            this.entrance.UseVisualStyleBackColor = false;
            this.entrance.Click += new System.EventHandler(this.entrance_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.Image = global::курсовая.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(151, 82);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(86, 79);
            this.logo.TabIndex = 30;
            this.logo.TabStop = false;
            // 
            // signin
            // 
            this.signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signin.FlatAppearance.BorderSize = 0;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.signin.Location = new System.Drawing.Point(115, 433);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(152, 29);
            this.signin.TabIndex = 31;
            this.signin.Text = "Зареєструватися";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(373, 523);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.entrance);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pasw);
            this.Controls.Add(this.login);
            this.Controls.Add(this.username);
            this.Controls.Add(this.title);
            this.Name = "log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід в акаунт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.log_in_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label pasw;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.Button entrance;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button signin;
    }
}