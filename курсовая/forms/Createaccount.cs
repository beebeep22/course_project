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
            name.KeyDown += name_KeyDown;
            surname.KeyDown += surname_KeyDown;
            patronymic.KeyDown += patronymic_KeyDown;
            age.KeyDown += age_KeyDown;
        }


        private void Createaccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool isInputValid()
        {
            try
            {
                List<string> errorMessages = new List<string>();

                if (name.Text == "")
                {
                    errorMessages.Add("Поле ім'я незаповнене");
                }

                if (surname.Text == "")
                {
                    errorMessages.Add("Поле прізвища незаповнене");
                }

                if (patronymic.Text == "")
                {
                    errorMessages.Add("Поле по-батькові незаповнене");
                }

                if (age.Text == "")
                {
                    errorMessages.Add("Поле віку незаповнене");
                }
                else if (!int.TryParse(age.Text, out int ageValue))
                {
                    errorMessages.Add("Поле віку має бути числовим значенням");
                }
                else if (ageValue < 16 || ageValue > 99)
                {
                    errorMessages.Add("Поле віку заповнене некоректно");
                }

                if (!women.Checked && !Men.Checked)
                {
                    errorMessages.Add("Стать не обрано");
                }

                if (!IsCyrillicInput(name.Text) || !IsCyrillicInput(surname.Text) || !IsCyrillicInput(patronymic.Text))
                {
                    errorMessages.Add("ПІБ повино бути кирилицею");
                }

                if (errorMessages.Count > 0)
                {
                    string errorMessage = string.Join("\r\n", errorMessages);
                    throw new Exceptions(errorMessage);
                }

                return true;
            }
            catch (Exceptions ex)
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.Text = "Помилка створення облікового запису";
                warning_Message.pictureBox1.Image = Properties.Resources.free_icon_cat_5772431;
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
                return false;
            }
        }

        public bool IsCyrillicInput(string input)
        {
            foreach (char c in input)
            {
                if (!(c >= 'А' && c <= 'Я') && !(c >= 'а' && c <= 'я') && c != 'і' && c != 'І')
                {
                    return false;
                }
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
                Gender: Men.Checked ? "M" : "Ж",
                Age: age.Text 
            );
            UserOperations.UpdateUserDetails(AccountObj, details);
            Golovna golovna = new Golovna(AccountObj);
            golovna.Show();
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

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                surname.Focus();
            }
        }
        private void surname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                patronymic.Focus();
            }
        }
        private void patronymic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                age.Focus();
            }
        }
        private void age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }


    }
}
