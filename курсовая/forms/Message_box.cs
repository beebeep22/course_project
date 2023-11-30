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
            InitializeNotReadRespondedRequests(); 
            InitializeNotifications();

            this.Notifications = UserOperations.GetNotifications(this.AccountObj);
            this.NotReadRespondedRequests = UserOperations.GetRequestsWithUnreadResponses(this.AccountObj);

        }

        private void markRequestAsRead(UserRequest Request)
        {
            UserOperations.MarkRequestAsRead(Request);
        }

        private void InitializeNotReadRespondedRequests()
        {
            NotReadRespondedRequestsTable.DataSource = this.NotReadRespondedRequests;

            NotReadRespondedRequestsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void InitializeNotifications()
        {

        }


        private void NotReadRespondedRequestsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == NotReadRespondedRequestsTable.Columns["status"].Index)
            {
                UserRequestResponse response = e.Value as UserRequestResponse;
                if (response.Status!= "Не переглянуто")
                {
                    e.Value = response.Status;
                    e.FormattingApplied = true;
                }
            }
        }

        private void Message_box_Load(object sender, EventArgs e)
        {

        }
    }
}
