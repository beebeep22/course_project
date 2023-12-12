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
        private List<Account> AllUsers { get; set; }

        public UserVerification()
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.AdminOperations = new DbAdminOperations();
            this.AllUsers = AdminOperations.GetAllUsers();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            userVerificationTable.DataSource = this.AllUsers;

            userVerificationTable.Columns["_id"].Visible = false;
            userVerificationTable.Columns["password"].Visible = false;
            userVerificationTable.Columns["Role"].Visible = false;
            userVerificationTable.Columns["AdminDetails"].Visible = false;
            userVerificationTable.Columns["profileImage"].Visible = false;

            userVerificationTable.CellDoubleClick += new DataGridViewCellEventHandler(this.userVerificationTable_CellDoubleClick);
            userVerificationTable.CellFormatting += userVerificationTable_CellFormatting;
            userVerificationTable.ScrollBars = ScrollBars.None;
            userVerificationTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void userVerificationTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex< userVerificationTable.Rows.Count)
            {
                DataGridViewRow clickedRow = userVerificationTable.Rows[e.RowIndex];
                Account selectedAccount = (Account)clickedRow?.DataBoundItem;
                UserDetails selectedUser = selectedAccount.UserDetails; 
                string username;
                string Fullname;
                string region;
                string age;
                string sex;
                string alergic;
                string pathol_diseases;
                string invalid;
                string noInfoText = "Немає інформації";

                if (selectedUser != null)
                {
                    username = selectedAccount.Username;
                    Fullname = selectedUser.GetFullName() ?? noInfoText;
                    region = selectedUser.Region ?? noInfoText;
                    age = selectedUser.Age ?? noInfoText;
                    sex = selectedUser.Gender ?? noInfoText;
                    alergic = selectedUser.Allergies ?? noInfoText;
                    pathol_diseases = selectedUser.Diseases ?? noInfoText;
                    invalid = selectedUser.DisabilityLevel ?? noInfoText;


                    inform Inform = new inform(Fullname, username, region, age, sex, alergic, invalid, pathol_diseases);
                    Inform.Show();
                }
            }
        }

        private void userVerificationTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == userVerificationTable.Columns["fullName"].Index)
            {
                UserDetails details = (e.Value as UserDetails);
                e.Value = details?.FirstName != null ? details.GetFullName() : "Дані відсутні";
                e.FormattingApplied = true;
            }
            else if (e.ColumnIndex == userVerificationTable.Columns["isApproved"].Index)
            {
                UserDetails details = (e.Value as UserDetails);
                e.Value = details?.Approved != true ? "Не верифікован" : "Верифікован";
                e.FormattingApplied = true;
            }
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            if (userVerificationTable.SelectedCells.Count > 0)
            {
                int selectedRowIndex = userVerificationTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = userVerificationTable.Rows[selectedRowIndex];
                Account selectedUser = (Account)selectedRow.DataBoundItem;
                AdminOperations.ApproveUser(selectedUser);
            }
        }

        private void Disapprove_Click(object sender, EventArgs e)
        {
            if (userVerificationTable.SelectedCells.Count > 0)
            {
                int selectedRowIndex = userVerificationTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = userVerificationTable.Rows[selectedRowIndex];
                Account selectedUser = (Account)selectedRow.DataBoundItem;
                AdminOperations.DisapproveUser(selectedUser);
            }
        }

        private void UserVerification_Load(object sender, EventArgs e)
        {
            userVerificationTable.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
        }
    }
}
