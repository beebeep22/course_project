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
    public partial class sign_in : Form
    {
        private DbAccountOperations AccountOperations { get; set; }

        public sign_in()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new Size(391, 570);
            AccountOperations = new DbAccountOperations();        }

        private bool isInputValid()
        {
            if (login.Text == "")
            {
                MessageBox.Show("Поле логіна незаповнене");
                return false;
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Поле пароля незаповнене");
                return false;
            }
            else if (passwordagain.Text == "")
            {
                MessageBox.Show("Поле повторення пароля незаповнене");
                return false;
            }
            else if (password.Text.Length < 12)
            {
                MessageBox.Show("Не менше 12 символів у паролі!");
                return false;
            }
            else if (password.Text != passwordagain.Text)
            {
                MessageBox.Show("Паролі не співпадають!");
                password.Text = "";
                passwordagain.Text = "";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (!isInputValid()) return;
            LoginInput input = new LoginInput(login.Text, password.Text); 
            Account account = AccountOperations.CreateUserAccountByUsernameAndPassword(input);
            // TODO: provide account instance to CreateAccount
            Createaccount createaccount = new Createaccount();
            createaccount.Show();
            this.Hide();
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                passwordagain.PasswordChar = '\0';
            }
            else
            {
                passwordagain.PasswordChar = '*';
            }
        }

        private void sign_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void returnlog_Click(object sender, EventArgs e)
        {
            log_in log_In = new log_in();
            log_In.Show();
            this.Hide();
        }
    }
}
