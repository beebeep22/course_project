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
    public partial class AdminResponseCreation : Form
    {

        private DbAdminOperations AdminOperations { get; set; }
        private UserRequest Request { get; set; }
        public AdminResponseCreation(UserRequest Request)
        {
            InitializeComponent();
            this.AdminOperations = new DbAdminOperations();
            this.Request = Request;
        }

        private bool ResponseInputValid()
        {
            //нужно ли на тему и описание или можно "на розгляді" без темы и описания,а принятие/отказ с темой и описанием
            // нетб всегда тема и описание
            // "заявка на розгляді,бо вона дуже гарна,сидимо і дивимося"
            try
            {
                if (themeresponse.Text == "")
                {
                    throw new Exception("Ви не ввели тему відповіді");
                }
                else if (richcontentBox.Text == "")
                {
                    throw new Exception("Ви не ввели опис відповіді");
                }
                else if (!statusAccepted.Checked && !statusOnReview.Checked && !statusRejected.Checked)
                {
                    throw new Exception("Ви не обрали статусу заявки");
                }
                return true;
            }
            catch (Exceptions ex)
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.Text = "Помилка";
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
                return false;
            }
        }

        private void createResponse_Click(object sender, EventArgs e)
        {
            if (!ResponseInputValid())
                return;

            string inputStatus;
            if (statusAccepted.Checked) inputStatus = "Прийнято";
            else if (statusOnReview.Checked) inputStatus = "На розгляді";
            else if (statusRejected.Checked) inputStatus = "Відхилено";
            else return;

            UserRequestResponse response = new UserRequestResponse(
                Topic: themeresponse.Text,
                Content: richcontentBox.Text,
                Status: inputStatus,
                UserRequestObj: this.Request
                );
            AdminOperations.CreateUserRequestResponse(response);
            this.Hide();
        }

        private async void askAIAndSetResponse(string theme_request,int tokens)
        {
            richcontentBox.Text = await AdminOperations.GetAiResponse(this.Request, theme_request, tokens);
        }

        private void askAIButton_Click(object sender, EventArgs e)
        {
            string topic_request = "";
            int tokens = 0;
            bool generate = false;
            Improvement_with_AI improvement_With_AI = new Improvement_with_AI();
            if (improvement_With_AI.ShowDialog() == DialogResult.OK)
            {
                generate = true;
                topic_request = improvement_With_AI.TopicForAIRequest.Text;
                int.TryParse(improvement_With_AI.tokenForAI.Text, out int token);
                tokens = token;
            }

            if (generate) 
            {
                askAIAndSetResponse(topic_request, tokens);
            }
        }
    }
}
