using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreAudio;

namespace AudioMonitor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDeviceComboBox();
        }

        private void InitializeDeviceComboBox()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(EDataFlow.eCapture, DEVICE_STATE.DEVICE_STATE_ACTIVE);
            for (int i = 0; i < devices.Count; i++)
            {
                DeviceComboBox.Items.Add(devices[i]);
                if (devices[i].Selected)
                {
                    DeviceComboBox.SelectedIndex = i;
                }
            }
        }

        private void SetInterfaceFromDevice()
        {
            VolumeTrackBar.Value = (int)Math.Round(100 * (DeviceComboBox.SelectedItem as MMDevice).AudioEndpointVolume.MasterVolumeLevelScalar);
            MuteCheckBox.Checked = (DeviceComboBox.SelectedItem as MMDevice).AudioEndpointVolume.Mute;
            VolumeLabel.Text = VolumeTrackBar.Value.ToString();
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            (DeviceComboBox.SelectedItem as MMDevice).AudioEndpointVolume.MasterVolumeLevelScalar = VolumeTrackBar.Value / 100;
        }

        private void DeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInterfaceFromDevice();
        }

        private void MuteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            (DeviceComboBox.SelectedItem as MMDevice).AudioEndpointVolume.Mute = MuteCheckBox.Checked;
            SetInterfaceFromDevice();
        }
    }
}
