using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using курсовая.classes;

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
            filterByRegion.Items.Add("-");
            filterByRegion.SelectedIndex = filterByRegion.Items.Count - 1;
            userRequestsTable.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
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

            userRequestsTable.Columns["ProofImageData"].Visible = false;


            userRequestsTable.CellFormatting += userRequestsTable_CellFormatting;
            userRequestsTable.CellDoubleClick += new DataGridViewCellEventHandler(this.userRequestsTable_CellDoubleClick);
            userRequestsTable.ClearSelection();

            // sort on column header click
            userRequestsTable.ColumnHeaderMouseClick += userRequestsTable_ColumnHeaderMouseClick;

        }

        private void userRequestsTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = userRequestsTable.Columns[e.ColumnIndex];

            if (clickedColumn != null)
            {
                string propertyName = clickedColumn.Name;
                switch (propertyName)
                {
                    case "requestTopic":
                        this.AllUserRequests = AllUserRequests.OrderBy(request => request.Topic).ToList();
                        break;
                    case "responseStatus":
                        this.AllUserRequests = AllUserRequests.OrderBy(request => request?.Response?.Status).ToList();
                        break;
                    case "applicantUsername":
                        this.AllUserRequests = AllUserRequests.OrderBy(request => request.ApplicantObj.Username).ToList();
                        break;
                    case "applicantRegion":
                        this.AllUserRequests = AllUserRequests.OrderBy(request => request.ApplicantObj.UserDetails.Region).ToList();
                        break;
                }
                userRequestsTable.DataSource = this.AllUserRequests;

            }

        }


        private void userRequestsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == userRequestsTable.Columns["responseStatus"].Index)
            {
                // Format the "responseStatusColumn" to display "No response" if Response is null
                //e.Value = (e.Value as UserRequestResponse)?.Status ?? "Не переглянуто";
                UserRequestResponse response = e.Value as UserRequestResponse;
                e.Value = response?.Status ?? "Не переглянуто";
                e.FormattingApplied = true;
            }
            else if (e.ColumnIndex == userRequestsTable.Columns["applicantUsername"].Index)
            {
                e.Value = (e.Value as Account)?.Username ?? "No username";
                e.FormattingApplied = true;
            }
            else if (e.ColumnIndex == userRequestsTable.Columns["applicantRegion"].Index)
            {
                e.Value = (e.Value as Account)?.UserDetails?.Region ?? "Дані відсутні";
                e.FormattingApplied = true;
            }
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
                byte[] proof;
                string noInfoText = "Немає інформації про заявника";

                if (selectedRequest != null)
                {
                    topic = selectedRequest?.Topic ?? noInfoText;
                    content = selectedRequest?.Content ?? noInfoText;
                    username = selectedRequest.ApplicantObj.Username ?? noInfoText;
                    Fullname = selectedRequest.ApplicantObj?.UserDetails?.GetFullName() ?? noInfoText;
                    region = selectedRequest.ApplicantObj?.UserDetails?.Region ?? noInfoText;
                    age = selectedRequest.ApplicantObj?.UserDetails?.Age ?? noInfoText;
                    sex = selectedRequest.ApplicantObj?.UserDetails?.Gender ?? noInfoText;
                    alergic = selectedRequest.ApplicantObj?.UserDetails?.Allergies ?? noInfoText;
                    pathol_diseases = selectedRequest.ApplicantObj?.UserDetails?.Diseases ?? noInfoText;
                    invalid = selectedRequest.ApplicantObj?.UserDetails?.DisabilityLevel ?? noInfoText;
                    proof = selectedRequest.ProofImageData;

                    inform Inform = new inform(topic, content, Fullname, username, region, age, sex, alergic, invalid, pathol_diseases, proof);
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
            if (this.AccountObj?.AdminDetails?.CanRespondOnRequests != true)
            {
                MessageBox.Show("У вас нема права відповідати на повідомлення");
                return;
            }
            //нужно же сделать проверку не "прийнято" или не "відхилено" ли заявка,чтоб не отвечать на нее по новой, не могу придумать проверку
            if (userRequestsTable.SelectedCells.Count > 0)
            {
                int selectedRowIndex = userRequestsTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = userRequestsTable.Rows[selectedRowIndex];
                UserRequest selectedUserRequest = (UserRequest)selectedRow.DataBoundItem;
                parentForm.OpenChildForm(new forms.AdminResponseCreation(selectedUserRequest, this.AccountObj, this.parentForm), sender);
            }
        }

        private void FilterDataGridViewByRegion(string region)
        {
            var filteredUserRequests = this.AllUserRequests; 
            if (region != "-")
            {
                filteredUserRequests = this.AllUserRequests
                    .Where(request =>
                    {
                        string rowRegion = request.ApplicantObj?.UserDetails?.Region ?? "";
                        return rowRegion == region;
                    })
                    .ToList();
            }
            userRequestsTable.DataSource = filteredUserRequests;
        }


        private void filterByRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegion = filterByRegion.SelectedItem.ToString();
            FilterDataGridViewByRegion(selectedRegion);
        }
    }
}
