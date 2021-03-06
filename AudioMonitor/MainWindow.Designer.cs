
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.DeviceComboBox = new System.Windows.Forms.ComboBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.MuteCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.LargeChange = 10;
            this.VolumeTrackBar.Location = new System.Drawing.Point(12, 12);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeTrackBar.Size = new System.Drawing.Size(45, 310);
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
            this.DeviceComboBox.Location = new System.Drawing.Point(12, 376);
            this.DeviceComboBox.Name = "DeviceComboBox";
            this.DeviceComboBox.Size = new System.Drawing.Size(160, 23);
            this.DeviceComboBox.TabIndex = 2;
            this.DeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.DeviceComboBox_SelectedIndexChanged);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VolumeLabel.Location = new System.Drawing.Point(12, 325);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(45, 23);
            this.VolumeLabel.TabIndex = 3;
            this.VolumeLabel.Text = "0";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MuteCheckBox
            // 
            this.MuteCheckBox.AutoSize = true;
            this.MuteCheckBox.Location = new System.Drawing.Point(12, 351);
            this.MuteCheckBox.Name = "MuteCheckBox";
            this.MuteCheckBox.Size = new System.Drawing.Size(54, 19);
            this.MuteCheckBox.TabIndex = 4;
            this.MuteCheckBox.Text = "Mute";
            this.MuteCheckBox.UseVisualStyleBackColor = true;
            this.MuteCheckBox.CheckedChanged += new System.EventHandler(this.MuteCheckBox_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 411);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.ComboBox DeviceComboBox;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.CheckBox MuteCheckBox;
    }
}