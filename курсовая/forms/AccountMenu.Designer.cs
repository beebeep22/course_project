namespace курсовая.forms
{
    partial class AccountMenu
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
            this.avatarka = new System.Windows.Forms.Button();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.ComboBox();
            this.pers = new System.Windows.Forms.Panel();
            this.personal = new System.Windows.Forms.Label();
            this.pathdiseas = new System.Windows.Forms.ComboBox();
            this.alergic = new System.Windows.Forms.ComboBox();
            this.invalid = new System.Windows.Forms.ComboBox();
            this.regiontitle = new System.Windows.Forms.Label();
            this.diseasestitle = new System.Windows.Forms.Label();
            this.alergtitle = new System.Windows.Forms.Label();
            this.inval = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.TextBox();
            this.tltsex = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.pers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarka
            // 
            this.avatarka.FlatAppearance.BorderSize = 0;
            this.avatarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avatarka.ForeColor = System.Drawing.SystemColors.Highlight;
            this.avatarka.Location = new System.Drawing.Point(64, 170);
            this.avatarka.Name = "avatarka";
            this.avatarka.Size = new System.Drawing.Size(136, 28);
            this.avatarka.TabIndex = 0;
            this.avatarka.Text = "Змінити фото";
            this.avatarka.UseVisualStyleBackColor = true;
            this.avatarka.Click += new System.EventHandler(this.avatarka_Click);
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(291, 26);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(151, 24);
            this.surname.TabIndex = 1;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(291, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 24);
            this.name.TabIndex = 2;
            // 
            // patronymic
            // 
            this.patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymic.Location = new System.Drawing.Point(291, 133);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(151, 24);
            this.patronymic.TabIndex = 3;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(61, 211);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(29, 16);
            this.data.TabIndex = 7;
            this.data.Text = "Вік:";
            // 
            // region
            // 
            this.region.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.region.FormattingEnabled = true;
            this.region.Location = new System.Drawing.Point(64, 357);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(151, 26);
            this.region.TabIndex = 9;
            // 
            // pers
            // 
            this.pers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pers.Controls.Add(this.personal);
            this.pers.Location = new System.Drawing.Point(291, 228);
            this.pers.Name = "pers";
            this.pers.Size = new System.Drawing.Size(466, 27);
            this.pers.TabIndex = 10;
            // 
            // personal
            // 
            this.personal.AutoSize = true;
            this.personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personal.Location = new System.Drawing.Point(3, 3);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(101, 18);
            this.personal.TabIndex = 0;
            this.personal.Text = "Персональне";
            // 
            // pathdiseas
            // 
            this.pathdiseas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathdiseas.FormattingEnabled = true;
            this.pathdiseas.Location = new System.Drawing.Point(291, 288);
            this.pathdiseas.Name = "pathdiseas";
            this.pathdiseas.Size = new System.Drawing.Size(182, 26);
            this.pathdiseas.TabIndex = 11;
            // 
            // alergic
            // 
            this.alergic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alergic.FormattingEnabled = true;
            this.alergic.Location = new System.Drawing.Point(532, 288);
            this.alergic.Name = "alergic";
            this.alergic.Size = new System.Drawing.Size(151, 26);
            this.alergic.TabIndex = 12;
            // 
            // invalid
            // 
            this.invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invalid.FormattingEnabled = true;
            this.invalid.Location = new System.Drawing.Point(291, 357);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(151, 26);
            this.invalid.TabIndex = 13;
            // 
            // regiontitle
            // 
            this.regiontitle.AutoSize = true;
            this.regiontitle.Location = new System.Drawing.Point(62, 338);
            this.regiontitle.Name = "regiontitle";
            this.regiontitle.Size = new System.Drawing.Size(52, 16);
            this.regiontitle.TabIndex = 16;
            this.regiontitle.Text = "Регіон:";
            // 
            // diseasestitle
            // 
            this.diseasestitle.AutoSize = true;
            this.diseasestitle.Location = new System.Drawing.Point(288, 269);
            this.diseasestitle.Name = "diseasestitle";
            this.diseasestitle.Size = new System.Drawing.Size(185, 16);
            this.diseasestitle.TabIndex = 17;
            this.diseasestitle.Text = "Патологічні захворювання:";
            // 
            // alergtitle
            // 
            this.alergtitle.AutoSize = true;
            this.alergtitle.Location = new System.Drawing.Point(529, 269);
            this.alergtitle.Name = "alergtitle";
            this.alergtitle.Size = new System.Drawing.Size(55, 16);
            this.alergtitle.TabIndex = 18;
            this.alergtitle.Text = "Алергії:";
            // 
            // inval
            // 
            this.inval.AutoSize = true;
            this.inval.Location = new System.Drawing.Point(294, 338);
            this.inval.Name = "inval";
            this.inval.Size = new System.Drawing.Size(88, 16);
            this.inval.TabIndex = 19;
            this.inval.Text = "Інвалідність:";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(297, 403);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 35);
            this.save.TabIndex = 20;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // sex
            // 
            this.sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sex.Location = new System.Drawing.Point(64, 299);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(59, 24);
            this.sex.TabIndex = 42;
            // 
            // tltsex
            // 
            this.tltsex.AutoSize = true;
            this.tltsex.Location = new System.Drawing.Point(61, 280);
            this.tltsex.Name = "tltsex";
            this.tltsex.Size = new System.Drawing.Size(48, 16);
            this.tltsex.TabIndex = 43;
            this.tltsex.Text = "Стать:";
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(64, 233);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(46, 24);
            this.age.TabIndex = 44;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.avatar.Image = global::курсовая.Properties.Resources.user64;
            this.avatar.Location = new System.Drawing.Point(65, 26);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(136, 145);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.avatar.TabIndex = 45;
            this.avatar.TabStop = false;
            // 
            // AccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.age);
            this.Controls.Add(this.tltsex);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.save);
            this.Controls.Add(this.avatarka);
            this.Controls.Add(this.inval);
            this.Controls.Add(this.alergtitle);
            this.Controls.Add(this.diseasestitle);
            this.Controls.Add(this.regiontitle);
            this.Controls.Add(this.invalid);
            this.Controls.Add(this.alergic);
            this.Controls.Add(this.pathdiseas);
            this.Controls.Add(this.pers);
            this.Controls.Add(this.region);
            this.Controls.Add(this.data);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Name = "AccountMenu";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.pers.ResumeLayout(false);
            this.pers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Button avatarka;
        private System.Windows.Forms.ComboBox region;
        private System.Windows.Forms.Panel pers;
        private System.Windows.Forms.Label personal;
        private System.Windows.Forms.ComboBox pathdiseas;
        private System.Windows.Forms.ComboBox alergic;
        private System.Windows.Forms.ComboBox invalid;
        private System.Windows.Forms.Label regiontitle;
        private System.Windows.Forms.Label diseasestitle;
        private System.Windows.Forms.Label alergtitle;
        private System.Windows.Forms.Label inval;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.Label tltsex;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.PictureBox avatar;
    }
}