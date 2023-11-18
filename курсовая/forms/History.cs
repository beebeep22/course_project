﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using курсовая.classes;


namespace курсовая.forms
{
    public partial class History : Form
    {
        private Account AccountObj { get; set; }
        private DbUserOperations UserOperations { get; set; }
        public History(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
            this.UserOperations = new DbUserOperations();
            InitializeDataGridView();
        }

        private List<UserRequest> getUserRequests()
        {
            return this.UserOperations.GetUserRequestsWithResponses(this.AccountObj);
        }

        private void InitializeDataGridView()
        {
            var userRequests = getUserRequests();

            listOfRequests.DataSource = userRequests;

            listOfRequests.Columns["_id"].Visible = false;
            listOfRequests.Columns["ApplicantId"].Visible = false; 
            listOfRequests.Columns["Content"].Visible = false; 

            // Add a custom column for the Response Status
            DataGridViewTextBoxColumn responseStatusColumn = new DataGridViewTextBoxColumn();
            responseStatusColumn.Name = "ResponseStatusColumn";
            responseStatusColumn.HeaderText = "Response"; 
            responseStatusColumn.DataPropertyName = "Response"; 
            listOfRequests.Columns.Add(responseStatusColumn);

            // Hide the original "Response" column
            listOfRequests.Columns["Response"].Visible = false;

            listOfRequests.SelectionChanged += listOfRequests_SelectionChanged;
            listOfRequests.CellFormatting += listOfRequests_CellFormatting;
        }

        private void listOfRequests_SelectionChanged(object sender, EventArgs e)
        {
            UserRequest selectedRequest = (UserRequest)listOfRequests.CurrentRow?.DataBoundItem;

            if (selectedRequest != null)
            {
                txtRequestContent.Text = selectedRequest.Content;

                if (selectedRequest.Response != null)
                {
                    txtResponseContent.Text = selectedRequest.Response.Content;
                    txtResponseContent.Visible = true;
                }
                else
                {
                    txtResponseContent.Visible = false;
                }
            }
        }

        private void listOfRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format the "ResponseStatusColumn" to display "No response" if Response is null
            if (e.ColumnIndex == listOfRequests.Columns["ResponseStatusColumn"].Index)
            {
                var responseValue = e.Value as UserRequestResponse;
                if (responseValue == null)
                {
                    e.Value = "No response";
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = responseValue.Status;
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
