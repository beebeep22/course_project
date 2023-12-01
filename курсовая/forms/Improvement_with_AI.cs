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
    public partial class Improvement_with_AI : Form
    {
        public Improvement_with_AI()
        {
            InitializeComponent();
        }

        private bool InpitValid()
        {
            try
            {
                List<string> errorMessages = new List<string>();
                int.TryParse(tokenForAI.Text, out int token);
                if(TopicForAIRequest.Text == "")
                {
                    errorMessages.Add("Ви не заповнили поле теми");
                }
                if(tokenForAI.Text == "")
                {
                    errorMessages.Add("Ви не ввели кількість символів");
                }
                else if (token > 1000 || token < 50)
                {
                    errorMessages.Add("Некоректне введення кількості символів");
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
                warning_Message.Text = "Помилка реєстрації";
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
                return false;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (!InpitValid()) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Improvement_with_AI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
