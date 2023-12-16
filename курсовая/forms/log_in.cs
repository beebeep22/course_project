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
            try
            {
                if (input.Username == "")
                {
                    throw new Exceptions("Поле логіна незаповнене");
                }
                else if (input.Password == "")
                {
                    throw new Exceptions("Поле пароля незаповнене");
                }
                return true;
            }
            catch (Exceptions ex)
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
                return false;
            }
        }

        private void entrance_Click(object sender, EventArgs e)
        {
            LoginInput input = new LoginInput(login.Text, password.Text);
            if (!isInputValid(input)) return;
            try
            {
                Account accountObj = AccountOperations.GetAccountByUsernameAndPassword(input);
                if (accountObj == null)
                {
                    throw new Exceptions("Поле логіна чи пароля неправильне!");
                }
                if (accountObj.Role == "user")
                {
                    if (accountObj.UserDetails == null)
                    {
                        // forward to user details form to fill in the user data if the user has not done so yet
                        Createaccount createaccount = new Createaccount(accountObj);
                        createaccount.Show();
                        this.Hide();
                    }
                    else
                    {
                        Golovna golovna = new Golovna(accountObj);
                        golovna.Show();
                        this.Hide();
                        AccountMenu accountForm = new AccountMenu(accountObj);
                        golovna.OpenChildForm(accountForm, sender);
                        golovna.labeltitle.Text = "З поверненням!";
                    }

                }
                else if (accountObj.Role == "admin")
                {
                    Golovna_Admin golovna_Admin = new Golovna_Admin(accountObj);
                    golovna_Admin.Show();
                    this.Close();

                    Account_admin account_Admin = new Account_admin(accountObj);
                    golovna_Admin.OpenChildForm(account_Admin, sender);
                }
            }
            catch(Exceptions ex)
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.pictureBox1.Image = Properties.Resources.free_icon_cat_5772431;
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
                return;
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
