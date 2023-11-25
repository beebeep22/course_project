using Amazon.Runtime.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace курсовая.forms
{
    public partial class Zayavki : Form
    {
        private Account AccountObj { get; set; }
        private DbAdminOperations AdminOperations { get; set; }
        private List<UserRequest> AllUserRequests { get; set; }

        private Golovna_Admin parentForm;

        public Zayavki(Account AccountObj, Golovna_Admin parentForm)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.AdminOperations = new DbAdminOperations();
            this.AllUserRequests = AdminOperations.GetUserRequests();
            this.parentForm = parentForm;
            InitializeDataGridView();
        }

        private void Zayavki_Load(object sender, EventArgs e)
        {
            filterByRegion.Items.Add("Запорізька область");
            filterByRegion.Items.Add("Харьківська область");
            filterByRegion.Items.Add("Дніпропетровська область");
            filterByRegion.Items.Add("Київська область");
            filterByRegion.Items.Add("Винницька область");
            filterByRegion.Items.Add("Житомирьська область");
            filterByRegion.Items.Add("Львівська область");
        }


        private void InitializeDataGridView()
        {

            userRequestsTable.DataSource = this.AllUserRequests;

            userRequestsTable.Columns["_id"].Visible = false;
            userRequestsTable.Columns["ApplicantId"].Visible = false;
            userRequestsTable.Columns["Content"].Visible = false;

            userRequestsTable.Columns["requestTopic"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            userRequestsTable.Columns["requestTopic"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            userRequestsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            userRequestsTable.CellFormatting += userRequestsTable_CellFormatting;
            userRequestsTable.SelectionChanged += listOfRequests_SelectionChanged;
            userRequestsTable.CellDoubleClick += new DataGridViewCellEventHandler(this.userRequestsTable_CellDoubleClick);
            userRequestsTable.ClearSelection();
        }

        private void listOfRequests_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void userRequestsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == userRequestsTable.Columns["responseStatusColumn"].Index)
            {
                // Format the "responseStatusColumn" to display "No response" if Response is null
                e.Value = (e.Value as UserRequestResponse)?.Status ?? "Не переглянуто";
            }
            if (e.ColumnIndex == userRequestsTable.Columns["applicantUsername"].Index)
            {
                e.Value = (e.Value as Account)?.Username;
            }
            else if (e.ColumnIndex == userRequestsTable.Columns["applicantRegion"].Index)
            {
                e.Value = (e.Value as Account)?.UserDetails?.Region;
            }
            e.FormattingApplied = true;
        }

        private void userRequestsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < userRequestsTable.Rows.Count)
            {
                DataGridViewRow clickedRow = userRequestsTable.Rows[e.RowIndex];
                UserRequest selectedRequest = (UserRequest)clickedRow?.DataBoundItem;

                string topic;
                string content;
                string username;
                string Fullname;
                string region;
                string age;
                string sex;
                string alergic;
                string pathol_diseases;
                string invalid;

                if (selectedRequest != null)
                {
                    topic = selectedRequest?.Topic ?? "Немає інформації про заявника";
                    content = selectedRequest?.Content ?? "Немає інформації про заявника";
                    username = selectedRequest.ApplicantObj.Username ?? "Немає інформації про заявника";
                    Fullname = selectedRequest.ApplicantObj?.UserDetails?.GetFullName() ?? "Немає інформації про заявника";
                    region = selectedRequest.ApplicantObj?.UserDetails?.Region ?? "Немає інформації про заявника";
                    age = selectedRequest.ApplicantObj?.UserDetails?.Age ?? "Немає інформації про заявника";
                    sex = selectedRequest.ApplicantObj?.UserDetails?.Gender ?? "Немає інформації про заявника";
                    alergic = selectedRequest.ApplicantObj?.UserDetails?.Allergies ?? "Немає інформації про заявника";
                    pathol_diseases = selectedRequest.ApplicantObj?.UserDetails?.Diseases ?? "Немає інформації про заявника";
                    invalid = selectedRequest.ApplicantObj?.UserDetails?.DisabilityLevel ?? "Немає інформації про заявника";

                    inform Inform = new inform(topic, content, Fullname, username, region, age, sex, alergic, invalid, pathol_diseases);
                    Inform.Show();
                }
            }
            
        }


        private void createnotif_Click(object sender, EventArgs e)
        {
            if (this.AccountObj?.AdminDetails?.CanCreateNotifications != true)
            {
                MessageBox.Show("У вас нема права на створення повiдомлення");
                return;
            }
            create_notification create_Notification = new create_notification();
            create_Notification.Show();
        }

        private void reply_request_Click(object sender, EventArgs e)
        {
            if (userRequestsTable.SelectedCells.Count > 0)
            {
                int selectedRowIndex = userRequestsTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = userRequestsTable.Rows[selectedRowIndex];
                UserRequest selectedUserRequest = (UserRequest)selectedRow.DataBoundItem;
                replyOnRequest(selectedUserRequest);
                parentForm.OpenChildForm(new forms.AdminResponseCreation(selectedUserRequest),sender);
            }
        }

        private void replyOnRequest(UserRequest Request)
        {
            if (this.AccountObj?.AdminDetails?.CanRespondOnRequests != true)
            {
                MessageBox.Show("У вас нема права відповідати на повідомлення");
                return;
            }
            /*AdminResponseCreation adminResponseCreation = new AdminResponseCreation(Request);
            adminResponseCreation.Location = new Point(520, 262);
            adminResponseCreation.Show();*/


            //я пыталась открыть внутри Golovna_Admin,но не вышло
            /*this.Close();
            AdminResponseCreation adminResponseCreation = new AdminResponseCreation();
            adminResponseCreation.MdiParent = this.MdiParent;
            adminResponseCreation.Show();*/

        }

        private void FilterDataGridViewByRegion(string region)
        {
            var filteredUserRequests = this.AllUserRequests 
                .Where(request =>
                {
                    string rowRegion = request.ApplicantObj?.UserDetails?.Region ?? "";
                    return rowRegion == region;
                })
                .ToList();
            userRequestsTable.DataSource = filteredUserRequests;
        }


        private void filterByRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegion = filterByRegion.SelectedItem.ToString();
            FilterDataGridViewByRegion(selectedRegion);
        }
    }
}
