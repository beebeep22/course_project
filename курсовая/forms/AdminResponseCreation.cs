﻿using System;
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
    public partial class AdminResponseCreation : Form
    {

        private DbAdminOperations AdminOperations { get; set; }
        private UserRequest Request { get; set; }
        public AdminResponseCreation(UserRequest Request)
        {
            InitializeComponent();
            this.AdminOperations = new DbAdminOperations();
            this.Request = Request;
        }

        private bool ResponseInputValid()
        {
            //нужно ли на тему и описание или можно "на розгляді" без темы и описания,а принятие/отказ с темой и описанием
            // нетб всегда тема и описание
            if (themeresponse.Text == "")
            {
                MessageBox.Show("Ви не ввели тему відповіді");
                return false;
            }
            else if (richcontentBox.Text == "")
            {
                MessageBox.Show("Ви не ввели опис відповіді");
                return false;
            }
            else if(!statusAccepted.Checked && !statusOnReview.Checked && !statusRejected.Checked)
            {
                MessageBox.Show("Ви не обрали статусу заявки");
                return false;
            }
            /*if (statusAccepted.Checked || statusRejected.Checked)
            {
                if (themeresponse.Text == " ")
                {
                    MessageBox.Show("Ви не ввели тему відповіді");
                    return false;
                }
                else if (richcontentBox.Text == " ")
                {
                    MessageBox.Show("Ви не ввели опис відповіді");
                    return false;
                }
            }*/
            return true;
        }

        private void createResponse_Click(object sender, EventArgs e)
        {
            if (!ResponseInputValid()) 
                return;

            string inputStatus;
            if (statusAccepted.Checked) inputStatus = "Прийнято";
            else if (statusOnReview.Checked) inputStatus = "На розгляді";
            else if (statusRejected.Checked) inputStatus = "Відхилено";
            else return;

            UserRequestResponse response = new UserRequestResponse(
                Topic: themeresponse.Text,
                Content: richcontentBox.Text,
                Status: inputStatus,
                UserRequestObj: this.Request
                );
            AdminOperations.CreateUserRequestResponse(response);
            this.Hide();
        }

        private void AdminResponseCreation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
