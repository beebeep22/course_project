using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using курсовая.classes;

namespace курсовая.forms
{
    public partial class AccountMenu : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }
        private DbAccountOperations AccountOperations { get; set; }

        private ComboBox[] comboBoxes;
        public AccountMenu(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
            this.AccountOperations = new DbAccountOperations();
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
            UpdateProfilePicture();

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
            alergic.Items.Add("Харчова алергія");
            alergic.Items.Add("Контактна алергія");
            alergic.Items.Add("Вдихальна алергія");
            alergic.Items.Add("Сенсибілізація до отрути");
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
                Warning_message warning_Message = new Warning_message();
                warning_Message.Text = "Помилка даних";
                warning_Message.outputText.Text = "Некоректно введені дані";
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
                    Warning_message warning_Message = new Warning_message();
                    warning_Message.Text = "Попередження";
                    warning_Message.outputText.TextAlign = HorizontalAlignment.Center;
                    warning_Message.outputText.Text = "Після внесення змін верефікація спаде!";
                    flag = true;
                    if (warning_Message.ShowDialog() == DialogResult.OK)
                    {
                        comboBoxChanged = true;
                    }
                }
            }
            return comboBoxChanged;

        }
        //збереження змін
        private void save_Click(object sender, EventArgs e)
        {
            bool changesDetected = false;
            if (!PersonalData()) return;
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (AccountObj.UserDetails.Approved == true)
                {
                    if (SelectedDataChanged(comboBox, EventArgs.Empty))
                    {
                        changesDetected = true;
                        this.AccountObj.UserDetails.Approved = false;
                    }
                    else
                    {
                        changesDetected = false;
                        break;
                    }

                }
                else
                {
                    changesDetected = true;
                    break;
                }
            }
            if (changesDetected)
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
                Warning_message warning_Message = new Warning_message();
                warning_Message.Text = "Успіх!";
                warning_Message.outputText.Text = "Зміни збережено!";
                warning_Message.pictureBox1.Image = Properties.Resources.free_icon_munchkin_cat_6855253;
                warning_Message.ShowDialog();
            }
            else
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.outputText.Text = "Зміни не збережено!";
                warning_Message.pictureBox1.Image = Properties.Resources.free_icon_cat_5772431;
                warning_Message.ShowDialog();
            }
        }

        private void UpdateProfilePicture()
        {
            byte[] profileImage = this.AccountObj?.ProfileImage;
            if (profileImage == null || profileImage.Length <= 0) return;
            Image image;
            using (MemoryStream ms = new MemoryStream(profileImage))
            {
                image = Image.FromStream(ms);
            }
            avatar.Image = image;
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
                    this.AccountOperations.UpdateAccountProfileImage(this.AccountObj, imageLocation);
                    UpdateProfilePicture(); 
                    //avatar.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.Text = "Помилка";
                warning_Message.outputText.Text = "Виникла помилка";
                warning_Message.pictureBox1.Image = Properties.Resources.free_icon_cat_5772431;
                warning_Message.ShowDialog();
            }

        }


    }
}
