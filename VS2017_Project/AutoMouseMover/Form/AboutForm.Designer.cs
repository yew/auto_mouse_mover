﻿namespace AutoMouseMover
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ProductLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.Copyright2Label = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(28, 20);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(44, 29);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "{0}";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(28, 118);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(132, 29);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version {0}";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(28, 167);
            this.CopyrightLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(44, 29);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "{0}";
            // 
            // Copyright2Label
            // 
            this.Copyright2Label.AutoSize = true;
            this.Copyright2Label.Location = new System.Drawing.Point(28, 216);
            this.Copyright2Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Copyright2Label.Name = "Copyright2Label";
            this.Copyright2Label.Size = new System.Drawing.Size(212, 29);
            this.Copyright2Label.TabIndex = 3;
            this.Copyright2Label.Text = "All rights reserved.";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(184, 281);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(175, 51);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(28, 69);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(44, 29);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "{0}";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Copyright2Label);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ProductLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Label Copyright2Label;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}