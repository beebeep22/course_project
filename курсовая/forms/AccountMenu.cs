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

        private ComboBox[] comboBoxes;
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

            comboBoxes = new ComboBox[] { invalid, pathdiseas,alergic };

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
            pathdiseas.Items.Add("Гострі лейкемії");
            pathdiseas.Items.Add("Аутоімунний тиреоїдит ");
            pathdiseas.Items.Add("Цукровий діабет");
            pathdiseas.Items.Add("Фіброз та цироз печінки");
            pathdiseas.Items.Add("Печінкова недостатність");
            pathdiseas.Items.Add("Природжений іхтіоз");
            pathdiseas.Items.Add("Природжена алопеція");
            pathdiseas.Items.Add("Хронічна ниркова недостатність");
            pathdiseas.Items.Add("Хронічний тубулоінтерстиціальний нефрит ");

            //алергії
            //алергии будут на что-то или виды?
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

        private bool PersonalData()
        {
            int errorcount = 0;
            try
            {
                if (!ContainsDigit(pathdiseas.Text))
                {
                    errorcount++;
                }
                if (!ContainsDigit(alergic.Text))
                {
                    errorcount++;
                }
                if (errorcount > 0)
                {
                    throw new Exceptions("Помилка даних");
                }
                else 
                    return true;
            }
            catch(Exceptions ex)
            {
                MessageBox.Show("Некоректно введені дані", "Помилка даних");
                return false;
            }
        }

        public bool ContainsDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        private bool flag;
        private bool SelectedDataChanged(object sender, EventArgs e)
        {
            flag = false;
            bool comboBoxChanged = false;
            if (sender is ComboBox comboBox)
            {
                string selectedValue = comboBox.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedValue) && !flag)
                {
                    MessageBox.Show("Після внесення змін верефікація спаде!");
                    flag = true;
                    comboBoxChanged = true;
                }
            }
            return comboBoxChanged;

        }
        //збереження змін
        private void save_Click(object sender, EventArgs e)
        {
            if (!PersonalData()) return;
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (SelectedDataChanged(comboBox, EventArgs.Empty))
                {
                    this.AccountObj.UserDetails.Approved = false;
                }
            }
            this.AccountObj.UserDetails.FirstName = name.Text;
            this.AccountObj.UserDetails.LastName = surname.Text;
            this.AccountObj.UserDetails.MiddleName = patronymic.Text;
            this.AccountObj.UserDetails.Age = age.Text;
            this.AccountObj.UserDetails.Region = region.Text;
            this.AccountObj.UserDetails.DisabilityLevel = invalid.Text;
            this.AccountObj.UserDetails.Diseases = pathdiseas.Text;
            this.AccountObj.UserDetails.Allergies = alergic.Text;
            this.UserOperations.UpdateUserDetails(this.AccountObj, this.AccountObj.UserDetails);
            MessageBox.Show("Зміни збережено");
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
