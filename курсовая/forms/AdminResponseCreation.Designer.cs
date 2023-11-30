namespace курсовая.forms
{
    partial class AdminResponseCreation
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
            this.richcontentBox = new System.Windows.Forms.RichTextBox();
            this.themeresponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createResponse = new System.Windows.Forms.Button();
            this.statusAccepted = new System.Windows.Forms.RadioButton();
            this.statusOnReview = new System.Windows.Forms.RadioButton();
            this.statusRejected = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.askAIButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richcontentBox
            // 
            this.richcontentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richcontentBox.Location = new System.Drawing.Point(232, 157);
            this.richcontentBox.Name = "richcontentBox";
            this.richcontentBox.Size = new System.Drawing.Size(281, 143);
            this.richcontentBox.TabIndex = 0;
            this.richcontentBox.Text = "";
            // 
            // themeresponse
            // 
            this.themeresponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeresponse.Location = new System.Drawing.Point(229, 47);
            this.themeresponse.Multiline = true;
            this.themeresponse.Name = "themeresponse";
            this.themeresponse.Size = new System.Drawing.Size(284, 29);
            this.themeresponse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тема відповіді";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Опис відповіді";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(111, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус заявки";
            // 
            // createResponse
            // 
            this.createResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createResponse.Location = new System.Drawing.Point(302, 342);
            this.createResponse.Name = "createResponse";
            this.createResponse.Size = new System.Drawing.Size(136, 37);
            this.createResponse.TabIndex = 6;
            this.createResponse.Text = "Створити відповідь";
            this.createResponse.UseVisualStyleBackColor = true;
            this.createResponse.Click += new System.EventHandler(this.createResponse_Click);
            // 
            // statusAccepted
            // 
            this.statusAccepted.AutoSize = true;
            this.statusAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAccepted.Location = new System.Drawing.Point(6, 19);
            this.statusAccepted.Name = "statusAccepted";
            this.statusAccepted.Size = new System.Drawing.Size(83, 19);
            this.statusAccepted.TabIndex = 7;
            this.statusAccepted.TabStop = true;
            this.statusAccepted.Text = "Прийнято";
            this.statusAccepted.UseVisualStyleBackColor = true;
            // 
            // statusOnReview
            // 
            this.statusOnReview.AutoSize = true;
            this.statusOnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusOnReview.Location = new System.Drawing.Point(95, 19);
            this.statusOnReview.Name = "statusOnReview";
            this.statusOnReview.Size = new System.Drawing.Size(93, 19);
            this.statusOnReview.TabIndex = 8;
            this.statusOnReview.TabStop = true;
            this.statusOnReview.Text = "На розгляді";
            this.statusOnReview.UseVisualStyleBackColor = true;
            // 
            // statusRejected
            // 
            this.statusRejected.AutoSize = true;
            this.statusRejected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusRejected.Location = new System.Drawing.Point(199, 19);
            this.statusRejected.Name = "statusRejected";
            this.statusRejected.Size = new System.Drawing.Size(84, 19);
            this.statusRejected.TabIndex = 9;
            this.statusRejected.TabStop = true;
            this.statusRejected.Text = "Відхилено";
            this.statusRejected.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusAccepted);
            this.groupBox1.Controls.Add(this.statusRejected);
            this.groupBox1.Controls.Add(this.statusOnReview);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(232, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 50);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // askAIButton
            // 
            this.askAIButton.Location = new System.Drawing.Point(38, 342);
            this.askAIButton.Name = "askAIButton";
            this.askAIButton.Size = new System.Drawing.Size(96, 23);
            this.askAIButton.TabIndex = 11;
            this.askAIButton.Text = "Покращити з AI";
            this.askAIButton.UseVisualStyleBackColor = true;
            this.askAIButton.Click += new System.EventHandler(this.askAIButton_Click);
            // 
            // AdminResponseCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 394);
            this.Controls.Add(this.askAIButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createResponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.themeresponse);
            this.Controls.Add(this.richcontentBox);
            this.Name = "AdminResponseCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AdminResponseCreation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richcontentBox;
        private System.Windows.Forms.TextBox themeresponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createResponse;
        private System.Windows.Forms.RadioButton statusAccepted;
        private System.Windows.Forms.RadioButton statusOnReview;
        private System.Windows.Forms.RadioButton statusRejected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button askAIButton;
    }
}