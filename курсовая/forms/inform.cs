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
    public partial class inform : Form
    {
        public inform(string theme, string description,string PIB,string login,string obl,string vik,string gender)
        {
            InitializeComponent();
            topic.Text = theme;
            content.Text = description;
            fullname.Text = PIB;
            username.Text = login;
            region.Text = obl;
            age.Text = vik;
            sex.Text = gender;
        }

        private void inform_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
