using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая.forms
{
    public partial class Account_admin : Form
    {
        public Account_admin(string firstName, string lastName, string patronymicc)
        {
            InitializeComponent();

            name.Text = firstName;
            surname.Text = lastName;
            patronymic.Text = patronymicc;
        }
    }
}
