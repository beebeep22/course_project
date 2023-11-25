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
        private DbAccountOperations AccountOperations { get; set; }


        public log_in()
        {
            InitializeComponent();
            AccountOperations = new DbAccountOperations();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new Size(391, 570);
            login.KeyDown += login_KeyDown;
            password.KeyDown += password_KeyDown;
        }

        private bool isInputValid(LoginInput input)
        {
            if (input.Username == "")
            {
                MessageBox.Show("Поле логіна незаповнене");
                return false;
            }
            else if (input.Password == "")
            {
                MessageBox.Show("Поле пароля незаповнене");
                return false;
            }
            else if (input.Password.Length < 12)
            {
                MessageBox.Show("Не менше 12 символів у паролі!");
                return false;
            }
            return true;
        }

        private void entrance_Click(object sender, EventArgs e)
        {
            LoginInput input = new LoginInput(login.Text, password.Text);
            if (!isInputValid(input)) return;

            Account accountObj = AccountOperations.GetAccountByUsernameAndPassword(input);
            if (accountObj == null)
            {
                MessageBox.Show("Поле логіна чи пароля неправильне!");
                return;
            }
            if (accountObj.Role == "user")
            {
                Golovna golovna = new Golovna(accountObj);
                golovna.Show();
                this.Hide();

                AccountMenu accountForm = new AccountMenu(accountObj);
                golovna.OpenChildForm(accountForm, sender);
                golovna.labeltitle.Text = "З поверненням!";
            }
            else if (accountObj.Role == "admin")
            {
                Golovna_Admin golovna_Admin = new Golovna_Admin(accountObj);
                golovna_Admin.Show();
                this.Hide();

                Account_admin account_Admin = new Account_admin(accountObj);
                golovna_Admin.OpenChildForm(account_Admin, sender);
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

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                entrance.PerformClick();
            }
        }
    }
}
