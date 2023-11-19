namespace курсовая.forms
{
    partial class create_notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_notification));
            this.content_notification = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.tltnotification = new System.Windows.Forms.Label();
            this.themenotification = new System.Windows.Forms.TextBox();
            this.tltthemenot = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.ComboBox();
            this.pathdiseas = new System.Windows.Forms.ComboBox();
            this.invalid = new System.Windows.Forms.ComboBox();
            this.alergic = new System.Windows.Forms.ComboBox();
            this.agefrom = new System.Windows.Forms.ComboBox();
            this.ageupto = new System.Windows.Forms.ComboBox();
            this.tltage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.men = new System.Windows.Forms.CheckBox();
            this.women = new System.Windows.Forms.CheckBox();
            this.tltsex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // content_notification
            // 
            this.content_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content_notification.Location = new System.Drawing.Point(263, 130);
            this.content_notification.Multiline = true;
            this.content_notification.Name = "content_notification";
            this.content_notification.Size = new System.Drawing.Size(391, 244);
            this.content_notification.TabIndex = 0;
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send.Location = new System.Drawing.Point(404, 396);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(126, 42);
            this.send.TabIndex = 1;
            this.send.Text = "Надіслати";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // tltnotification
            // 
            this.tltnotification.AutoSize = true;
            this.tltnotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltnotification.Location = new System.Drawing.Point(260, 109);
            this.tltnotification.Name = "tltnotification";
            this.tltnotification.Size = new System.Drawing.Size(149, 18);
            this.tltnotification.TabIndex = 2;
            this.tltnotification.Text = "Зміст повідомлення";
            // 
            // themenotification
            // 
            this.themenotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themenotification.Location = new System.Drawing.Point(263, 39);
            this.themenotification.Multiline = true;
            this.themenotification.Name = "themenotification";
            this.themenotification.Size = new System.Drawing.Size(391, 48);
            this.themenotification.TabIndex = 3;
            // 
            // tltthemenot
            // 
            this.tltthemenot.AutoSize = true;
            this.tltthemenot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltthemenot.Location = new System.Drawing.Point(263, 17);
            this.tltthemenot.Name = "tltthemenot";
            this.tltthemenot.Size = new System.Drawing.Size(146, 18);
            this.tltthemenot.TabIndex = 4;
            this.tltthemenot.Text = "Тема повідомлення";
            // 
            // region
            // 
            this.region.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.region.FormattingEnabled = true;
            this.region.Location = new System.Drawing.Point(44, 101);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(151, 24);
            this.region.TabIndex = 10;
            // 
            // pathdiseas
            // 
            this.pathdiseas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathdiseas.FormattingEnabled = true;
            this.pathdiseas.Location = new System.Drawing.Point(44, 162);
            this.pathdiseas.Name = "pathdiseas";
            this.pathdiseas.Size = new System.Drawing.Size(151, 24);
            this.pathdiseas.TabIndex = 12;
            // 
            // invalid
            // 
            this.invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invalid.FormattingEnabled = true;
            this.invalid.Location = new System.Drawing.Point(44, 223);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(151, 24);
            this.invalid.TabIndex = 14;
            // 
            // alergic
            // 
            this.alergic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alergic.FormattingEnabled = true;
            this.alergic.Location = new System.Drawing.Point(44, 292);
            this.alergic.Name = "alergic";
            this.alergic.Size = new System.Drawing.Size(151, 24);
            this.alergic.TabIndex = 15;
            // 
            // agefrom
            // 
            this.agefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agefrom.FormattingEnabled = true;
            this.agefrom.Location = new System.Drawing.Point(44, 41);
            this.agefrom.Name = "agefrom";
            this.agefrom.Size = new System.Drawing.Size(55, 24);
            this.agefrom.TabIndex = 16;
            // 
            // ageupto
            // 
            this.ageupto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageupto.FormattingEnabled = true;
            this.ageupto.Location = new System.Drawing.Point(138, 41);
            this.ageupto.Name = "ageupto";
            this.ageupto.Size = new System.Drawing.Size(57, 24);
            this.ageupto.TabIndex = 17;
            // 
            // tltage
            // 
            this.tltage.AutoSize = true;
            this.tltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltage.Location = new System.Drawing.Point(44, 17);
            this.tltage.Name = "tltage";
            this.tltage.Size = new System.Drawing.Size(29, 18);
            this.tltage.TabIndex = 18;
            this.tltage.Text = "Вік";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Від";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Регіон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Патологічні захворювання";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Інвалідність";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(44, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Алергії";
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Location = new System.Drawing.Point(44, 354);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(40, 20);
            this.men.TabIndex = 25;
            this.men.Text = "М";
            this.men.UseVisualStyleBackColor = true;
            this.men.CheckedChanged += new System.EventHandler(this.men_CheckedChanged);
            // 
            // women
            // 
            this.women.AutoSize = true;
            this.women.Location = new System.Drawing.Point(109, 354);
            this.women.Name = "women";
            this.women.Size = new System.Drawing.Size(42, 20);
            this.women.TabIndex = 26;
            this.women.Text = "Ж";
            this.women.UseVisualStyleBackColor = true;
            this.women.CheckedChanged += new System.EventHandler(this.women_CheckedChanged);
            // 
            // tltsex
            // 
            this.tltsex.AutoSize = true;
            this.tltsex.Location = new System.Drawing.Point(41, 334);
            this.tltsex.Name = "tltsex";
            this.tltsex.Size = new System.Drawing.Size(45, 16);
            this.tltsex.TabIndex = 27;
            this.tltsex.Text = "Стать";
            // 
            // create_notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tltsex);
            this.Controls.Add(this.women);
            this.Controls.Add(this.men);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tltage);
            this.Controls.Add(this.ageupto);
            this.Controls.Add(this.agefrom);
            this.Controls.Add(this.alergic);
            this.Controls.Add(this.invalid);
            this.Controls.Add(this.pathdiseas);
            this.Controls.Add(this.region);
            this.Controls.Add(this.tltthemenot);
            this.Controls.Add(this.themenotification);
            this.Controls.Add(this.tltnotification);
            this.Controls.Add(this.send);
            this.Controls.Add(this.content_notification);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "create_notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення повідомлення";
            this.Load += new System.EventHandler(this.create_notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox content_notification;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label tltnotification;
        private System.Windows.Forms.TextBox themenotification;
        private System.Windows.Forms.Label tltthemenot;
        private System.Windows.Forms.ComboBox region;
        private System.Windows.Forms.ComboBox pathdiseas;
        private System.Windows.Forms.ComboBox invalid;
        private System.Windows.Forms.ComboBox alergic;
        private System.Windows.Forms.ComboBox agefrom;
        private System.Windows.Forms.ComboBox ageupto;
        private System.Windows.Forms.Label tltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox men;
        private System.Windows.Forms.CheckBox women;
        private System.Windows.Forms.Label tltsex;
    }
}