using System;
using System.Collections.Generic;
using System.Windows.Forms;
using курсовая.classes;

namespace курсовая.forms
{
    public partial class create_notification : Form
    {
        private Account AccountObj { get; set; }
        private DbAdminOperations AdminOperations { get; set; }
        public create_notification()
        {
            this.AccountObj = AccountObj;
            this.AdminOperations = new DbAdminOperations();
            InitializeComponent();
        }

        private bool isNotificationInputValid()
        {
            try
            {
                List<string> errorMessages = new List<string>();
                if (themenotification.Text == "")
                {
                    errorMessages.Add("Тема повідомлення не введена.");
                }
                if (content_notification.Text == "")
                {
                    errorMessages.Add("Опис повідомлення не введен.");
                }
                if (!int.TryParse(agefrom.Text, out int ageValue) || !int.TryParse(ageupto.Text, out int age2Value))
                {
                    errorMessages.Add("Поле віку має бути числовим значенням");
                }
                else if (agefrom.SelectedItem != null && ageupto.SelectedItem != null)
                {
                    int selectedValue1 = Convert.ToInt32(agefrom.SelectedItem);
                    int selectedValue2 = Convert.ToInt32(ageupto.SelectedItem);

                    if (selectedValue1 == selectedValue2)
                    {
                        errorMessages.Add("Некорректно обраний вік.");
                    }
                    else if (selectedValue1 > selectedValue2)
                    {
                        errorMessages.Add("Некорректно обраний вік.");
                    }
                }
                if (!ContainsDigit(region.Text) || !ContainsDigit(pathdiseas.Text)|| !ContainsDigit(alergic.Text)) 
                {
                    errorMessages.Add("Некоректно введений фільтр");
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
                warning_Message.Text = "Помилка створення загального повідомлення";
                warning_Message.pictureBox1.Image = Properties.Resources.free_icon_cat_5772431;
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
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

        private void send_Click(object sender, EventArgs e)
        {
            if (!isNotificationInputValid()) return;

            TargetFilters filters = new TargetFilters(
                AgeTo: ageupto.SelectedItem?.ToString() ?? "",
                AgeFrom: agefrom.SelectedItem?.ToString() ?? "",
                Gender: men.Checked ? "M" : "Ж", 
                Region: region.Text,
                Diseases: pathdiseas.Text,
                DisabilityLevel: invalid.Text,
                Allergies: alergic.Text
            );

            Notification notification = new Notification(
                Topic: themenotification.Text,
                Content: content_notification.Text,
                Filters: filters
            );

            AdminOperations.CreateNotification(notification); 

            this.Hide();
        }

        private void create_notification_Load(object sender, EventArgs e)
        {
            for (int i = 16; i <= 99; i++)
            {
                agefrom.Items.Add(i);
                ageupto.Items.Add(i);
            }

            invalid.Items.Add("-");
            invalid.Items.Add("I");
            invalid.Items.Add("II");
            invalid.Items.Add("III");

            //патологічні захворювання
            pathdiseas.Items.Add("курсове захворювання");

            //алергії
            alergic.Items.Add("на курсач");

            //регіон
            region.Items.Add("Запорізька область");
            region.Items.Add("Харьківська область");
            region.Items.Add("Дніпропетровська область");
            region.Items.Add("Київська область");
            region.Items.Add("Винницька область");
            region.Items.Add("Житомирьська область");
            region.Items.Add("Львівська область");

        }

        private void men_CheckedChanged(object sender, EventArgs e)
        {
            if (men.Checked)
            {
                women.Checked = false;
            }
        }

        private void women_CheckedChanged(object sender, EventArgs e)
        {
            if (women.Checked)
            {
                men.Checked = false;
            }
        }
    }
}
