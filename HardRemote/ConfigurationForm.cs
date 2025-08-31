using System;
using System.Windows.Forms;
using HardRemote.Properties;

namespace HardRemote
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            EnableAutomaticLightBox.Checked = Settings.Default.EnableAutomaticLight;
            EnableAutomaticLightBox.CheckedChanged += (a, b) => Settings.Default.EnableAutomaticLight = ((CheckBox)a).Checked;
            
            COMPortNumberInput.Value = Settings.Default.COMPortNumber;
            COMPortNumberInput.ValueChanged += (a, b) => Settings.Default.COMPortNumber = (int)((NumericUpDown)a).Value;

            COMBaudRateCombo.Text = Settings.Default.COMBaudRate;
            COMBaudRateCombo.SelectedValueChanged += (a, b) => Settings.Default.COMBaudRate = ((ComboBox)a).Text;
            
            StyleSelectorCombo.Text = Settings.Default.CurrentStyle;
            StyleSelectorCombo.SelectedValueChanged += (a, b) => Settings.Default.CurrentStyle = ((ComboBox)a).Text;
            
            PlayBeepsDuringAlertBox.Checked = Settings.Default.PlayBeepsDuringAlert;
            PlayBeepsDuringAlertBox.CheckedChanged += (a, b) => Settings.Default.PlayBeepsDuringAlert = ((CheckBox)a).Checked;
            
            TitleIsLineOneBox.Checked = Settings.Default.TitleIsLineOne;
            TitleIsLineOneBox.CheckedChanged += (a, b) => Settings.Default.TitleIsLineOne = ((CheckBox)a).Checked;

            //CloseButton.Text = $"{RemainingTime}s";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Close();
        }

        int RemainingTime = 5;

        private void ButtonAutoClicker_Tick(object sender, EventArgs e)
        {
            if (RemainingTime <= 0)
            {
                ButtonAutoClicker.Stop();
                RemainingTime = 60;
                CloseButton.PerformClick();
                return;
            }

            RemainingTime--;
            CloseButton.Text = $"{RemainingTime}s";
        }

        private void PauseTimerButton_Click(object sender, EventArgs e)
        {
            ButtonAutoClicker.Stop();
            RemainingTime = 60;
            CloseButton.Text = $"Start";
        }
    }
}
