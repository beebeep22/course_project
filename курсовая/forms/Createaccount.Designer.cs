namespace курсовая.forms
{
    partial class Createaccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Createaccount));
            this.title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.ComboBox();
            this.Men = new System.Windows.Forms.CheckBox();
            this.women = new System.Windows.Forms.CheckBox();
            this.create = new System.Windows.Forms.Button();
            this.tltname = new System.Windows.Forms.Label();
            this.tltsurname = new System.Windows.Forms.Label();
            this.tltpatronic = new System.Windows.Forms.Label();
            this.tltborn = new System.Windows.Forms.Label();
            this.tltsex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(47, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(278, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Створення облікового запису";
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.Image = global::курсовая.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(132, 82);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(86, 79);
            this.logo.TabIndex = 31;
            this.logo.TabStop = false;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(65, 190);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(244, 33);
            this.name.TabIndex = 32;
            // 
            // surname
            // 
            this.surname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(65, 255);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(244, 33);
            this.surname.TabIndex = 33;
            // 
            // patronymic
            // 
            this.patronymic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymic.Location = new System.Drawing.Point(65, 320);
            this.patronymic.Multiline = true;
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(244, 33);
            this.patronymic.TabIndex = 34;
            // 
            // age
            // 
            this.age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.FormattingEnabled = true;
            this.age.Location = new System.Drawing.Point(65, 380);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(60, 28);
            this.age.TabIndex = 35;
            // 
            // Men
            // 
            this.Men.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Men.AutoSize = true;
            this.Men.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Men.Location = new System.Drawing.Point(65, 433);
            this.Men.Name = "Men";
            this.Men.Size = new System.Drawing.Size(41, 21);
            this.Men.TabIndex = 38;
            this.Men.Text = "М";
            this.Men.UseVisualStyleBackColor = true;
            this.Men.CheckedChanged += new System.EventHandler(this.Men_CheckedChanged);
            // 
            // women
            // 
            this.women.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.women.AutoSize = true;
            this.women.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.women.Location = new System.Drawing.Point(136, 433);
            this.women.Name = "women";
            this.women.Size = new System.Drawing.Size(43, 21);
            this.women.TabIndex = 39;
            this.women.Text = "Ж";
            this.women.UseVisualStyleBackColor = true;
            this.women.CheckedChanged += new System.EventHandler(this.women_CheckedChanged);
            // 
            // create
            // 
            this.create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create.BackColor = System.Drawing.Color.PaleGreen;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.Location = new System.Drawing.Point(132, 472);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(133, 48);
            this.create.TabIndex = 40;
            this.create.Text = "Створити запис";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // tltname
            // 
            this.tltname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tltname.AutoSize = true;
            this.tltname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltname.Location = new System.Drawing.Point(65, 168);
            this.tltname.Name = "tltname";
            this.tltname.Size = new System.Drawing.Size(90, 18);
            this.tltname.TabIndex = 41;
            this.tltname.Text = "Введіть ім\'я";
            // 
            // tltsurname
            // 
            this.tltsurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tltsurname.AutoSize = true;
            this.tltsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltsurname.Location = new System.Drawing.Point(65, 235);
            this.tltsurname.Name = "tltsurname";
            this.tltsurname.Size = new System.Drawing.Size(127, 18);
            this.tltsurname.TabIndex = 42;
            this.tltsurname.Text = "Введіть прізвище";
            // 
            // tltpatronic
            // 
            this.tltpatronic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tltpatronic.AutoSize = true;
            this.tltpatronic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltpatronic.Location = new System.Drawing.Point(65, 300);
            this.tltpatronic.Name = "tltpatronic";
            this.tltpatronic.Size = new System.Drawing.Size(147, 18);
            this.tltpatronic.TabIndex = 43;
            this.tltpatronic.Text = "Введіть по-батькові";
            // 
            // tltborn
            // 
            this.tltborn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tltborn.AutoSize = true;
            this.tltborn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltborn.Location = new System.Drawing.Point(65, 360);
            this.tltborn.Name = "tltborn";
            this.tltborn.Size = new System.Drawing.Size(84, 18);
            this.tltborn.TabIndex = 44;
            this.tltborn.Text = "Введіть вік";
            // 
            // tltsex
            // 
            this.tltsex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tltsex.AutoSize = true;
            this.tltsex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tltsex.Location = new System.Drawing.Point(65, 413);
            this.tltsex.Name = "tltsex";
            this.tltsex.Size = new System.Drawing.Size(105, 18);
            this.tltsex.TabIndex = 45;
            this.tltsex.Text = "Оберіть стать";
            // 
            // Createaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(373, 523);
            this.Controls.Add(this.tltsex);
            this.Controls.Add(this.tltborn);
            this.Controls.Add(this.tltpatronic);
            this.Controls.Add(this.tltsurname);
            this.Controls.Add(this.tltname);
            this.Controls.Add(this.create);
            this.Controls.Add(this.women);
            this.Controls.Add(this.Men);
            this.Controls.Add(this.age);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Createaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення облікового запису";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Createaccount_FormClosing);
            this.Load += new System.EventHandler(this.Createaccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.ComboBox age;
        private System.Windows.Forms.CheckBox Men;
        private System.Windows.Forms.CheckBox women;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label tltname;
        private System.Windows.Forms.Label tltsurname;
        private System.Windows.Forms.Label tltpatronic;
        private System.Windows.Forms.Label tltborn;
        private System.Windows.Forms.Label tltsex;
    }
}