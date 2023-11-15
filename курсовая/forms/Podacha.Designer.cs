namespace курсовая.forms
{
    partial class Podacha
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
            this.fortheme = new System.Windows.Forms.Panel();
            this.themetitle = new System.Windows.Forms.Label();
            this.theme = new System.Windows.Forms.TextBox();
            this.fordescriptions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.podatu = new System.Windows.Forms.Button();
            this.fortheme.SuspendLayout();
            this.fordescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // fortheme
            // 
            this.fortheme.Controls.Add(this.themetitle);
            this.fortheme.Controls.Add(this.theme);
            this.fortheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.fortheme.Location = new System.Drawing.Point(0, 0);
            this.fortheme.Name = "fortheme";
            this.fortheme.Size = new System.Drawing.Size(864, 135);
            this.fortheme.TabIndex = 0;
            // 
            // themetitle
            // 
            this.themetitle.AutoSize = true;
            this.themetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themetitle.Location = new System.Drawing.Point(200, 60);
            this.themetitle.Name = "themetitle";
            this.themetitle.Size = new System.Drawing.Size(56, 20);
            this.themetitle.TabIndex = 1;
            this.themetitle.Text = "Тема:";
            // 
            // theme
            // 
            this.theme.Location = new System.Drawing.Point(262, 49);
            this.theme.Multiline = true;
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(327, 40);
            this.theme.TabIndex = 0;
            // 
            // fordescriptions
            // 
            this.fordescriptions.Controls.Add(this.label1);
            this.fordescriptions.Controls.Add(this.description);
            this.fordescriptions.Location = new System.Drawing.Point(0, 141);
            this.fordescriptions.Name = "fordescriptions";
            this.fordescriptions.Size = new System.Drawing.Size(864, 176);
            this.fordescriptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(200, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Опис:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(262, 3);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(327, 142);
            this.description.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(368, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Додати докази";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picture.Location = new System.Drawing.Point(262, 323);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(81, 77);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // podatu
            // 
            this.podatu.Location = new System.Drawing.Point(352, 422);
            this.podatu.Name = "podatu";
            this.podatu.Size = new System.Drawing.Size(146, 41);
            this.podatu.TabIndex = 0;
            this.podatu.Text = "Подати заявку";
            this.podatu.UseVisualStyleBackColor = true;
            this.podatu.Click += new System.EventHandler(this.podatu_Click);
            // 
            // Podacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.podatu);
            this.Controls.Add(this.fordescriptions);
            this.Controls.Add(this.fortheme);
            this.Controls.Add(this.picture);
            this.Name = "Podacha";
            this.Text = "Podacha";
            this.fortheme.ResumeLayout(false);
            this.fortheme.PerformLayout();
            this.fordescriptions.ResumeLayout(false);
            this.fordescriptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel fortheme;
        private System.Windows.Forms.Panel fordescriptions;
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.Label themetitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button podatu;
    }
}