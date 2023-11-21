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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusAccepted = new System.Windows.Forms.RadioButton();
            this.statusOnReview = new System.Windows.Forms.RadioButton();
            this.statusRejected = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(190, 195);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(246, 143);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тема відповіді";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Опис відповіді";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус заявки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Створити відповідь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createResponse_Click);
            // 
            // statusAccepted
            // 
            this.statusAccepted.AutoSize = true;
            this.statusAccepted.Location = new System.Drawing.Point(0, 19);
            this.statusAccepted.Name = "statusAccepted";
            this.statusAccepted.Size = new System.Drawing.Size(74, 17);
            this.statusAccepted.TabIndex = 7;
            this.statusAccepted.TabStop = true;
            this.statusAccepted.Text = "Прийнято";
            this.statusAccepted.UseVisualStyleBackColor = true;
            // 
            // statusOnReview
            // 
            this.statusOnReview.AutoSize = true;
            this.statusOnReview.Location = new System.Drawing.Point(80, 19);
            this.statusOnReview.Name = "statusOnReview";
            this.statusOnReview.Size = new System.Drawing.Size(85, 17);
            this.statusOnReview.TabIndex = 8;
            this.statusOnReview.TabStop = true;
            this.statusOnReview.Text = "На розгляді";
            this.statusOnReview.UseVisualStyleBackColor = true;
            // 
            // statusRejected
            // 
            this.statusRejected.AutoSize = true;
            this.statusRejected.Location = new System.Drawing.Point(171, 19);
            this.statusRejected.Name = "statusRejected";
            this.statusRejected.Size = new System.Drawing.Size(75, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(190, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 50);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // AdminResponseCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AdminResponseCreation";
            this.Text = "AdminResponseCreation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton statusAccepted;
        private System.Windows.Forms.RadioButton statusOnReview;
        private System.Windows.Forms.RadioButton statusRejected;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}