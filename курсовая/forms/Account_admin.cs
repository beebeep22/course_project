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
    public partial class Account_admin : Form
    {
        private Account AccountObj { get; set; }
        public Account_admin(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;

        }

        private void surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void avatarka_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "Зображення JPEG (*.jpg)|*.jpg|Зображення PNG (*.png)|*.png|Всі файли (*.*)|*.*";

                if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openfile.FileName;
                    avatar_admin.ImageLocation = imageLocation;
                    //add save Image
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
