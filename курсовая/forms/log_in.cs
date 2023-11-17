using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using курсовая.classes;

namespace курсовая.forms
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new Size(391, 570);

        }    

        private void entrance_Click(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                MessageBox.Show("Поле логіна незаповнене");
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Поле пароля незаповнене");
            }
            else if (password.Text.Length < 12)
            {
                MessageBox.Show("Не менше 12 символів у паролі!");
            }
            else if(login.Text == "zireael" && password.Text == "123456789ksg")
            {
                Golovna_Admin golovna_Admin = new Golovna_Admin();
                golovna_Admin.Show();
                this.Hide();

                Account_admin account_Admin = new Account_admin("Ксенія", "Гончаренко", "Сергіївна");
                golovna_Admin.OpenChildForm(account_Admin, sender);
                
            }
            else
            {
                Golovna golovna = new Golovna();
                golovna.Show();
                this.Hide();

                Account accountForm = new Account("", "", "", "", "");
                golovna.OpenChildForm(accountForm, sender);
                golovna.labeltitle.Text = "З поверненням!";
            }
        }

        private void showpassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void log_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            sign_in registration = new sign_in();
            registration.Show();
            this.Hide();
        }
    }
}
