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
        public Message_box(Account AccountObj)
        {
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
            InitializeComponent();

            List<Notification> notifications = UserOperations.GetNotifications(this.AccountObj);
        }

        private void notification_Click(object sender, EventArgs e)
        {

        }
    }
}
