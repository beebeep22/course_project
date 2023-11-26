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
        public inform(string PIB, string login, string obl, string vik, string gender, string alerg, string inval, string diseases)
        {
            InitializeComponent();
            topic.Visible = false;
            content.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            fullname.Text = PIB;
            username.Text = login;
            region.Text = obl;
            age.Text = vik;
            sex.Text = gender;
            alergic.Text = alerg;
            invalid.Text = inval;
            pathologicaldiseases.Text = diseases;
        }

        public inform(string theme, string description,string PIB,string login,string obl,string vik,string gender,string alerg, string inval, string diseases)
        {
            InitializeComponent();
            topic.Text = theme;
            content.Text = description;
            fullname.Text = PIB;
            username.Text = login;
            region.Text = obl;
            age.Text = vik;
            sex.Text = gender;
            alergic.Text = alerg;
            invalid.Text = inval;
            pathologicaldiseases.Text = diseases;
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
