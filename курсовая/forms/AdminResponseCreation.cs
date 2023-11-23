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
    public partial class AdminResponseCreation : Form
    {
        public AdminResponseCreation()
        {
            InitializeComponent();
        }

        private void createResponse_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdminResponseCreation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
