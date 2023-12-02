using System;
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
    public partial class Settings : Form
    {
        private Account AccountObj { get; set; }
        private DbAccountOperations AccountOperations { get; set; }

        public Settings(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.AccountOperations = new DbAccountOperations();
        }

        private void deleteaccount_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form form in formsToClose)
            {
                if (form != this)
                {
                    form.Close();
                }
            }

            AccountOperations.removeAccount(this.AccountObj);
            Thread thread = new Thread(() =>
            {
                Application.Run(new log_in());
            });

            thread.Start();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            Change_Password change_Password = new Change_Password();
            if (change_Password.ShowDialog() == DialogResult.OK)
            {
                string newpassword = change_Password.new_password.Text;
                this.AccountOperations.ChangePassword(this.AccountObj, newpassword);
            }
        }
    }
}
