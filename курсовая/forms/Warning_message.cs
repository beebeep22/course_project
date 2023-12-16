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
    public partial class Warning_message : Form
    {
        public Warning_message()
        {
            InitializeComponent();
        }

        private void Warning_message_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void agree_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close(); 
        }
    }
}
