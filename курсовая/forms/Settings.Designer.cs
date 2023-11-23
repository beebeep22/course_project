namespace курсовая.forms
{
    partial class Settings
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
            this.smallsize = new System.Windows.Forms.Button();
            this.Mediumsize = new System.Windows.Forms.Button();
            this.Bigsize = new System.Windows.Forms.Button();
            this.labelshrift = new System.Windows.Forms.Label();
            this.deleteaccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smallsize
            // 
            this.smallsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallsize.Location = new System.Drawing.Point(61, 94);
            this.smallsize.Name = "smallsize";
            this.smallsize.Size = new System.Drawing.Size(113, 45);
            this.smallsize.TabIndex = 0;
            this.smallsize.Text = "Маленький";
            this.smallsize.UseVisualStyleBackColor = true;
            this.smallsize.Click += new System.EventHandler(this.smallsize_Click);
            // 
            // Mediumsize
            // 
            this.Mediumsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mediumsize.Location = new System.Drawing.Point(191, 95);
            this.Mediumsize.Name = "Mediumsize";
            this.Mediumsize.Size = new System.Drawing.Size(112, 44);
            this.Mediumsize.TabIndex = 1;
            this.Mediumsize.Text = "Середній";
            this.Mediumsize.UseVisualStyleBackColor = true;
            this.Mediumsize.Click += new System.EventHandler(this.Mediumsize_Click);
            // 
            // Bigsize
            // 
            this.Bigsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bigsize.Location = new System.Drawing.Point(319, 95);
            this.Bigsize.Name = "Bigsize";
            this.Bigsize.Size = new System.Drawing.Size(112, 44);
            this.Bigsize.TabIndex = 2;
            this.Bigsize.Text = "Великий";
            this.Bigsize.UseVisualStyleBackColor = true;
            this.Bigsize.Click += new System.EventHandler(this.Bigsize_Click);
            // 
            // labelshrift
            // 
            this.labelshrift.AutoSize = true;
            this.labelshrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelshrift.Location = new System.Drawing.Point(58, 51);
            this.labelshrift.Name = "labelshrift";
            this.labelshrift.Size = new System.Drawing.Size(116, 18);
            this.labelshrift.TabIndex = 3;
            this.labelshrift.Text = "Розмір шрифта";
            // 
            // deleteaccount
            // 
            this.deleteaccount.FlatAppearance.BorderSize = 0;
            this.deleteaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteaccount.ForeColor = System.Drawing.Color.Red;
            this.deleteaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteaccount.Location = new System.Drawing.Point(61, 266);
            this.deleteaccount.Name = "deleteaccount";
            this.deleteaccount.Size = new System.Drawing.Size(164, 38);
            this.deleteaccount.TabIndex = 4;
            this.deleteaccount.Text = "Видалити аккаунт";
            this.deleteaccount.UseVisualStyleBackColor = true;
            this.deleteaccount.Click += new System.EventHandler(this.deleteaccount_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteaccount);
            this.Controls.Add(this.labelshrift);
            this.Controls.Add(this.Bigsize);
            this.Controls.Add(this.Mediumsize);
            this.Controls.Add(this.smallsize);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button smallsize;
        private System.Windows.Forms.Button Mediumsize;
        private System.Windows.Forms.Button Bigsize;
        private System.Windows.Forms.Label labelshrift;
        private System.Windows.Forms.Button deleteaccount;
    }
}