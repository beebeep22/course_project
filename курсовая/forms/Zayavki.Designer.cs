using System.Drawing;
using System.Windows.Forms;

namespace курсовая.forms
{
    partial class Zayavki
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
            this.tableapplication = new System.Windows.Forms.DataGridView();
            this.application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableapplication)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус заявок";
            // 
            // tableapplication
            // 
            this.tableapplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableapplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableapplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.application,
            this.status,
            this.status2});
            this.tableapplication.Location = new System.Drawing.Point(65, 101);
            this.tableapplication.Name = "tableapplication";
            this.tableapplication.RowHeadersWidth = 51;
            this.tableapplication.RowTemplate.Height = 24;
            this.tableapplication.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableapplication.Size = new System.Drawing.Size(421, 244);
            this.tableapplication.TabIndex = 1;
            this.tableapplication.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // application
            // 
            this.application.HeaderText = "Заявка";
            this.application.MinimumWidth = 6;
            this.application.Name = "application";
            this.application.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // status2
            // 
            this.status2.HeaderText = "";
            this.status2.MinimumWidth = 6;
            this.status2.Name = "status2";
            this.status2.Width = 125;
            // 
            // Zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableapplication);
            this.Controls.Add(this.label1);
            this.Name = "Zayavki";
            this.Text = "Zayavki";
            ((System.ComponentModel.ISupportInitialize)(this.tableapplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableapplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn application;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn status2;
    }
}