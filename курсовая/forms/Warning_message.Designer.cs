namespace курсовая.forms
{
    public partial class Warning_message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning_message));
            this.agree = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // agree
            // 
            this.agree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agree.Location = new System.Drawing.Point(113, 210);
            this.agree.Margin = new System.Windows.Forms.Padding(2);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(89, 33);
            this.agree.TabIndex = 0;
            this.agree.Text = "OK";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.Click += new System.EventHandler(this.agree_Click);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.Honeydew;
            this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputText.Location = new System.Drawing.Point(42, 108);
            this.outputText.Margin = new System.Windows.Forms.Padding(2);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(228, 98);
            this.outputText.TabIndex = 1;
            this.outputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсовая.Properties.Resources.грустныйкот128;
            this.pictureBox1.Location = new System.Drawing.Point(104, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Warning_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(310, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.agree);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Warning_message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Попередження";
            this.Load += new System.EventHandler(this.Warning_message_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button agree;
        public System.Windows.Forms.TextBox outputText;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}