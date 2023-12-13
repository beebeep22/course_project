namespace курсовая.forms
{
    partial class Developers_info
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
            this.label2 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Розробники цієї програми:\r\n\r\nКНТ-122\r\nЖиволуп Б. О.\r\nГончаренко К. С.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(790, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Якщо виникли питання з приводу роботи з програмою є змога отримати більше інформа" +
    "ції за цим посиланням:\r\n\r\n\r\n";
            // 
            // link
            // 
            this.link.FlatAppearance.BorderSize = 0;
            this.link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link.ForeColor = System.Drawing.SystemColors.Highlight;
            this.link.Location = new System.Drawing.Point(22, 227);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(325, 35);
            this.link.TabIndex = 2;
            this.link.Text = "https://www.peremogabudeludonki.com/uk/\r\n";
            this.link.UseVisualStyleBackColor = true;
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // Developers_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 492);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Developers_info";
            this.Text = "Developers_info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button link;
    }
}