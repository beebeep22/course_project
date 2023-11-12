namespace SocialHelpApp
{
    partial class AdminMenuForm
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
            this.inputSortByTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRespondOnRequest = new System.Windows.Forms.Button();
            this.buttonCreateNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User requests";
            // 
            // inputSortByTopic
            // 
            this.inputSortByTopic.Location = new System.Drawing.Point(298, 36);
            this.inputSortByTopic.Name = "inputSortByTopic";
            this.inputSortByTopic.Size = new System.Drawing.Size(100, 20);
            this.inputSortByTopic.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sort by topic";
            // 
            // buttonRespondOnRequest
            // 
            this.buttonRespondOnRequest.Location = new System.Drawing.Point(229, 391);
            this.buttonRespondOnRequest.Name = "buttonRespondOnRequest";
            this.buttonRespondOnRequest.Size = new System.Drawing.Size(127, 23);
            this.buttonRespondOnRequest.TabIndex = 3;
            this.buttonRespondOnRequest.Text = "Respond on request";
            this.buttonRespondOnRequest.UseVisualStyleBackColor = true;
            // 
            // buttonCreateNotification
            // 
            this.buttonCreateNotification.Location = new System.Drawing.Point(424, 391);
            this.buttonCreateNotification.Name = "buttonCreateNotification";
            this.buttonCreateNotification.Size = new System.Drawing.Size(156, 23);
            this.buttonCreateNotification.TabIndex = 4;
            this.buttonCreateNotification.Text = "Create global notification";
            this.buttonCreateNotification.UseVisualStyleBackColor = true;
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateNotification);
            this.Controls.Add(this.buttonRespondOnRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputSortByTopic);
            this.Controls.Add(this.label1);
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSortByTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRespondOnRequest;
        private System.Windows.Forms.Button buttonCreateNotification;
    }
}