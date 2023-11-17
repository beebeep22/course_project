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
    public partial class Account : Form
    {
        public Account(string firstName, string lastName, string patronymic2,string age2,string gender)
        {
            InitializeComponent();

            // Присвоення значень полям акаунту з Createaccount
            name.Text = firstName;
            surname.Text = lastName;
            patronymic.Text = patronymic2;
            age.Text = age2;
            sex.Text = gender;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            //дані,які не змінюємо
            age.ReadOnly = true; //можно ли менять возраст?
            sex.ReadOnly = true;

            //інвалідність
            invalid.Items.Add("-");
            invalid.Items.Add("I");
            invalid.Items.Add("II");
            invalid.Items.Add("III");
            invalid.Items.Add("я інвалід у меня ножка боліт");

            //патологічні захворювання
            pathdiseas.Items.Add("-");

            //алергії
            alergic.Items.Add("-");
            alergic.Items.Add("на математику");

            //регіон
            region.Items.Add("Запорізька область");
            region.Items.Add("Харьківська область");
            region.Items.Add("Дніпропетровська область");
            region.Items.Add("Київська область");
            region.Items.Add("Винницька область");
            region.Items.Add("Житомирьська область");
            region.Items.Add("Львівська область");
        }

        //збереження змін
        private void save_Click(object sender, EventArgs e)
        {
           
        }

        //

    }
}
