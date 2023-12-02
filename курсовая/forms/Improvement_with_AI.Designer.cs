namespace курсовая.forms
{
    partial class Improvement_with_AI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Improvement_with_AI));
            this.TopicForAIRequest = new System.Windows.Forms.TextBox();
            this.tokenForAI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopicForAIRequest
            // 
            this.TopicForAIRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopicForAIRequest.Location = new System.Drawing.Point(36, 42);
            this.TopicForAIRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopicForAIRequest.Multiline = true;
            this.TopicForAIRequest.Name = "TopicForAIRequest";
            this.TopicForAIRequest.Size = new System.Drawing.Size(306, 46);
            this.TopicForAIRequest.TabIndex = 0;
            // 
            // tokenForAI
            // 
            this.tokenForAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tokenForAI.Location = new System.Drawing.Point(158, 121);
            this.tokenForAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tokenForAI.Name = "tokenForAI";
            this.tokenForAI.Size = new System.Drawing.Size(76, 21);
            this.tokenForAI.TabIndex = 1;
            this.tokenForAI.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть тему відповіді:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість символів:";
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.Location = new System.Drawing.Point(118, 170);
            this.Generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(136, 31);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Сгенерувати";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Improvement_with_AI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 210);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tokenForAI);
            this.Controls.Add(this.TopicForAIRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Improvement_with_AI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покращити відповідь з AI";
            this.Load += new System.EventHandler(this.Improvement_with_AI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TopicForAIRequest;
        public System.Windows.Forms.TextBox tokenForAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generate;
    }
}