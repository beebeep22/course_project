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
    public partial class Podacha : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }
        public Podacha(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
        }

        private bool application_verification()
        {
            try
            {
                if (theme.Text == "" || description.Text == "")
                {
                    throw new Exceptions("Ви намагаєтесь відправити пусту заявку!");
                }
                foreach (UserRequest existingRequest in this.UserOperations.GetUserRequests(this.AccountObj))
                {
                    if (existingRequest.Topic == theme.Text && existingRequest.Content == description.Text)
                    {
                        throw new Exceptions("Така заявка вже існує!");
                    }
                }
                return true;
            }
            catch(Exceptions ex)
            {
                MessageBox.Show(ex.Message, "Помилка відправки");
                return false;
            }
        }

        private void podatu_Click(object sender, EventArgs e)
        {
            if (!application_verification()) return;

            UserRequest request = new UserRequest(
                Topic: theme.Text,
                Content: description.Text,
                AccountObj: this.AccountObj
            );

            this.UserOperations.SendUserRequest(request);
        }

        private void addproof_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "Зображення JPEG (*.jpg)|*.jpg|Зображення PNG (*.png)|*.png|Всі файли (*.*)|*.*";

                if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openfile.FileName;
                    proof.ImageLocation = imageLocation;

                    addproof.Text = "Змінити доказ";
                    removeProof.Visible = true;
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Podacha_Load(object sender, EventArgs e)
        {
            if (proof.Image == null)
            {
                removeProof.Visible = false;
            }
        }

        private void removeProof_Click(object sender, EventArgs e)
        {
            proof.Image = null;
            if(proof.Image == null)
            {
                addproof.Text = "+Додати доказ";
                removeProof.Visible = false;
            }
        }
    }
}
