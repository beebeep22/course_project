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
            AdminOperations = new DbAdminOperations();
            userVerificationTable.DataSource = AdminOperations;

            userVerificationTable.CellDoubleClick += new DataGridViewCellEventHandler(this.userVerificationTable_CellDoubleClick);
        }

        private void userVerificationTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex< userVerificationTable.Rows.Count)
            {
                DataGridViewRow clickedRow = userVerificationTable.Rows[e.RowIndex];
                UserDetails selectedUser = (UserDetails)clickedRow?.DataBoundItem;
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
                    //username = selectedUser.
                    Fullname = selectedUser.GetFullName() ?? noInfoText;
                    region = selectedUser.Region ?? noInfoText;
                    age = selectedUser.Age ?? noInfoText;
                    sex = selectedUser.Gender ?? noInfoText;
                    alergic = selectedUser.Allergies ?? noInfoText;
                    pathol_diseases = selectedUser.Diseases ?? noInfoText;
                    invalid = selectedUser.DisabilityLevel ?? noInfoText;


                    inform Inform = new inform(Fullname, "", region, age, sex, alergic, invalid, pathol_diseases);
                    Inform.Show();
                }
            }
        }

        private void Approve_Click(object sender, EventArgs e)
        {

        }
    }
}
