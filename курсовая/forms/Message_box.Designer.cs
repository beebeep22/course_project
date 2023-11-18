namespace курсовая.forms
{
    partial class Message_box
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
            this.notification = new System.Windows.Forms.Button();
            this.notification2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notification
            // 
            this.notification.Dock = System.Windows.Forms.DockStyle.Top;
            this.notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notification.Location = new System.Drawing.Point(0, 0);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(864, 71);
            this.notification.TabIndex = 0;
            this.notification.Text = "Вам повідомлення";
            this.notification.UseVisualStyleBackColor = true;
            this.notification.Click += new System.EventHandler(this.notification_Click);
            // 
            // notification2
            // 
            this.notification2.Dock = System.Windows.Forms.DockStyle.Top;
            this.notification2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notification2.Location = new System.Drawing.Point(0, 71);
            this.notification2.Name = "notification2";
            this.notification2.Size = new System.Drawing.Size(864, 71);
            this.notification2.TabIndex = 1;
            this.notification2.Text = "Вам повідомлення";
            this.notification2.UseVisualStyleBackColor = true;
            // 
            // Message_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 516);
            this.Controls.Add(this.notification2);
            this.Controls.Add(this.notification);
            this.Name = "Message_box";
            this.Text = "Message_box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notification;
        private System.Windows.Forms.Button notification2;
    }
}