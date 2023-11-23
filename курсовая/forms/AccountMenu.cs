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
    public partial class AccountMenu : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }
        public AccountMenu(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
            // Присвоення значень полям акаунту з Createaccount
            name.Text = AccountObj?.UserDetails?.FirstName ?? "";
            surname.Text = AccountObj?.UserDetails?.LastName ?? "";
            patronymic.Text = AccountObj?.UserDetails?.MiddleName ?? "";
            age.Text = AccountObj?.UserDetails?.Age ?? "";
            sex.Text = AccountObj?.UserDetails?.Gender ?? "";
            pathdiseas.Text = AccountObj?.UserDetails?.Diseases ?? "";
            alergic.Text = AccountObj?.UserDetails?.Allergies ?? "";
            invalid.Text = AccountObj?.UserDetails?.DisabilityLevel ?? "";
            region.Text = AccountObj?.UserDetails?.Region ?? "";
        }

        private void Account_Load(object sender, EventArgs e)
        {
            //дані,які не змінюємо
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
            this.AccountObj.UserDetails.FirstName = name.Text;
            this.AccountObj.UserDetails.LastName = surname.Text;
            this.AccountObj.UserDetails.MiddleName = patronymic.Text;
            this.AccountObj.UserDetails.Age = age.Text;
            this.AccountObj.UserDetails.Region = region.Text;
            this.AccountObj.UserDetails.DisabilityLevel = invalid.Text;
            this.AccountObj.UserDetails.Diseases = pathdiseas.Text;
            this.AccountObj.UserDetails.Allergies = alergic.Text;
            this.UserOperations.UpdateUserDetails(this.AccountObj, this.AccountObj.UserDetails);
        }

        private void avatarka_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "Зображення JPEG (*.jpg)|*.jpg|Зображення PNG (*.png)|*.png|Всі файли (*.*)|*.*";

                if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openfile.FileName;
                    avatar.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
