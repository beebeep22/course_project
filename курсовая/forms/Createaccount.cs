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
    public partial class Createaccount : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }
        public Createaccount(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
            this.Size = new Size(391, 570);
        }


        private void Createaccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool isInputValid()
        {
            if (name.Text == "")
            {
                MessageBox.Show("Поле ім'я незаповнене");
                return false;
            }
            else if (surname.Text == "")
            {
                MessageBox.Show("Поле прізвища незаповнене");
                return false;
            }
            else if (patronymic.Text == "")
            {
                MessageBox.Show("Поле по-батькові незаповнене");
                return false;
            }
            else if (age.Text == "")
            {
                MessageBox.Show("Поле дати народження незаповнене");
                return false;
            }
            else if (!women.Checked && !Men.Checked)
            {
                MessageBox.Show("Стать не обрано");
                return false;
            }
        return true;
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (!isInputValid()) return;
            UserDetails details = new UserDetails(
                FirstName: name.Text,
                LastName: surname.Text,
                MiddleName: patronymic.Text,
                //Gender: Men.Checked ? "Male" : "Female", сразу на украинсоком может?
                Gender: Men.Checked ? "M" : "Ж",
                Age: age.Text 
            );
            UserOperations.UpdateUserDetails(AccountObj, details);
            Golovna golovna = new Golovna(AccountObj);
            golovna.Show();
            //string firstName = name.Text;
            //string lastName = surname.Text;
            //string patronymicc = patronymic.Text;
            //string a = age.Text;
            //string gender = Men.Checked ? "М" : "Ж";
            //AccountMenu accountForm = new AccountMenu(firstName, lastName, patronymicc, a, gender);
            AccountMenu accountForm = new AccountMenu(AccountObj);
            golovna.OpenChildForm(accountForm, sender);
            golovna.labeltitle.Text = "Привіт, " + name.Text + "!";
            this.Hide();
        }

        private void Createaccount_Load(object sender, EventArgs e)
        {
            for(int i = 16; i <= 99; i++)
            {
                age.Items.Add(i);
            }
        }

        private void Men_CheckedChanged(object sender, EventArgs e)
        {
            if (women.Checked)
            {
                Men.Checked = false;
            }
        }

        private void women_CheckedChanged(object sender, EventArgs e)
        {
            if (Men.Checked)
            {
                women.Checked = false;
            }
        }
    }
}
