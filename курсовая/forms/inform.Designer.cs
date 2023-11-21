using System.Drawing;

namespace курсовая.forms
{
    partial class inform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.topic = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Піб:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 50);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Особисті дані";
            // 
            // fullname
            // 
            this.fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullname.AutoSize = true;
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullname.Location = new System.Drawing.Point(121, 215);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(0, 18);
            this.fullname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Логін:";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(121, 251);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 18);
            this.username.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Регіон:";
            // 
            // region
            // 
            this.region.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.region.AutoSize = true;
            this.region.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.region.Location = new System.Drawing.Point(121, 348);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(0, 18);
            this.region.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(54, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Вік:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(54, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Стать:";
            // 
            // age
            // 
            this.age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(121, 284);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(0, 18);
            this.age.TabIndex = 9;
            // 
            // sex
            // 
            this.sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sex.Location = new System.Drawing.Point(121, 316);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(0, 18);
            this.sex.TabIndex = 10;
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(170, 378);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(121, 37);
            this.OK.TabIndex = 11;
            this.OK.Text = "Ок";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(54, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Тема:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(54, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Опис:";
            // 
            // topic
            // 
            this.topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topic.BackColor = System.Drawing.Color.Honeydew;
            this.topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topic.Location = new System.Drawing.Point(124, 75);
            this.topic.Multiline = true;
            this.topic.Name = "topic";
            this.topic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.topic.Size = new System.Drawing.Size(316, 48);
            this.topic.TabIndex = 14;
            // 
            // content
            // 
            this.content.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.content.BackColor = System.Drawing.Color.Honeydew;
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content.Location = new System.Drawing.Point(124, 129);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.content.Size = new System.Drawing.Size(316, 62);
            this.content.TabIndex = 15;
            // 
            // inform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(473, 427);
            this.Controls.Add(this.content);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.region);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "inform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.inform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label region;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox topic;
        private System.Windows.Forms.TextBox content;
    }
}