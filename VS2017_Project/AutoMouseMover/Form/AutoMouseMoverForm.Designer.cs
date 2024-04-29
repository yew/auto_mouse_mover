namespace AutoMouseMover
{
    partial class AutoMouseMoverForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoMouseMoverForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.MovingTimeLabel = new System.Windows.Forms.Label();
            this.MovingPixelLabel = new System.Windows.Forms.Label();
            this.MovingPixelBox = new System.Windows.Forms.NumericUpDown();
            this.MovingPeriodBox = new System.Windows.Forms.NumericUpDown();
            this.MovingTimeSecondLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CursorTimer = new System.Windows.Forms.Timer(this.components);
            this.TrayBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayBarContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayBarMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayBarMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.StopButton = new System.Windows.Forms.Button();
            this.MinimizeToTrayBarBox = new System.Windows.Forms.CheckBox();
            this.ShowTrayBarIconBox = new System.Windows.Forms.CheckBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.StripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MovingPixelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingPeriodBox)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.TrayBarContextMenu.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(33, 334);
            this.StartButton.Margin = new System.Windows.Forms.Padding(7);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(175, 51);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MovingTimeLabel
            // 
            this.MovingTimeLabel.AutoSize = true;
            this.MovingTimeLabel.Location = new System.Drawing.Point(28, 85);
            this.MovingTimeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MovingTimeLabel.Name = "MovingTimeLabel";
            this.MovingTimeLabel.Size = new System.Drawing.Size(285, 29);
            this.MovingTimeLabel.TabIndex = 3;
            this.MovingTimeLabel.Text = "Move when PC is idle for:";
            // 
            // MovingPixelLabel
            // 
            this.MovingPixelLabel.AutoSize = true;
            this.MovingPixelLabel.Location = new System.Drawing.Point(28, 143);
            this.MovingPixelLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MovingPixelLabel.Name = "MovingPixelLabel";
            this.MovingPixelLabel.Size = new System.Drawing.Size(359, 29);
            this.MovingPixelLabel.TabIndex = 4;
            this.MovingPixelLabel.Text = "Number of pixel to move mouse:";
            // 
            // MovingPixelBox
            // 
            this.MovingPixelBox.Location = new System.Drawing.Point(411, 138);
            this.MovingPixelBox.Margin = new System.Windows.Forms.Padding(7);
            this.MovingPixelBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.MovingPixelBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MovingPixelBox.Name = "MovingPixelBox";
            this.MovingPixelBox.Size = new System.Drawing.Size(117, 35);
            this.MovingPixelBox.TabIndex = 5;
            this.MovingPixelBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MovingPeriodBox
            // 
            this.MovingPeriodBox.Location = new System.Drawing.Point(411, 80);
            this.MovingPeriodBox.Margin = new System.Windows.Forms.Padding(7);
            this.MovingPeriodBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MovingPeriodBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MovingPeriodBox.Name = "MovingPeriodBox";
            this.MovingPeriodBox.Size = new System.Drawing.Size(117, 35);
            this.MovingPeriodBox.TabIndex = 6;
            this.MovingPeriodBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MovingTimeSecondLabel
            // 
            this.MovingTimeSecondLabel.AutoSize = true;
            this.MovingTimeSecondLabel.Location = new System.Drawing.Point(541, 85);
            this.MovingTimeSecondLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MovingTimeSecondLabel.Name = "MovingTimeSecondLabel";
            this.MovingTimeSecondLabel.Size = new System.Drawing.Size(120, 29);
            this.MovingTimeSecondLabel.TabIndex = 7;
            this.MovingTimeSecondLabel.Text = "second(s)";
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 414);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
            this.StatusStrip.Size = new System.Drawing.Size(688, 48);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 8;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(132, 37);
            this.StatusLabel.Text = "Status: {0}";
            // 
            // CursorTimer
            // 
            this.CursorTimer.Tick += new System.EventHandler(this.CursorTimer_Tick);
            // 
            // TrayBarIcon
            // 
            this.TrayBarIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayBarIcon.BalloonTipText = "Magic Star is running in background";
            this.TrayBarIcon.BalloonTipTitle = "Magic Star";
            this.TrayBarIcon.ContextMenuStrip = this.TrayBarContextMenu;
            this.TrayBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayBarIcon.Icon")));
            this.TrayBarIcon.Text = "Magic Star running";
            this.TrayBarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayBarIcon_MouseDoubleClick);
            // 
            // TrayBarContextMenu
            // 
            this.TrayBarContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayBarContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayBarMenuOpen,
            this.TrayBarMenuClose});
            this.TrayBarContextMenu.Name = "TrayBarContextMenu";
            this.TrayBarContextMenu.Size = new System.Drawing.Size(160, 92);
            // 
            // TrayBarMenuOpen
            // 
            this.TrayBarMenuOpen.Name = "TrayBarMenuOpen";
            this.TrayBarMenuOpen.Size = new System.Drawing.Size(159, 44);
            this.TrayBarMenuOpen.Text = "Open";
            this.TrayBarMenuOpen.Click += new System.EventHandler(this.TrayBarMenuOpen_Click);
            // 
            // TrayBarMenuClose
            // 
            this.TrayBarMenuClose.Name = "TrayBarMenuClose";
            this.TrayBarMenuClose.Size = new System.Drawing.Size(159, 44);
            this.TrayBarMenuClose.Text = "Close";
            this.TrayBarMenuClose.Click += new System.EventHandler(this.TrayBarMenuClose_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(480, 334);
            this.StopButton.Margin = new System.Windows.Forms.Padding(7);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(175, 51);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MinimizeToTrayBarBox
            // 
            this.MinimizeToTrayBarBox.AutoSize = true;
            this.MinimizeToTrayBarBox.Checked = true;
            this.MinimizeToTrayBarBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinimizeToTrayBarBox.Location = new System.Drawing.Point(35, 207);
            this.MinimizeToTrayBarBox.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeToTrayBarBox.Name = "MinimizeToTrayBarBox";
            this.MinimizeToTrayBarBox.Size = new System.Drawing.Size(395, 33);
            this.MinimizeToTrayBarBox.TabIndex = 11;
            this.MinimizeToTrayBarBox.Text = "Minimize to tray bar when started";
            this.MinimizeToTrayBarBox.UseVisualStyleBackColor = true;
            this.MinimizeToTrayBarBox.CheckedChanged += new System.EventHandler(this.MinimizeToTrayBarBox_CheckedChanged);
            // 
            // ShowTrayBarIconBox
            // 
            this.ShowTrayBarIconBox.AutoSize = true;
            this.ShowTrayBarIconBox.Checked = true;
            this.ShowTrayBarIconBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowTrayBarIconBox.Location = new System.Drawing.Point(35, 259);
            this.ShowTrayBarIconBox.Margin = new System.Windows.Forms.Padding(7);
            this.ShowTrayBarIconBox.Name = "ShowTrayBarIconBox";
            this.ShowTrayBarIconBox.Size = new System.Drawing.Size(422, 33);
            this.ShowTrayBarIconBox.TabIndex = 12;
            this.ShowTrayBarIconBox.Text = "Show tray bar icon when minimized";
            this.ShowTrayBarIconBox.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuAbout});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.Size = new System.Drawing.Size(688, 54);
            this.MenuStrip.TabIndex = 13;
            // 
            // StripMenuAbout
            // 
            this.StripMenuAbout.Name = "StripMenuAbout";
            this.StripMenuAbout.Size = new System.Drawing.Size(112, 50);
            this.StripMenuAbout.Text = "About";
            this.StripMenuAbout.Click += new System.EventHandler(this.StripMenuAbout_Click);
            // 
            // AutoMouseMoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(688, 462);
            this.Controls.Add(this.ShowTrayBarIconBox);
            this.Controls.Add(this.MinimizeToTrayBarBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.MovingTimeSecondLabel);
            this.Controls.Add(this.MovingPeriodBox);
            this.Controls.Add(this.MovingPixelBox);
            this.Controls.Add(this.MovingPixelLabel);
            this.Controls.Add(this.MovingTimeLabel);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "AutoMouseMoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Star";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoMouseMoverForm_FormClosing);
            this.Resize += new System.EventHandler(this.AutoMouseMoverForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MovingPixelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingPeriodBox)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.TrayBarContextMenu.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label MovingTimeLabel;
        private System.Windows.Forms.Label MovingPixelLabel;
        private System.Windows.Forms.NumericUpDown MovingPixelBox;
        private System.Windows.Forms.NumericUpDown MovingPeriodBox;
        private System.Windows.Forms.Label MovingTimeSecondLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Timer CursorTimer;
        private System.Windows.Forms.NotifyIcon TrayBarIcon;
        private System.Windows.Forms.ContextMenuStrip TrayBarContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayBarMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem TrayBarMenuClose;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.CheckBox MinimizeToTrayBarBox;
        private System.Windows.Forms.CheckBox ShowTrayBarIconBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StripMenuAbout;
    }
}

