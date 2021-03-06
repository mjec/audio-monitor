
namespace AudioMonitor
{
    partial class MainWindow
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

            if (AudioCapture != null)
            {
                AudioCapture.StopRecording();
                AudioCapture.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.DeviceComboBox = new System.Windows.Forms.ComboBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.MuteCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.PeakMeterTrackBar = new System.Windows.Forms.TrackBar();
            this.PeakMeterLabel = new System.Windows.Forms.Label();
            this.UILabelSetVolume = new System.Windows.Forms.Label();
            this.UILabelPeakMeter = new System.Windows.Forms.Label();
            this.PeakMeterResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeakMeterTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.LargeChange = 10;
            this.VolumeTrackBar.Location = new System.Drawing.Point(22, 34);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeTrackBar.Size = new System.Drawing.Size(45, 279);
            this.VolumeTrackBar.TabIndex = 1;
            this.VolumeTrackBar.TickFrequency = 5;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // DeviceComboBox
            // 
            this.DeviceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceComboBox.DisplayMember = "FriendlyName";
            this.DeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceComboBox.FormattingEnabled = true;
            this.DeviceComboBox.Location = new System.Drawing.Point(13, 367);
            this.DeviceComboBox.Name = "DeviceComboBox";
            this.DeviceComboBox.Size = new System.Drawing.Size(160, 23);
            this.DeviceComboBox.TabIndex = 2;
            this.DeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.DeviceComboBox_SelectedIndexChanged);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VolumeLabel.Location = new System.Drawing.Point(22, 316);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(45, 23);
            this.VolumeLabel.TabIndex = 3;
            this.VolumeLabel.Text = "0";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MuteCheckBox
            // 
            this.MuteCheckBox.AutoSize = true;
            this.MuteCheckBox.Location = new System.Drawing.Point(22, 342);
            this.MuteCheckBox.Name = "MuteCheckBox";
            this.MuteCheckBox.Size = new System.Drawing.Size(54, 19);
            this.MuteCheckBox.TabIndex = 4;
            this.MuteCheckBox.Text = "Mute";
            this.MuteCheckBox.UseVisualStyleBackColor = true;
            this.MuteCheckBox.CheckedChanged += new System.EventHandler(this.MuteCheckBox_CheckedChanged);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 50;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // PeakMeterTrackBar
            // 
            this.PeakMeterTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.PeakMeterTrackBar.Cursor = System.Windows.Forms.Cursors.No;
            this.PeakMeterTrackBar.Enabled = false;
            this.PeakMeterTrackBar.LargeChange = 10;
            this.PeakMeterTrackBar.Location = new System.Drawing.Point(119, 34);
            this.PeakMeterTrackBar.Maximum = 100;
            this.PeakMeterTrackBar.Name = "PeakMeterTrackBar";
            this.PeakMeterTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.PeakMeterTrackBar.Size = new System.Drawing.Size(45, 279);
            this.PeakMeterTrackBar.TabIndex = 5;
            this.PeakMeterTrackBar.TickFrequency = 5;
            this.PeakMeterTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PeakMeterTrackBar.ValueChanged += new System.EventHandler(this.PeakMeterTrackBar_ValueChanged);
            // 
            // PeakMeterLabel
            // 
            this.PeakMeterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PeakMeterLabel.Location = new System.Drawing.Point(119, 316);
            this.PeakMeterLabel.Name = "PeakMeterLabel";
            this.PeakMeterLabel.Size = new System.Drawing.Size(45, 23);
            this.PeakMeterLabel.TabIndex = 6;
            this.PeakMeterLabel.Text = "0";
            this.PeakMeterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UILabelSetVolume
            // 
            this.UILabelSetVolume.AutoSize = true;
            this.UILabelSetVolume.Location = new System.Drawing.Point(13, 16);
            this.UILabelSetVolume.Name = "UILabelSetVolume";
            this.UILabelSetVolume.Size = new System.Drawing.Size(66, 15);
            this.UILabelSetVolume.TabIndex = 7;
            this.UILabelSetVolume.Text = "Set Volume";
            this.UILabelSetVolume.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UILabelPeakMeter
            // 
            this.UILabelPeakMeter.AutoSize = true;
            this.UILabelPeakMeter.Location = new System.Drawing.Point(107, 16);
            this.UILabelPeakMeter.Name = "UILabelPeakMeter";
            this.UILabelPeakMeter.Size = new System.Drawing.Size(66, 15);
            this.UILabelPeakMeter.TabIndex = 8;
            this.UILabelPeakMeter.Text = "Peak Meter";
            this.UILabelPeakMeter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PeakMeterResetButton
            // 
            this.PeakMeterResetButton.Location = new System.Drawing.Point(119, 339);
            this.PeakMeterResetButton.Name = "PeakMeterResetButton";
            this.PeakMeterResetButton.Size = new System.Drawing.Size(45, 23);
            this.PeakMeterResetButton.TabIndex = 9;
            this.PeakMeterResetButton.Text = "Reset";
            this.PeakMeterResetButton.UseVisualStyleBackColor = true;
            this.PeakMeterResetButton.Click += new System.EventHandler(this.PeakMeterResetButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 411);
            this.Controls.Add(this.PeakMeterResetButton);
            this.Controls.Add(this.UILabelPeakMeter);
            this.Controls.Add(this.UILabelSetVolume);
            this.Controls.Add(this.PeakMeterLabel);
            this.Controls.Add(this.PeakMeterTrackBar);
            this.Controls.Add(this.MuteCheckBox);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.DeviceComboBox);
            this.Controls.Add(this.VolumeTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 450);
            this.Name = "MainWindow";
            this.Text = "Microphone Volume";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeakMeterTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.ComboBox DeviceComboBox;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.CheckBox MuteCheckBox;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.TrackBar PeakMeterTrackBar;
        private System.Windows.Forms.Label PeakMeterLabel;
        private System.Windows.Forms.Label UILabelSetVolume;
        private System.Windows.Forms.Label UILabelPeakMeter;
        private System.Windows.Forms.Button PeakMeterResetButton;
    }
}