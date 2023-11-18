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
    public partial class Podacha : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }
        public Podacha(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
        }

        private void podatu_Click(object sender, EventArgs e)
        {
            UserRequest request = new UserRequest(
                Topic: theme.Text,
                Content: description.Text,
                AccountObj: this.AccountObj
            );

            this.UserOperations.SendUserRequest(request);
        }
    }
}
