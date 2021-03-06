using System;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;

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
            MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            string DefaultDeviceID = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).ID;
            for (int i = 0; i < devices.Count; i++)
            {
                DeviceComboBox.Items.Add(devices[i]);
                if (DefaultDeviceID == devices[i].ID)
                {
                    DeviceComboBox.SelectedIndex = i;
                }
            }
        }

        private void SetUIValuesFromDevice()
        {
            MMDevice SelectedAudioDevice = DeviceComboBox.SelectedItem as MMDevice;
            VolumeTrackBar.Value = (int)Math.Round(100 * SelectedAudioDevice.AudioEndpointVolume.MasterVolumeLevelScalar);
            MuteCheckBox.Checked = SelectedAudioDevice.AudioEndpointVolume.Mute;
            VolumeLabel.Text = VolumeTrackBar.Value.ToString();
            PeakMeterTrackBar.Value = (int) Math.Round(100 * MaxObservedVolume);
        }

        private void AudioDataAvailable(object sender, WaveInEventArgs e)
        {
            var buffer = new WaveBuffer(e.Buffer);
            // interpret as 32 bit floating point audio
            for (int index = 0; index < e.BytesRecorded / 4; index++)
            {
                var sample = buffer.FloatBuffer[index];

                // absolute value 
                if (sample < 0) sample = -sample;
                // is this the max value?
                if (sample > MaxObservedVolume) MaxObservedVolume = sample;
            }
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            (DeviceComboBox.SelectedItem as MMDevice).AudioEndpointVolume.MasterVolumeLevelScalar = (float)(VolumeTrackBar.Value / 100.0);
            SetUIValuesFromDevice();
        }

        private void DeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUIValuesFromDevice();
            MMDevice SelectedAudioDevice = DeviceComboBox.SelectedItem as MMDevice;
            if (AudioCapture != null)
            {
                AudioCapture.StopRecording();
                AudioCapture.Dispose();
            }
            AudioCapture = new WasapiCapture(SelectedAudioDevice);
            AudioCapture.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(this.AudioDataAvailable);
            AudioCapture.StartRecording();
        }

        private void MuteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            (DeviceComboBox.SelectedItem as MMDevice).AudioEndpointVolume.Mute = MuteCheckBox.Checked;
            SetUIValuesFromDevice();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            SetUIValuesFromDevice();
        }

        private void PeakMeterResetButton_Click(object sender, EventArgs e)
        {
            MaxObservedVolume = 0.0f;
        }

        private WasapiCapture AudioCapture = null;
        private float MaxObservedVolume = 0.0f; // between 0 and 1, inclusive

        private void PeakMeterTrackBar_ValueChanged(object sender, EventArgs e)
        {
            PeakMeterLabel.Text = PeakMeterTrackBar.Value.ToString();
        }
    }
}
