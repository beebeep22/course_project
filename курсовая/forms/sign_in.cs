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
using static System.Net.Mime.MediaTypeNames;

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
            AccountOperations = new DbAccountOperations();
            login.KeyDown += login_KeyDown;
            password.KeyDown += password_KeyDown;
            passwordagain.KeyDown += passwordagain_KeyDown;
        }

        private bool isInputValid()
        {
            try
            {
                List<string> errorMessages = new List<string>();
                if (login.Text == "")
                {
                    errorMessages.Add("Поле логіна незаповнене");
                }
                if (password.Text == "")
                {
                    errorMessages.Add("Поле пароля незаповнене");
                }
                else if (passwordagain.Text == "")
                {
                    errorMessages.Add("Поле повторення пароля незаповнене");
                }
                else if (password.Text.Length < 12)
                {
                    errorMessages.Add("Не менше 12 символів у паролі!");
                }
                else if (password.Text != passwordagain.Text)
                {
                    errorMessages.Add("Паролі не співпадають!");
                }
                else if (!IsLatinInput(login.Text))
                {
                    errorMessages.Add("Логін повинен містити тільки латинські символи.");
                }
                else if (!IsLatinInput(password.Text))
                {
                    errorMessages.Add("Пароль повинен містити тільки латинські символи.");
                }
                if (errorMessages.Count > 0)
                {
                    string errorMessage = string.Join("\r\n", errorMessages);
                    throw new Exceptions(errorMessage);
                }
                return true;
            }
            catch (Exception ex)
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.Text = "Помилка реєстрації";
                warning_Message.pictureBox1.Image = Properties.Resources.free_icon_cat_5772431;
                warning_Message.outputText.TextAlign = HorizontalAlignment.Center;
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
                return false;
            }
        }

        public bool IsLatinInput(string input)
        {

            foreach (char c in input)
            {
                if (c >= 'А' && c <= 'я')
                {
                    return false;
                }
            }

            return true;
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (!isInputValid()) return;
            LoginInput input = new LoginInput(login.Text, password.Text); 
            Account accountObj = AccountOperations.CreateUserAccountByUsernameAndPassword(input);
            Createaccount createaccount = new Createaccount(accountObj);
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
            System.Windows.Forms.Application.Exit();
        }

        private void returnlog_Click(object sender, EventArgs e)
        {
            log_in log_In = new log_in();
            log_In.Show();
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
                passwordagain.Focus();
            }
        }

        private void passwordagain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                register.PerformClick();
            }
        }
    }
}
