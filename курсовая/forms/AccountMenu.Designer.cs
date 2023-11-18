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
            this.pers.SuspendLayout();
            this.SuspendLayout();
            // 
            // avatarka
            // 
            this.avatarka.Image = global::курсовая.Properties.Resources.user3;
            this.avatarka.Location = new System.Drawing.Point(61, 26);
            this.avatarka.Name = "avatarka";
            this.avatarka.Size = new System.Drawing.Size(150, 149);
            this.avatarka.TabIndex = 0;
            this.avatarka.UseVisualStyleBackColor = true;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(291, 26);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(151, 22);
            this.surname.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(291, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 22);
            this.name.TabIndex = 2;
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(291, 133);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(151, 22);
            this.patronymic.TabIndex = 3;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(61, 192);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(29, 16);
            this.data.TabIndex = 7;
            this.data.Text = "Вік:";
            // 
            // region
            // 
            this.region.FormattingEnabled = true;
            this.region.Location = new System.Drawing.Point(64, 338);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(151, 24);
            this.region.TabIndex = 9;
            // 
            // pers
            // 
            this.pers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pers.Controls.Add(this.personal);
            this.pers.Location = new System.Drawing.Point(291, 214);
            this.pers.Name = "pers";
            this.pers.Size = new System.Drawing.Size(466, 22);
            this.pers.TabIndex = 10;
            // 
            // personal
            // 
            this.personal.AutoSize = true;
            this.personal.Location = new System.Drawing.Point(3, 3);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(95, 16);
            this.personal.TabIndex = 0;
            this.personal.Text = "Персональне";
            // 
            // pathdiseas
            // 
            this.pathdiseas.FormattingEnabled = true;
            this.pathdiseas.Location = new System.Drawing.Point(291, 269);
            this.pathdiseas.Name = "pathdiseas";
            this.pathdiseas.Size = new System.Drawing.Size(182, 24);
            this.pathdiseas.TabIndex = 11;
            // 
            // alergic
            // 
            this.alergic.FormattingEnabled = true;
            this.alergic.Location = new System.Drawing.Point(532, 269);
            this.alergic.Name = "alergic";
            this.alergic.Size = new System.Drawing.Size(151, 24);
            this.alergic.TabIndex = 12;
            // 
            // invalid
            // 
            this.invalid.FormattingEnabled = true;
            this.invalid.Location = new System.Drawing.Point(291, 338);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(151, 24);
            this.invalid.TabIndex = 13;
            // 
            // regiontitle
            // 
            this.regiontitle.AutoSize = true;
            this.regiontitle.Location = new System.Drawing.Point(62, 319);
            this.regiontitle.Name = "regiontitle";
            this.regiontitle.Size = new System.Drawing.Size(52, 16);
            this.regiontitle.TabIndex = 16;
            this.regiontitle.Text = "Регіон:";
            // 
            // diseasestitle
            // 
            this.diseasestitle.AutoSize = true;
            this.diseasestitle.Location = new System.Drawing.Point(288, 250);
            this.diseasestitle.Name = "diseasestitle";
            this.diseasestitle.Size = new System.Drawing.Size(185, 16);
            this.diseasestitle.TabIndex = 17;
            this.diseasestitle.Text = "Патологічні захворювання:";
            // 
            // alergtitle
            // 
            this.alergtitle.AutoSize = true;
            this.alergtitle.Location = new System.Drawing.Point(529, 250);
            this.alergtitle.Name = "alergtitle";
            this.alergtitle.Size = new System.Drawing.Size(55, 16);
            this.alergtitle.TabIndex = 18;
            this.alergtitle.Text = "Алергії:";
            // 
            // inval
            // 
            this.inval.AutoSize = true;
            this.inval.Location = new System.Drawing.Point(294, 319);
            this.inval.Name = "inval";
            this.inval.Size = new System.Drawing.Size(88, 16);
            this.inval.TabIndex = 19;
            this.inval.Text = "Інвалідність:";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.Location = new System.Drawing.Point(291, 392);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 35);
            this.save.TabIndex = 20;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(64, 280);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(50, 22);
            this.sex.TabIndex = 42;
            // 
            // tltsex
            // 
            this.tltsex.AutoSize = true;
            this.tltsex.Location = new System.Drawing.Point(61, 261);
            this.tltsex.Name = "tltsex";
            this.tltsex.Size = new System.Drawing.Size(48, 16);
            this.tltsex.TabIndex = 43;
            this.tltsex.Text = "Стать:";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(64, 214);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(46, 22);
            this.age.TabIndex = 44;
            // 
            // AccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}