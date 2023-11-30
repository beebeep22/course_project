using System;
using System.Collections.Generic;
using System.Windows.Forms;
using курсовая.classes;
using System.Linq;


namespace курсовая.forms
{
    public partial class History : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }
        private List<UserRequest> AllUserRequests { get; set; }
        public History(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
            this.AllUserRequests = getUserRequests();
            InitializeDataGridView();
        }

        private List<UserRequest> getUserRequests()
        {
            return this.UserOperations.GetUserRequestsWithResponses(this.AccountObj);
        }

        private void InitializeDataGridView()
        {

            listOfRequests.DataSource = AllUserRequests;

            listOfRequests.Columns["_id"].Visible = false;
            listOfRequests.Columns["ApplicantId"].Visible = false;
            listOfRequests.Columns["ApplicantObj"].Visible = false;
            listOfRequests.Columns["Content"].Visible = false;
            listOfRequests.Columns["ProofImageData"].Visible = false;

            listOfRequests.SelectionChanged += listOfRequests_SelectionChanged;
            listOfRequests.CellFormatting += listOfRequests_CellFormatting;
            listOfRequests.ScrollBars = ScrollBars.None;
            listOfRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
            listOfRequests.Columns["requestTopic"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            listOfRequests.Columns["requestTopic"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            // sort on column header click
            listOfRequests.ColumnHeaderMouseClick += listOfRequests_ColumnHeaderMouseClick;
        }

        private void listOfRequests_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewColumn clickedColumn = listOfRequests.Columns[e.ColumnIndex];

            if (clickedColumn != null)
            {
                string propertyName = clickedColumn.Name;
                switch (propertyName)
                {
                    case "requestTopic":
                        this.AllUserRequests = AllUserRequests.OrderBy(request => request.Topic).ToList();
                        break;
                    case "ResponseStatus":
                        this.AllUserRequests = AllUserRequests.OrderBy(request => request?.Response?.Status).ToList();
                        break;
                }
                listOfRequests.DataSource = this.AllUserRequests;
            }
        }

        private void listOfRequests_SelectionChanged(object sender, EventArgs e)
        {
            UserRequest selectedRequest = (UserRequest)listOfRequests.CurrentRow?.DataBoundItem;

            if (selectedRequest != null)
            {
                textTResponseTopic.Text = selectedRequest.Topic;
                txtRequestContent.Text = selectedRequest.Content;

                if (selectedRequest.Response != null)
                {
                    textTResponseTopic.Text = selectedRequest.Response.Topic;
                    textTResponseTopic.Visible = true;
                    txtResponseContent.Text = selectedRequest.Response.Content;
                    txtResponseContent.Visible = true;
                }
                else
                {
                    textTResponseTopic.Visible = false;
                    txtResponseContent.Visible = false;
                }
            }
        }

        private void listOfRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format the "responseStatus" to display "No response" if Response is null
            if (e.ColumnIndex == listOfRequests.Columns["responseStatus"].Index)
            {
                e.Value = (e.Value as UserRequestResponse)?.Status ?? "Не переглянуто";
                e.FormattingApplied = true;
            }
        }

        private void History_Load(object sender, EventArgs e)
        {

        }

    }
}
