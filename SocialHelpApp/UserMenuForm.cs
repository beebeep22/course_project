using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialHelpApp.classes;


namespace SocialHelpApp
{
    public partial class UserMenuForm : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }

        public UserMenuForm(Account userObj)
        {
            InitializeComponent();
            this.AccountObj = userObj;
            this.UserOperations = new DbUserOperations();
        }

        private void UserMenuForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = AccountObj.Username;
            inputAge.Text = AccountObj.UserDetails?.Age.ToString();
        }

        private void buttonGoToUserRequestsForm_Click(object sender, EventArgs e)
        {
            UserRequestsForm userRequestsForm = new UserRequestsForm(AccountObj, this);
            userRequestsForm.Show();
            this.Enabled = false;
        }

        private void buttonGoToUserNewRequestForm_Click(object sender, EventArgs e)
        {
            UserNewRequestForm userNewRequestForm = new UserNewRequestForm(AccountObj, this);
            userNewRequestForm.Show();
            this.Enabled = false;
        }

        private void UserMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveUserDetails_Click(object sender, EventArgs e)
        {
            // create UserDetails instance from inputs 
            UserDetails newUserDetails = new UserDetails(
                FirstName: "John",
                LastName: "Doe",
                MiddleName: "M",
                Gender: "M",
                Age: 18, // mock data, replace with data from inputs like "Age: Int32.Parse(inputAge.Text)"
                City: "New York",
                Diseases: "",
                Allergies: "алергiя на курсач",
                DisabilityLevel: ""
            );
            UserOperations.UpdateUserDetails(this.AccountObj, newUserDetails);
        }
    }
}
