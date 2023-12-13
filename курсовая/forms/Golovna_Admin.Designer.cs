namespace курсовая.forms
{
    partial class Golovna_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Golovna_Admin));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.Налаштування = new System.Windows.Forms.Button();
            this.Заявки = new System.Windows.Forms.Button();
            this.userverificationbutton = new System.Windows.Forms.Button();
            this.Акаунт = new System.Windows.Forms.Button();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.developers = new System.Windows.Forms.Button();
            this.panelmenu.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelmenu.Controls.Add(this.developers);
            this.panelmenu.Controls.Add(this.exit);
            this.panelmenu.Controls.Add(this.Налаштування);
            this.panelmenu.Controls.Add(this.Заявки);
            this.panelmenu.Controls.Add(this.userverificationbutton);
            this.panelmenu.Controls.Add(this.Акаунт);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 467);
            this.panelmenu.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Image = global::курсовая.Properties.Resources.exit;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(0, 407);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.exit.Size = new System.Drawing.Size(220, 60);
            this.exit.TabIndex = 7;
            this.exit.Text = "              Вихід";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Налаштування
            // 
            this.Налаштування.Dock = System.Windows.Forms.DockStyle.Top;
            this.Налаштування.FlatAppearance.BorderSize = 0;
            this.Налаштування.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Налаштування.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Налаштування.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Налаштування.Image = global::курсовая.Properties.Resources.settings;
            this.Налаштування.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Налаштування.Location = new System.Drawing.Point(0, 214);
            this.Налаштування.Name = "Налаштування";
            this.Налаштування.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Налаштування.Size = new System.Drawing.Size(220, 60);
            this.Налаштування.TabIndex = 5;
            this.Налаштування.Text = "     Налаштування";
            this.Налаштування.UseVisualStyleBackColor = true;
            this.Налаштування.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Заявки
            // 
            this.Заявки.Dock = System.Windows.Forms.DockStyle.Top;
            this.Заявки.FlatAppearance.BorderSize = 0;
            this.Заявки.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Заявки.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Заявки.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Заявки.Image = global::курсовая.Properties.Resources.заявка;
            this.Заявки.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Заявки.Location = new System.Drawing.Point(0, 154);
            this.Заявки.Name = "Заявки";
            this.Заявки.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Заявки.Size = new System.Drawing.Size(220, 60);
            this.Заявки.TabIndex = 1;
            this.Заявки.Text = "             Заявки";
            this.Заявки.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Заявки.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Заявки.UseVisualStyleBackColor = true;
            this.Заявки.Click += new System.EventHandler(this.Zayavki_Click);
            // 
            // userverificationbutton
            // 
            this.userverificationbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userverificationbutton.FlatAppearance.BorderSize = 0;
            this.userverificationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userverificationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userverificationbutton.ForeColor = System.Drawing.Color.White;
            this.userverificationbutton.Image = global::курсовая.Properties.Resources.status;
            this.userverificationbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userverificationbutton.Location = new System.Drawing.Point(0, 80);
            this.userverificationbutton.Name = "userverificationbutton";
            this.userverificationbutton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.userverificationbutton.Size = new System.Drawing.Size(220, 74);
            this.userverificationbutton.TabIndex = 8;
            this.userverificationbutton.Text = "        Верифікація \r\nкористувачів";
            this.userverificationbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userverificationbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userverificationbutton.UseVisualStyleBackColor = true;
            this.userverificationbutton.Click += new System.EventHandler(this.userverificationbutton_Click);
            // 
            // Акаунт
            // 
            this.Акаунт.BackColor = System.Drawing.Color.SlateGray;
            this.Акаунт.Dock = System.Windows.Forms.DockStyle.Top;
            this.Акаунт.FlatAppearance.BorderSize = 0;
            this.Акаунт.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Акаунт.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Акаунт.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Акаунт.Image = global::курсовая.Properties.Resources.free_icon_user64;
            this.Акаунт.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Акаунт.Location = new System.Drawing.Point(0, 0);
            this.Акаунт.Name = "Акаунт";
            this.Акаунт.Size = new System.Drawing.Size(220, 80);
            this.Акаунт.TabIndex = 0;
            this.Акаунт.Text = "      Акаунт";
            this.Акаунт.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Акаунт.UseVisualStyleBackColor = false;
            this.Акаунт.Click += new System.EventHandler(this.Account_Click);
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.paneltitle.Controls.Add(this.labeltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(220, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(681, 80);
            this.paneltitle.TabIndex = 1;
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltitle.Location = new System.Drawing.Point(294, 22);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(110, 29);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "Головна";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(681, 387);
            this.panelDesktop.TabIndex = 2;
            // 
            // developers
            // 
            this.developers.Dock = System.Windows.Forms.DockStyle.Top;
            this.developers.FlatAppearance.BorderSize = 0;
            this.developers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.developers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developers.ForeColor = System.Drawing.Color.White;
            this.developers.Image = global::курсовая.Properties.Resources.dev32;
            this.developers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.developers.Location = new System.Drawing.Point(0, 274);
            this.developers.Name = "developers";
            this.developers.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.developers.Size = new System.Drawing.Size(220, 60);
            this.developers.TabIndex = 9;
            this.developers.Text = "         Розробники";
            this.developers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.developers.UseVisualStyleBackColor = true;
            this.developers.Click += new System.EventHandler(this.developers_Click);
            // 
            // Golovna_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 467);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Golovna_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік та розподіл державних та соціальних допомог";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Golovna_Admin_FormClosing);
            this.panelmenu.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button Акаунт;
        private System.Windows.Forms.Button Заявки;
        private System.Windows.Forms.Button Налаштування;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button userverificationbutton;
        private System.Windows.Forms.Button developers;
    }
}