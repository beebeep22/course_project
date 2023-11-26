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
            this.themetitle = new System.Windows.Forms.Label();
            this.theme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.proof = new System.Windows.Forms.PictureBox();
            this.podatu = new System.Windows.Forms.Button();
            this.addproof = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proof)).BeginInit();
            this.SuspendLayout();
            // 
            // themetitle
            // 
            this.themetitle.AutoSize = true;
            this.themetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themetitle.Location = new System.Drawing.Point(264, 54);
            this.themetitle.Name = "themetitle";
            this.themetitle.Size = new System.Drawing.Size(48, 18);
            this.themetitle.TabIndex = 1;
            this.themetitle.Text = "Тема:";
            // 
            // theme
            // 
            this.theme.Location = new System.Drawing.Point(333, 43);
            this.theme.Multiline = true;
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(327, 40);
            this.theme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Опис:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(333, 131);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(327, 142);
            this.description.TabIndex = 0;
            // 
            // proof
            // 
            this.proof.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.proof.Location = new System.Drawing.Point(333, 303);
            this.proof.Name = "proof";
            this.proof.Size = new System.Drawing.Size(81, 81);
            this.proof.TabIndex = 0;
            this.proof.TabStop = false;
            // 
            // podatu
            // 
            this.podatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.podatu.Location = new System.Drawing.Point(421, 437);
            this.podatu.Name = "podatu";
            this.podatu.Size = new System.Drawing.Size(157, 41);
            this.podatu.TabIndex = 0;
            this.podatu.Text = "Подати заявку";
            this.podatu.UseVisualStyleBackColor = true;
            this.podatu.Click += new System.EventHandler(this.podatu_Click);
            // 
            // addproof
            // 
            this.addproof.FlatAppearance.BorderSize = 0;
            this.addproof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproof.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addproof.Location = new System.Drawing.Point(436, 322);
            this.addproof.Name = "addproof";
            this.addproof.Size = new System.Drawing.Size(157, 44);
            this.addproof.TabIndex = 2;
            this.addproof.Text = "+Додати доказ";
            this.addproof.UseVisualStyleBackColor = true;
            this.addproof.Click += new System.EventHandler(this.addproof_Click);
            // 
            // Podacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 516);
            this.Controls.Add(this.addproof);
            this.Controls.Add(this.themetitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.description);
            this.Controls.Add(this.podatu);
            this.Controls.Add(this.proof);
            this.Name = "Podacha";
            this.Text = "Podacha";
            ((System.ComponentModel.ISupportInitialize)(this.proof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.Label themetitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.PictureBox proof;
        private System.Windows.Forms.Button podatu;
        private System.Windows.Forms.Button addproof;
    }
}