using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using курсовая.classes;                  


namespace курсовая.forms
{
    public partial class Account_admin : Form
    {
        private Account AccountObj { get; set; }
        private DbAdminOperations AdminOperations { get; set; }
        private DbAccountOperations AccountOperations { get; set; }
        public Account_admin(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.AdminOperations = new DbAdminOperations();
            this.AccountOperations = new DbAccountOperations();
            this.name.Text = AccountObj.AdminDetails?.FirstName ?? "";
            this.surname.Text = AccountObj.AdminDetails?.LastName ?? "";
            this.patronymic.Text = AccountObj.AdminDetails.MiddleName ?? "";
            UpdateProfilePicture();
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
                    this.AccountOperations.UpdateAccountProfileImage(this.AccountObj, imageLocation);
                    UpdateProfilePicture();
                    //add save Image
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateProfilePicture()
        {
            byte[] profileImage = this.AccountObj?.ProfileImage;
            if (profileImage == null || profileImage.Length <= 0) return;
            Image image;
            using (MemoryStream ms = new MemoryStream(profileImage))
            {
                image = Image.FromStream(ms);
            }
            avatar_admin.Image = image;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.AccountObj.AdminDetails.FirstName = name.Text;
            this.AccountObj.AdminDetails.LastName = surname.Text;
            this.AccountObj.AdminDetails.MiddleName = patronymic.Text;
            this.AdminOperations.UpdateAdminDetails(this.AccountObj, this.AccountObj.AdminDetails);
            Warning_message warning_Message = new Warning_message();
            warning_Message.Text = "Успіх!";
            warning_Message.outputText.Text = "Зміни збережено!";
            warning_Message.pictureBox1.Image = Properties.Resources.free_icon_munchkin_cat_6855253;
            warning_Message.ShowDialog();

        }
    }
}
