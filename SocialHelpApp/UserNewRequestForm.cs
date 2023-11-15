using System;
using System.Windows.Forms;
using SocialHelpApp.classes;

namespace SocialHelpApp
{
    public partial class UserNewRequestForm : Form
    {
        private Account AccountObj { get; set; }
        private UserMenuForm UserMenuForm { get; set; }
        private DbUserOperations UserOperations { get; set; }
        public UserNewRequestForm(Account AccountObj, UserMenuForm userMenuForm)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserMenuForm = userMenuForm;
            this.UserOperations = new DbUserOperations();
        }

        private void GoBackToUserMenu()
        {
            this.UserMenuForm.Enabled = true;
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GoBackToUserMenu();
        }

        private void buttonSubmitRequest_Click(object sender, EventArgs e)
        {
            UserRequest Request = new UserRequest(
                Topic: inputTopic.Text,
                Content: inputContent.Text,
                AccountObj: this.AccountObj
            );
            UserOperations.SendUserRequest(Request);
        }
    }
}
