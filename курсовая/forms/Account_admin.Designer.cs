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
            this.save = new System.Windows.Forms.Button();
            this.panelpermissions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tltResponse = new System.Windows.Forms.Label();
            this.tltnotification = new System.Windows.Forms.Label();
            this.ResponseTrue = new System.Windows.Forms.CheckBox();
            this.ResponseFalse = new System.Windows.Forms.CheckBox();
            this.NotificationTrue = new System.Windows.Forms.CheckBox();
            this.NotifacationFalse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_admin)).BeginInit();
            this.panelpermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // patronymic
            // 
            this.patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymic.Location = new System.Drawing.Point(291, 133);
            this.patronymic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(151, 24);
            this.patronymic.TabIndex = 6;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(291, 78);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 24);
            this.name.TabIndex = 5;
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(291, 26);
            this.surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(151, 24);
            this.surname.TabIndex = 4;
            // 
            // avatar_admin
            // 
            this.avatar_admin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.avatar_admin.BackgroundImage = global::курсовая.Properties.Resources.user64;
            this.avatar_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.avatar_admin.Location = new System.Drawing.Point(69, 26);
            this.avatar_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar_admin.Name = "avatar_admin";
            this.avatar_admin.Size = new System.Drawing.Size(136, 145);
            this.avatar_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar_admin.TabIndex = 47;
            this.avatar_admin.TabStop = false;
            // 
            // avatarka
            // 
            this.avatarka.FlatAppearance.BorderSize = 0;
            this.avatarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avatarka.ForeColor = System.Drawing.SystemColors.Highlight;
            this.avatarka.Location = new System.Drawing.Point(69, 170);
            this.avatarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatarka.Name = "avatarka";
            this.avatarka.Size = new System.Drawing.Size(143, 28);
            this.avatarka.TabIndex = 46;
            this.avatarka.Text = "Змінити фото";
            this.avatarka.UseVisualStyleBackColor = true;
            this.avatarka.Click += new System.EventHandler(this.avatarka_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.Location = new System.Drawing.Point(338, 405);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 34);
            this.save.TabIndex = 48;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // panelpermissions
            // 
            this.panelpermissions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelpermissions.Controls.Add(this.label1);
            this.panelpermissions.Location = new System.Drawing.Point(69, 224);
            this.panelpermissions.Name = "panelpermissions";
            this.panelpermissions.Size = new System.Drawing.Size(704, 30);
            this.panelpermissions.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Можливості";
            // 
            // tltResponse
            // 
            this.tltResponse.AutoSize = true;
            this.tltResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltResponse.Location = new System.Drawing.Point(66, 279);
            this.tltResponse.Name = "tltResponse";
            this.tltResponse.Size = new System.Drawing.Size(252, 18);
            this.tltResponse.TabIndex = 52;
            this.tltResponse.Text = "Можливість відповідати на заявки:";
            // 
            // tltnotification
            // 
            this.tltnotification.AutoSize = true;
            this.tltnotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltnotification.Location = new System.Drawing.Point(402, 280);
            this.tltnotification.Name = "tltnotification";
            this.tltnotification.Size = new System.Drawing.Size(351, 18);
            this.tltnotification.TabIndex = 53;
            this.tltnotification.Text = "Можливість створювати загальне повідомлення:";
            // 
            // ResponseTrue
            // 
            this.ResponseTrue.AutoSize = true;
            this.ResponseTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResponseTrue.Location = new System.Drawing.Point(96, 322);
            this.ResponseTrue.Name = "ResponseTrue";
            this.ResponseTrue.Size = new System.Drawing.Size(55, 22);
            this.ResponseTrue.TabIndex = 54;
            this.ResponseTrue.Text = "Так";
            this.ResponseTrue.UseVisualStyleBackColor = true;
            this.ResponseTrue.CheckedChanged += new System.EventHandler(this.ResponseTrue_CheckedChanged);
            // 
            // ResponseFalse
            // 
            this.ResponseFalse.AutoSize = true;
            this.ResponseFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResponseFalse.Location = new System.Drawing.Point(206, 322);
            this.ResponseFalse.Name = "ResponseFalse";
            this.ResponseFalse.Size = new System.Drawing.Size(44, 22);
            this.ResponseFalse.TabIndex = 55;
            this.ResponseFalse.Text = "Ні";
            this.ResponseFalse.UseVisualStyleBackColor = true;
            this.ResponseFalse.CheckedChanged += new System.EventHandler(this.ResponseFalse_CheckedChanged);
            // 
            // NotificationTrue
            // 
            this.NotificationTrue.AutoSize = true;
            this.NotificationTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationTrue.Location = new System.Drawing.Point(493, 323);
            this.NotificationTrue.Name = "NotificationTrue";
            this.NotificationTrue.Size = new System.Drawing.Size(55, 22);
            this.NotificationTrue.TabIndex = 56;
            this.NotificationTrue.Text = "Так";
            this.NotificationTrue.UseVisualStyleBackColor = true;
            this.NotificationTrue.CheckedChanged += new System.EventHandler(this.NotificationTrue_CheckedChanged);
            // 
            // NotifacationFalse
            // 
            this.NotifacationFalse.AutoSize = true;
            this.NotifacationFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotifacationFalse.Location = new System.Drawing.Point(628, 322);
            this.NotifacationFalse.Name = "NotifacationFalse";
            this.NotifacationFalse.Size = new System.Drawing.Size(44, 22);
            this.NotifacationFalse.TabIndex = 57;
            this.NotifacationFalse.Text = "Ні";
            this.NotifacationFalse.UseVisualStyleBackColor = true;
            this.NotifacationFalse.CheckedChanged += new System.EventHandler(this.NotifacationFalse_CheckedChanged);
            // 
            // Account_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotifacationFalse);
            this.Controls.Add(this.NotificationTrue);
            this.Controls.Add(this.ResponseFalse);
            this.Controls.Add(this.ResponseTrue);
            this.Controls.Add(this.tltnotification);
            this.Controls.Add(this.tltResponse);
            this.Controls.Add(this.panelpermissions);
            this.Controls.Add(this.save);
            this.Controls.Add(this.avatar_admin);
            this.Controls.Add(this.avatarka);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account_admin";
            this.Text = "Account_admin";
            this.Load += new System.EventHandler(this.Account_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar_admin)).EndInit();
            this.panelpermissions.ResumeLayout(false);
            this.panelpermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.PictureBox avatar_admin;
        private System.Windows.Forms.Button avatarka;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panelpermissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tltResponse;
        private System.Windows.Forms.Label tltnotification;
        private System.Windows.Forms.CheckBox ResponseTrue;
        private System.Windows.Forms.CheckBox ResponseFalse;
        private System.Windows.Forms.CheckBox NotificationTrue;
        private System.Windows.Forms.CheckBox NotifacationFalse;
    }
}