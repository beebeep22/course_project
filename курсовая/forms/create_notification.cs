using System;
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
            //перепроверить в какой момент это должно проверятся
            if (themenotification.Text == "")
            {
                MessageBox.Show("Тема повідомлення не введена.");
                return false;
            }
            else if (content_notification.Text == "")
            {
                MessageBox.Show("Опис повідомлення не введен.");
                return false;
            }
            else if (agefrom.SelectedItem != null && ageupto.SelectedItem != null)
            {
                int selectedValue1 = Convert.ToInt32(agefrom.SelectedItem);
                int selectedValue2 = Convert.ToInt32(ageupto.SelectedItem);

                if (selectedValue1 == selectedValue2)
                {
                    MessageBox.Show("Некорректно обраний вік.");
                    return false;
                }
                else if (selectedValue1 > selectedValue2)
                {
                    MessageBox.Show("Некорректно обраний вік.");
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
                Gender: null, // TODO: add gender selection in form
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
