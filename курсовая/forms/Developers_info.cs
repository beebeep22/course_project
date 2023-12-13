using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая.forms
{
    public partial class Developers_info : Form
    {
        public Developers_info()
        {
            InitializeComponent();
        }

        private void link_Click(object sender, EventArgs e)
        {
            string url = "https://www.peremogabudeludonki.com/uk/";
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                Warning_message warning_Message = new Warning_message();
                warning_Message.Text = "Помилка відкриття посилання";
                warning_Message.outputText.Text = ex.Message;
                warning_Message.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
