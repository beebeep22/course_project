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
    public partial class Settings : Form
    {
        private Account AccountObj { get; set; }
        private DbAccountOperations AccountOperations { get; set; }

        public Settings(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.AccountOperations = new DbAccountOperations();
        }

        private void smallsize_Click(object sender, EventArgs e)
        {

        }

        private void Mediumsize_Click(object sender, EventArgs e)
        {

        }

        private void Bigsize_Click(object sender, EventArgs e)
        {
     
        }

        private void deleteaccount_Click(object sender, EventArgs e)
        {
            AccountOperations.removeAccount(this.AccountObj);
        }
    }
}
