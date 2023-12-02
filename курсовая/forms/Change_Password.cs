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
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private bool InpitValid()
        {
            try
            {
                List<string> errorMessages = new List<string>();
                if (new_password.Text == "")
                {
                    errorMessages.Add("Поле пароля незаповнене");
                }
                else if (new_password.Text.Length < 12)
                {
                    errorMessages.Add("Не менше 12 символів у паролі!");
                }
                else if (!IsLatinInput(new_password.Text))
                {
                    errorMessages.Add("Пароль повинен містити тільки латинські символи.");
                }
                else if (new_password_again.Text == "")
                {
                    errorMessages.Add("Поле повторення пароля незаповнене");
                }
                else if (new_password.Text != new_password_again.Text)
                {
                    errorMessages.Add("Паролі не співпадають!");
                }
                if (errorMessages.Count > 0)
                {
                    string errorMessage = string.Join("\r\n", errorMessages);
                    throw new Exceptions(errorMessage);
                }
                return true;
            }
            catch (Exception ex)
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.Text = "Помилка зміни паролю";
                warning_Message.pictureBox1.Image = Properties.Resources.free_icon_cat_5772431;
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
                return false;
            }
        }

        public bool IsLatinInput(string input)
        {

            foreach (char c in input)
            {
                if (c >= 'А' && c <= 'я')
                {
                    return false;
                }
            }

            return true;
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            if (!InpitValid()) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
