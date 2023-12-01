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
    public partial class Message_box : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }
        private List<Notification> Notifications { get; set; }
        private List<UserRequest> NotReadRespondedRequests { get; set; }
        public Message_box(Account AccountObj)
        {
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
            InitializeComponent();

            this.Notifications = UserOperations.GetNotifications(this.AccountObj);
            this.NotReadRespondedRequests = UserOperations.GetRequestsWithUnreadResponses(this.AccountObj);
            InitializeNotReadRespondedRequests();
            InitializeNotifications();
        }

        private void markRequestAsRead(UserRequest Request)
        {
            UserOperations.MarkRequestAsRead(Request);
        }

        private void InitializeNotReadRespondedRequests()
        {

            NotReadRespondedRequestsTable.DataSource = this.NotReadRespondedRequests;

            NotReadRespondedRequestsTable.Columns["_id"].Visible = false;
            NotReadRespondedRequestsTable.Columns["ApplicantId"].Visible = false;
            NotReadRespondedRequestsTable.Columns["Response"].Visible = false;
            NotReadRespondedRequestsTable.Columns["ApplicantObj"].Visible = false;
            NotReadRespondedRequestsTable.Columns["ProofImageData"].Visible = false;
            NotReadRespondedRequestsTable.Columns["Content"].Visible = false;

            NotReadRespondedRequestsTable.Columns["Topic"].HeaderText = "Тема";

            int columnIndex = NotReadRespondedRequestsTable.Columns["Topic"].Index;
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.Name = "Status";
            statusColumn.HeaderText = "Статус";
            NotReadRespondedRequestsTable.Columns.Insert(columnIndex + 1, statusColumn);

            NotReadRespondedRequestsTable.CellFormatting += NotReadRespondedRequestsTable_CellFormatting;
            NotReadRespondedRequestsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            NotReadRespondedRequestsTable.ClearSelection();
        }

        private void NotReadRespondedRequestsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == NotReadRespondedRequestsTable.Columns["Status"].Index)
            {
                UserRequestResponse response = e.Value as UserRequestResponse;
                e.Value = response?.Status ?? "Не переглянуто";
                e.FormattingApplied = true;
            }
        }

        private void NotReadRespondedRequestsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < NotReadRespondedRequestsTable.Rows.Count)
            {
                DataGridViewRow clickedRow = NotReadRespondedRequestsTable.Rows[e.RowIndex];
                UserRequest selectedRequest = (UserRequest)clickedRow?.DataBoundItem;
                markRequestAsRead(selectedRequest);
            }
        }

        private void InitializeNotifications()
        {

        }

        private void Message_box_Load(object sender, EventArgs e)
        {

        }
    }
}
