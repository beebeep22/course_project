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
    public partial class UserRequestsForm : Form
    {
        private Account AccountObj { get; set; }
        private UserMenuForm UserMenuForm { get; set; }
        private DbUserOperations UserOperations { get; set; }


        public UserRequestsForm(Account AccountObj, UserMenuForm userMenuForm)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserMenuForm = userMenuForm;
            this.UserOperations = new DbUserOperations();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // consider username as full name if there is no UserDetails
            labelUserFullName.Text = AccountObj.UserDetails?.GetFullName() ?? AccountObj.Username;
            List<UserRequest> userRequests = UserOperations.GetUserRequests(this.AccountObj._id);
            foreach (var userRequest in userRequests)
            {
                Console.WriteLine($"UserRequest Id: {userRequest._id}, Topic: {userRequest.Topic}, Content: {userRequest.Content}");
            }

        }

        private void goBackToUserMenu()
        {
            this.UserMenuForm.Enabled = true;
            this.Close();
        }

        private void buttonGoToMenu_Click(object sender, EventArgs e)
        {
            goBackToUserMenu();
        }

        private void UserRequestsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            goBackToUserMenu();
        }
    }
}
