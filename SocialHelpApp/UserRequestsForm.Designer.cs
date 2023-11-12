namespace SocialHelpApp
{
    partial class UserRequestsForm
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
            this.labelUserFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGoToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requests";
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Location = new System.Drawing.Point(40, 21);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(13, 13);
            this.labelUserFullName.TabIndex = 1;
            this.labelUserFullName.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notifications";
            // 
            // buttonGoToMenu
            // 
            this.buttonGoToMenu.Location = new System.Drawing.Point(337, 390);
            this.buttonGoToMenu.Name = "buttonGoToMenu";
            this.buttonGoToMenu.Size = new System.Drawing.Size(133, 23);
            this.buttonGoToMenu.TabIndex = 3;
            this.buttonGoToMenu.Text = "Go back to menu";
            this.buttonGoToMenu.UseVisualStyleBackColor = true;
            this.buttonGoToMenu.Click += new System.EventHandler(this.buttonGoToMenu_Click);
            // 
            // UserRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoToMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserFullName);
            this.Controls.Add(this.label1);
            this.Name = "UserRequestsForm";
            this.Text = "Requests";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGoToMenu;
    }
}