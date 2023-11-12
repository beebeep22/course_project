namespace SocialHelpApp
{
    partial class UserMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoToUserRequestsForm = new System.Windows.Forms.Button();
            this.buttonGoToUserNewRequestForm = new System.Windows.Forms.Button();
            this.buttonSaveUserDetails = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, ";
            // 
            // buttonGoToUserRequestsForm
            // 
            this.buttonGoToUserRequestsForm.Location = new System.Drawing.Point(232, 383);
            this.buttonGoToUserRequestsForm.Name = "buttonGoToUserRequestsForm";
            this.buttonGoToUserRequestsForm.Size = new System.Drawing.Size(132, 23);
            this.buttonGoToUserRequestsForm.TabIndex = 2;
            this.buttonGoToUserRequestsForm.Text = "Переглянути заявки";
            this.buttonGoToUserRequestsForm.UseVisualStyleBackColor = true;
            this.buttonGoToUserRequestsForm.Click += new System.EventHandler(this.buttonGoToUserRequestsForm_Click);
            // 
            // buttonGoToUserNewRequestForm
            // 
            this.buttonGoToUserNewRequestForm.Location = new System.Drawing.Point(425, 383);
            this.buttonGoToUserNewRequestForm.Name = "buttonGoToUserNewRequestForm";
            this.buttonGoToUserNewRequestForm.Size = new System.Drawing.Size(139, 23);
            this.buttonGoToUserNewRequestForm.TabIndex = 3;
            this.buttonGoToUserNewRequestForm.Text = "Подати нову заявку";
            this.buttonGoToUserNewRequestForm.UseVisualStyleBackColor = true;
            this.buttonGoToUserNewRequestForm.Click += new System.EventHandler(this.buttonGoToUserNewRequestForm_Click);
            // 
            // buttonSaveUserDetails
            // 
            this.buttonSaveUserDetails.Location = new System.Drawing.Point(327, 312);
            this.buttonSaveUserDetails.Name = "buttonSaveUserDetails";
            this.buttonSaveUserDetails.Size = new System.Drawing.Size(139, 23);
            this.buttonSaveUserDetails.TabIndex = 4;
            this.buttonSaveUserDetails.Text = "Зберегти данi";
            this.buttonSaveUserDetails.UseVisualStyleBackColor = true;
            this.buttonSaveUserDetails.Click += new System.EventHandler(this.buttonSaveUserDetails_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(92, 39);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 13);
            this.labelUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age: ";
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(95, 98);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(100, 20);
            this.inputAge.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "First name: ";
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonSaveUserDetails);
            this.Controls.Add(this.buttonGoToUserNewRequestForm);
            this.Controls.Add(this.buttonGoToUserRequestsForm);
            this.Controls.Add(this.label1);
            this.Name = "UserMenuForm";
            this.Text = "User menu";
            this.Load += new System.EventHandler(this.UserMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoToUserRequestsForm;
        private System.Windows.Forms.Button buttonGoToUserNewRequestForm;
        private System.Windows.Forms.Button buttonSaveUserDetails;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.Label label3;
    }
}