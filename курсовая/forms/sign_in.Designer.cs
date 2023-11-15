namespace курсовая.forms
{
    partial class sign_in
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
            this.password = new System.Windows.Forms.TextBox();
            this.pasw = new System.Windows.Forms.Label();
            this.passwordagain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.register = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.returnlog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(148, 55);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(109, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Реєстрація";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(71, 170);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(45, 18);
            this.username.TabIndex = 1;
            this.username.Text = "Логін";
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.SystemColors.HighlightText;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(74, 191);
            this.login.MaximumSize = new System.Drawing.Size(244, 33);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(244, 33);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(74, 269);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(244, 33);
            this.password.TabIndex = 5;
            // 
            // pasw
            // 
            this.pasw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasw.AutoSize = true;
            this.pasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasw.Location = new System.Drawing.Point(71, 248);
            this.pasw.Name = "pasw";
            this.pasw.Size = new System.Drawing.Size(61, 18);
            this.pasw.TabIndex = 4;
            this.pasw.Text = "Пароль";
            // 
            // passwordagain
            // 
            this.passwordagain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordagain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passwordagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordagain.Location = new System.Drawing.Point(74, 350);
            this.passwordagain.Multiline = true;
            this.passwordagain.Name = "passwordagain";
            this.passwordagain.PasswordChar = '*';
            this.passwordagain.Size = new System.Drawing.Size(244, 33);
            this.passwordagain.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Повторно введіть пароль";
            // 
            // showpassword
            // 
            this.showpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showpassword.AutoSize = true;
            this.showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showpassword.Location = new System.Drawing.Point(174, 398);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(151, 22);
            this.showpassword.TabIndex = 8;
            this.showpassword.Text = "Показати пароль";
            this.showpassword.UseVisualStyleBackColor = true;
            this.showpassword.CheckedChanged += new System.EventHandler(this.showpassword_CheckedChanged);
            // 
            // register
            // 
            this.register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register.BackColor = System.Drawing.Color.PaleGreen;
            this.register.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.Location = new System.Drawing.Point(124, 434);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(133, 48);
            this.register.TabIndex = 9;
            this.register.Text = "Зареєструватися";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.Image = global::курсовая.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(161, 82);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(86, 79);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // returnlog
            // 
            this.returnlog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnlog.FlatAppearance.BorderSize = 0;
            this.returnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnlog.ForeColor = System.Drawing.Color.DodgerBlue;
            this.returnlog.Location = new System.Drawing.Point(115, 488);
            this.returnlog.Name = "returnlog";
            this.returnlog.Size = new System.Drawing.Size(155, 29);
            this.returnlog.TabIndex = 10;
            this.returnlog.Text = "В мене є акаунт";
            this.returnlog.UseVisualStyleBackColor = true;
            this.returnlog.Click += new System.EventHandler(this.returnlog_Click);
            // 
            // sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(373, 523);
            this.Controls.Add(this.returnlog);
            this.Controls.Add(this.register);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.passwordagain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pasw);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.username);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sign_in_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label pasw;
        private System.Windows.Forms.TextBox passwordagain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button returnlog;
    }
}