﻿namespace SDAM_Assignment
{
    partial class AdminViewBuyersForm
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
            this.flowLayoutPanelBuyers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Buyers";
            // 
            // flowLayoutPanelBuyers
            // 
            this.flowLayoutPanelBuyers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelBuyers.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanelBuyers.Name = "flowLayoutPanelBuyers";
            this.flowLayoutPanelBuyers.Size = new System.Drawing.Size(1358, 533);
            this.flowLayoutPanelBuyers.TabIndex = 2;
            // 
            // AdminViewBuyersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelBuyers);
            this.Name = "AdminViewBuyersForm";
            this.Text = "ViewBuyers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBuyers;
    }
}