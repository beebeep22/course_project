namespace SocialHelpApp
{
    partial class UserNewRequestForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTopic = new System.Windows.Forms.TextBox();
            this.inputContent = new System.Windows.Forms.TextBox();
            this.buttonSubmitRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(343, 380);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(131, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Go back to menu";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content";
            // 
            // inputTopic
            // 
            this.inputTopic.Location = new System.Drawing.Point(151, 59);
            this.inputTopic.Name = "inputTopic";
            this.inputTopic.Size = new System.Drawing.Size(100, 20);
            this.inputTopic.TabIndex = 3;
            // 
            // inputContent
            // 
            this.inputContent.Location = new System.Drawing.Point(151, 102);
            this.inputContent.Multiline = true;
            this.inputContent.Name = "inputContent";
            this.inputContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputContent.Size = new System.Drawing.Size(208, 154);
            this.inputContent.TabIndex = 4;
            // 
            // buttonSubmitRequest
            // 
            this.buttonSubmitRequest.Location = new System.Drawing.Point(343, 317);
            this.buttonSubmitRequest.Name = "buttonSubmitRequest";
            this.buttonSubmitRequest.Size = new System.Drawing.Size(131, 23);
            this.buttonSubmitRequest.TabIndex = 5;
            this.buttonSubmitRequest.Text = "Submit request";
            this.buttonSubmitRequest.UseVisualStyleBackColor = true;
            this.buttonSubmitRequest.Click += new System.EventHandler(this.buttonSubmitRequest_Click);
            // 
            // UserNewRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmitRequest);
            this.Controls.Add(this.inputContent);
            this.Controls.Add(this.inputTopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "UserNewRequestForm";
            this.Text = "UserNewRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTopic;
        private System.Windows.Forms.TextBox inputContent;
        private System.Windows.Forms.Button buttonSubmitRequest;
    }
}