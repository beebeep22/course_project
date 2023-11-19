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
    public partial class Zayavki : Form
    {
        private Account AccountObj { get; set; }
        private DbAdminOperations AdminOperations { get; set; }

        public Zayavki(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.AdminOperations = new DbAdminOperations();
            InitializeDataGridView();
        }


        private void InitializeDataGridView()
        {
            var userRequests = AdminOperations.GetUserRequests();

            userRequestsTable.DataSource = userRequests;
            
            userRequestsTable.Columns["_id"].Visible = false;
            userRequestsTable.Columns["ApplicantId"].Visible = false;
            userRequestsTable.Columns["Content"].Visible = false;

            userRequestsTable.CellFormatting += userRequestsTable_CellFormatting;
            userRequestsTable.SelectionChanged += listOfRequests_SelectionChanged;
        }

        private void listOfRequests_SelectionChanged(object sender, EventArgs e)
        {
            UserRequest selectedRequest = (UserRequest)userRequestsTable.CurrentRow?.DataBoundItem;

            if (selectedRequest != null)
            {
                /* 
                 * TODO: show info about request and applicant in UI
                 * Examples:
                 * selectedRequest.AccountObj.Username - username of applicant
                 * selectedRequest.AccountObj?.UserDetails?.GetFullName() ?? "No data about user" - full name if present
                 * selectedRequest.AccountObj?.UserDetails?.Region ?? "No data about user" - region
                */ 
            }
        }

        private void userRequestsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == userRequestsTable.Columns["ResponseStatusColumn"].Index)
            {
                // Format the "ResponseStatusColumn" to display "No response" if Response is null
                e.Value = (e.Value as UserRequestResponse)?.Status ?? "No response";
            }
            else if (e.ColumnIndex == userRequestsTable.Columns["applicantName"].Index)
            {
                e.Value = (e.Value as Account)?.Username;
            }
            e.FormattingApplied = true;
        }

        private void userRequestsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.AccountObj?.AdminDetails?.CanRespondOnRequests != true)
            {
                MessageBox.Show("У вас нема права відповідати на повідомлення");
                return;
            }

        }
    }
}
