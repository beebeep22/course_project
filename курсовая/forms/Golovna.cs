using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using курсовая.classes;

namespace курсовая.forms
{
    internal class Golovna : Form
    {
        private Panel panelMenu;
        private Button Account;
        private Button Podacha;
        private Button History;
        private Button Settings;
        private Panel Title;
        public Label labeltitle;
        private Button exit;
        private Button message;
        private Form activeForm;
        private Panel panelDesktop;
        private Account AccountObj;

        public Golovna(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = new Size(919, 514);
            this.Text = "Облік тa розподіл державних та соціальних допомог";

        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new log_in());
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Golovna));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Podacha = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelMenu.Controls.Add(this.exit);
            this.panelMenu.Controls.Add(this.Settings);
            this.panelMenu.Controls.Add(this.History);
            this.panelMenu.Controls.Add(this.Podacha);
            this.panelMenu.Controls.Add(this.Account);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 467);
            this.panelMenu.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Image = global::курсовая.Properties.Resources.exit;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(0, 260);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.exit.Size = new System.Drawing.Size(220, 60);
            this.exit.TabIndex = 6;
            this.exit.Text = "              Вихід";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Settings
            // 
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Settings.Image = global::курсовая.Properties.Resources.settings;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 200);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Settings.Size = new System.Drawing.Size(220, 60);
            this.Settings.TabIndex = 4;
            this.Settings.Text = " Налаштування";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // History
            // 
            this.History.Dock = System.Windows.Forms.DockStyle.Top;
            this.History.FlatAppearance.BorderSize = 0;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.History.Image = global::курсовая.Properties.Resources.status1;
            this.History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History.Location = new System.Drawing.Point(0, 140);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.History.Size = new System.Drawing.Size(220, 60);
            this.History.TabIndex = 3;
            this.History.Text = "        Історія заявок";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Podacha
            // 
            this.Podacha.Dock = System.Windows.Forms.DockStyle.Top;
            this.Podacha.FlatAppearance.BorderSize = 0;
            this.Podacha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Podacha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Podacha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Podacha.Image = global::курсовая.Properties.Resources.заявка;
            this.Podacha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Podacha.Location = new System.Drawing.Point(0, 80);
            this.Podacha.Name = "Podacha";
            this.Podacha.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Podacha.Size = new System.Drawing.Size(220, 60);
            this.Podacha.TabIndex = 2;
            this.Podacha.Text = "       Подача заявок";
            this.Podacha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Podacha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Podacha.UseVisualStyleBackColor = true;
            this.Podacha.Click += new System.EventHandler(this.Podacha_Click);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.SlateGray;
            this.Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.Account.FlatAppearance.BorderSize = 0;
            this.Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Account.Image = global::курсовая.Properties.Resources.free_icon_user64;
            this.Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account.Location = new System.Drawing.Point(0, 0);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(220, 80);
            this.Account.TabIndex = 1;
            this.Account.Text = "        Акаунт";
            this.Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Account.UseVisualStyleBackColor = false;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Title.Controls.Add(this.message);
            this.Title.Controls.Add(this.labeltitle);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(220, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(681, 80);
            this.Title.TabIndex = 1;
            // 
            // message
            // 
            this.message.FlatAppearance.BorderSize = 0;
            this.message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.message.Image = global::курсовая.Properties.Resources.повідомлення;
            this.message.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.message.Location = new System.Drawing.Point(0, 4);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(216, 70);
            this.message.TabIndex = 1;
            this.message.Text = "     Повідомлення";
            this.message.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.message.UseVisualStyleBackColor = true;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltitle.Location = new System.Drawing.Point(297, 26);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(110, 29);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Головна";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Menu;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(681, 387);
            this.panelDesktop.TabIndex = 2;
            // 
            // Golovna
            // 
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(901, 467);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Golovna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік та розподіл державних та соціальних допомог";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Golovna_FormClosing);
            this.Load += new System.EventHandler(this.Golovna_Load);
            this.panelMenu.ResumeLayout(false);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.ResumeLayout(false);

        }

        //відкриваємо дочерні форми на панелі panelDesktop
        public void OpenChildForm(Form childform, object Sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childform);
            this.panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void Account_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.AccountMenu(this.AccountObj), sender);
            labeltitle.Text = "Акаунт";
        }

        private void Podacha_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Podacha(this.AccountObj), sender);
            labeltitle.Text = "Подача заявок";
        }

        private void History_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.History(this.AccountObj), sender);
            labeltitle.Text = "Історія";
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Settings(), sender);
            labeltitle.Text = "Налаштування";
        }

        private void message_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Message_box(this.AccountObj), sender);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            log_in login = new log_in();
            login.Show();
            this.Hide();
        }

        private void Golovna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Golovna_Load(object sender, EventArgs e)
        {

        }
    }
}
