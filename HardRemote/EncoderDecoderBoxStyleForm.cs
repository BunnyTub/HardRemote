using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using HardRemote.Properties;

namespace HardRemote
{
    public partial class EncoderDecoderBoxStyleForm : Form
    {
        public EncoderDecoderBoxStyleForm(bool OlderVariantOf1822, bool Use3644BoxStyle)
        {
            InitializeComponent();
            Program.ScreenUpdated += UpdateFormDisplay;

            if (OlderVariantOf1822)
            {
                BlankButton.Text = "OPTION";
            }
            else
            {
                BlankButton.Text = string.Empty;
            }

            if (Use3644BoxStyle)
            {
                BackColor = Color.FromArgb(28, 48, 112);
                Model1822Lights.Visible = false;
                Model3644Lights.Visible = true;
                label2.Text = "DIGITAL ENDEC";
                Width = 1147;
            }
            else
            {
                BackColor = Color.FromArgb(50, 50, 50);
                Model3644Lights.Visible = false;
                Model1822Lights.Visible = true;
                label2.Text = "EAS ENDEC";
                Width = 575;
            }

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

                    IncomingAlertPanel.BackColor = Incoming ? Color.Red : Color.FromArgb(64, 0, 0);
                    OutgoingAlertPanel.BackColor = Outgoing ? Color.Red : Color.FromArgb(64, 0, 0);
                    AttentionTonePanel.BackColor = Attention ? Color.Red : Color.FromArgb(64, 0, 0);
                    AutomaticPanel.BackColor = Automatic ? Color.Red : Color.FromArgb(64, 0, 0);
                
                    IncomingAlertText3644.BackColor = Incoming ? Color.Red : Color.DimGray;
                    OutgoingAlertText3644.BackColor = Outgoing ? Color.Red : Color.DimGray;
                    AttentionToneText3644.BackColor = Attention ? Color.Red : Color.DimGray;
                    AutomaticText3644.BackColor = Automatic ? Color.Red : Color.DimGray;

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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RS232ConnectorImage_Click(object sender, EventArgs e)
        {
            new ConfigurationForm().ShowDialog();
            MessageBox.Show("If you made styling changes, restart the program to see them.");
        }

        private void ExecuteMultiplePressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("buttons.txt");
                foreach (string line in lines)
                {
                    switch (line.Trim().ToLowerInvariant())
                    {
                        case "enter":
                            Program.SendButtonPress(Program.CommandStatement.EnterButton);
                            break;
                        case "select":
                        case "blank":
                            Program.SendButtonPress(Program.CommandStatement.BlankButton);
                            break;
                        case "up":
                            Program.SendButtonPress(Program.CommandStatement.UpButton);
                            break;
                        case "down":
                            Program.SendButtonPress(Program.CommandStatement.DownButton);
                            break;
                        case "wait500ms":
                            Thread.Sleep(500);
                            break;
                        case "wait1s":
                            Thread.Sleep(1000);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not use \"buttons.txt\".\r\n" +
                    $"{ex.Message}",
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
