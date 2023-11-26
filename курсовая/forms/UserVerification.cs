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
    public partial class UserVerification : Form
    {
        private Account AccountObj { get; set; }
        private DbAdminOperations AdminOperations { get; set; }

        public UserVerification()
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            this.AdminOperations = new DbAdminOperations();
        }

        private void userRequestsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex< userVerificationTable.Rows.Count)
            {
                DataGridViewRow clickedRow = userVerificationTable.Rows[e.RowIndex];
                UserDetails selectedUser = (UserDetails)clickedRow?.DataBoundItem;

                if (selectedUser != null)
                {

                }
            }
        }

        private void Approve_Click(object sender, EventArgs e)
        {

        }
    }
}
