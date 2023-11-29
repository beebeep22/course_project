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

            label1.Location = new Point(22, 97);
            fullname.Location = new Point(56, 97);
            label3.Location = new Point(22, 125);
            username.Location = new Point(66, 125);
            label5.Location = new Point(22, 156);
            age.Location = new Point(50, 156);
            label6.Location = new Point(22, 185);
            sex.Location = new Point(65, 185);
            label4.Location = new Point(22, 214);
            region.Location = new Point(70, 214);
            label10.Location = new Point(210, 156);
            invalid.Location = new Point(295, 156);
            label9.Location = new Point(210, 185);
            alergic.Location = new Point(260, 185);
            label11.Location = new Point(22, 245);
            pathologicaldiseases.Location = new Point(188, 245);
            OK.Location = new Point(162, 330);

            fullname.Text = PIB;
            username.Text = login;
            region.Text = obl;
            age.Text = vik;
            sex.Text = gender;
            alergic.Text = alerg;
            invalid.Text = inval;
            pathologicaldiseases.Text = diseases;
        }

        public inform(string theme, string description,string PIB,string login,string obl,string vik,string gender,string alerg, string inval, string diseases, byte[] proof)
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
            // show proof argument if it's not null
            Console.WriteLine(proof);
        }

        private void inform_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            topic.ReadOnly = true;
            content.ReadOnly = true;
            pathologicaldiseases.ReadOnly = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pathologicaldiseases_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
