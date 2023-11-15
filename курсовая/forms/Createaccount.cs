using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая.forms
{
    public partial class Createaccount : Form
    {
        public Createaccount()
        {
            InitializeComponent();
            this.Size = new Size(391, 570);
        }


        private void Createaccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Поле ім'я незаповнене");
            }
            else if (surname.Text == "")
            {
                MessageBox.Show("Поле прізвища незаповнене");
            }
            else if (patronymic.Text == "")
            {
                MessageBox.Show("Поле по-батькові незаповнене");
            }
            else if (age.Text == "")
            {
                MessageBox.Show("Поле дати народження незаповнене");
            }
            else if (!women.Checked && !Men.Checked)
            {
                MessageBox.Show("Стать не обрано");
            }
            else {
                Golovna golovna = new Golovna();
                golovna.Show();
                string firstName = name.Text;
                string lastName = surname.Text;
                string patronymicc = patronymic.Text;
                string a = age.Text;
                string gender = Men.Checked ? "М" : "Ж";
                Account accountForm = new Account(firstName, lastName, patronymicc,a,gender);
                golovna.OpenChildForm(accountForm, sender);
                golovna.labeltitle.Text = "Привіт, " + name.Text + "!";
                this.Hide();
            }
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
