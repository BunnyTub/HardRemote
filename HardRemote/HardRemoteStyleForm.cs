using System;
using System.Drawing;
using System.Windows.Forms;
using HardRemote.Properties;

namespace HardRemote
{
    public partial class HardRemoteStyleForm : Form
    {
        public HardRemoteStyleForm()
        {
            InitializeComponent();
            Program.ScreenUpdated += UpdateFormDisplay;
            Program.Ready = true;
        }

        public void UpdateFormDisplay(object a, EventArgs b)
        {
            try
            {
                void UpdateThis()
                {
                    DisplayOutput.Text = Program.CompileScreen();

                    if (Settings.Default.TitleIsLineOne)
                    {
                        Text = $"HardRemote - {Program.LineOne}";
                    }
                    else
                    {
                        Text = "HardRemote";
                    }

                    bool ButtonsLocked = Program.ButtonsLockedStatus();
                    EnterButton.Enabled = !ButtonsLocked;
                    BlankButton.Enabled = !ButtonsLocked;
                    UpButton.Enabled = !ButtonsLocked;
                    DownButton.Enabled = !ButtonsLocked;
                    bool Incoming = Program.IncomingAlertLEDStatus();
                    bool Outgoing = Program.OutgoingAlertLEDStatus();
                    bool Attention = Program.AttentionToneLEDStatus();
                    bool Automatic = Program.AutomaticLEDStatus();
                
                    IncomingAlertText.BackColor = Incoming ? Color.Red : BackColor;
                    OutgoingAlertText.BackColor = Outgoing ? Color.Red : BackColor;
                    AttentionToneText.BackColor = Attention ? Color.Red : BackColor;
                    AutomaticText.BackColor = Automatic ? Color.Red : BackColor;

                    if (Outgoing) if (Settings.Default.PlayBeepsDuringAlert) Console.Beep();
                }

                Invoke(new Action(UpdateThis));
            }
            catch (Exception)
            {
            }
        }


        private void EnterButton_Click(object sender, EventArgs e)
        {
            Program.SendButtonPress(Program.CommandStatement.EnterButton);
        }

        private void BlankButton_Click(object sender, EventArgs e)
        {
            Program.SendButtonPress(Program.CommandStatement.BlankButton);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            Program.SendButtonPress(Program.CommandStatement.UpButton);
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            Program.SendButtonPress(Program.CommandStatement.DownButton);
        }

        private void EASENDECStyleForm_Load(object sender, EventArgs e)
        {
            //StartPosition = FormStartPosition.Manual;
            //Location = new Point(0, 0);
        }

        private void OpenSettingsButton_Click(object sender, EventArgs e)
        {
            new ConfigurationForm().ShowDialog();
            MessageBox.Show("If you made styling changes, restart the program to see them.");
        }
    }
}
