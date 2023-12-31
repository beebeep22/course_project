﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using курсовая.classes;


namespace курсовая.forms
{
    public partial class Golovna_Admin : Form
    {

        private Form activeForm;
        private Account AccountObj { get; set; }
        private DbAdminOperations AdminOperations { get; set; }

        public Golovna_Admin(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.AdminOperations = new DbAdminOperations();
            this.Size = new Size(919, 514);
            panelmenu.Size = new System.Drawing.Size(200, 100);
            Акаунт.Size = new System.Drawing.Size(220, 80);
            paneltitle.Size = new System.Drawing.Size(681, 80);
            Заявки.Size = new System.Drawing.Size(220, 60);
            Налаштування.Size = new System.Drawing.Size(220, 60);
            exit.Size = new System.Drawing.Size(220, 60);
            this.IsMdiContainer = true;
            labeltitle.Location = new Point((paneltitle.Width - labeltitle.Width) / 2, (paneltitle.Height - labeltitle.Height) / 2);
            labeltitle.Text = "З поверненням, адміне!";
        }

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
            OpenChildForm(new forms.Account_admin(this.AccountObj), sender);
            labeltitle.Text = "Акаунт";
        }

        private void userverificationbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.UserVerification(), sender);
            labeltitle.Text = "Верифікація";
        }

        private void Zayavki_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Zayavki(this.AccountObj, this), sender);
            labeltitle.Text = "Заявки";
           
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Settings(AccountObj), sender);
            labeltitle.Text = "Налаштування";
        }

        private void developers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Developers_info(), sender);
            labeltitle.Text = "Розробники";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form form in formsToClose)
            {
                if (form != this)
                {
                    form.Close();
                }
            }

            Thread thread = new Thread(() =>
            {
                Application.Run(new log_in());
            });

            thread.Start();
        }

        private void Golovna_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
