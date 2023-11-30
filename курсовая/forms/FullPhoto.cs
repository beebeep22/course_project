using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая.forms
{
    public partial class FullPhoto : Form
    {
        public FullPhoto(byte[] proof)
        {
            InitializeComponent();
            using (MemoryStream ms = new MemoryStream(proof))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void FullPhoto_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }
    }
}
