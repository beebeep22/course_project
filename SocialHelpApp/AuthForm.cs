using SocialHelpApp.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SocialHelpApp
{
    public partial class AuthForm : Form
    {
        private DbAccountOperations AccountOperations { get; set; }

        public AuthForm()
        {
            InitializeComponent();
            AccountOperations = new DbAccountOperations();
        }

        private void GoToUserMenuForm(Account accountObj)
        {
            UserMenuForm userMenuForm = new UserMenuForm(accountObj);
            userMenuForm.Show();
            this.Hide();
        }

        private void GoToAdminMenuForm(Account accountObj)
        {

        }

        private LoginInput GetLoginInput()
        {
            return new LoginInput(authInputUsername.Text.Trim(), authInputPassword.Text.Trim());

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            LoginInput loginInput = GetLoginInput();
            if (loginInput.Username != "" && loginInput.Password != "")
            {
                Account account = AccountOperations.GetAccountByUsernameAndPassword(loginInput);
                if (account != null)
                {
                    Console.WriteLine("Logged in with username " + loginInput.Username);
                    if (account.Role == "user")
                    {
                        GoToUserMenuForm(account);
                    }
                }
                else
                {
                    Console.WriteLine("Account not found or incorrect credentials.");
                }                
            }
        }

        private bool IsCredentialsValid(LoginInput loginInput)
        {
            // TODO: add validation for new user: 
            //username doesn't starts with number
            //password >= 6 symbols,
            //username doesn't exists etc. 
            //username and password is not empty
            return !AccountOperations.IsUsernameAlreadyExists(loginInput.Username);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            LoginInput loginInput = GetLoginInput();
            if (loginInput.Username != "" && loginInput.Password != "")
            {
                Account account = AccountOperations.CreateUserAccountByUsernameAndPassword(loginInput);
                if (account != null)
                {
                    Console.WriteLine("Created account with username " + loginInput.Username);

                }
                else
                {
                    Console.WriteLine("Cannot create account with username " + loginInput.Username);
                }
            }
        }

    }
}
