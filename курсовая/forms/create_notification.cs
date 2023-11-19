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
    public partial class create_notification : Form
    {
        public create_notification()
        {
            InitializeComponent();
        }
        private void send_Click(object sender, EventArgs e)
        {
            //перепроверить в какой момент это должно проверятся
            if (themenotification.Text == "")
            {
                MessageBox.Show("Тема повідомлення не введена.");
            }
            else if (content_notification.Text == "")
            {
                MessageBox.Show("Опис повідомлення не введен.");
            }
            else if (agefrom.SelectedItem != null && ageupto.SelectedItem != null)
            {
                int selectedValue1 = Convert.ToInt32(agefrom.SelectedItem);
                int selectedValue2 = Convert.ToInt32(ageupto.SelectedItem);

                if (selectedValue1 == selectedValue2)
                {
                    MessageBox.Show("Некорректно обраний вік.");
                }
                else if (selectedValue1 > selectedValue2)
                {
                    MessageBox.Show("Некорректно обраний вік.");
                }
                else
                    this.Hide();
            }
            else if (agefrom.SelectedItem != null || ageupto.SelectedItem != null)
            {
                MessageBox.Show("Оберіть оба значення.");
            }
            else if (agefrom.Text == "" && ageupto.Text == "" && region.Text == "" && pathdiseas.Text == "" && invalid.Text == "" && alergic.Text == "" && men.Checked == false && women.Checked == false)
            {
                //не знаю нужно ли
                MessageBox.Show("Ви не обрали жодного фільтра.");
            }
            else if (agefrom.Text != "" || ageupto.Text != "" || region.Text != "" || pathdiseas.Text != "" || invalid.Text != "" || alergic.Text != "" || men.Checked != false || women.Checked != false)
            {
                this.Hide();
            }
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
