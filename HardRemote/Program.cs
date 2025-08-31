using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HardRemote.Properties;

namespace HardRemote
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            //Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            Application.SetCompatibleTextRenderingDefault(false);

            new Thread(() => DisplayProcessor()).Start();
            new Thread(() => ButtonProcessor()).Start();

            switch (Settings.Default.CurrentStyle.ToLowerInvariant())
            {
                case "hardremote":
                default:
                    Application.Run(new HardRemoteStyleForm());
                    break;
                case "1822-old":
                    Application.Run(new EncoderDecoderBoxStyleForm(true, false));
                    break;
                case "1822-new":
                    Application.Run(new EncoderDecoderBoxStyleForm(false, false));
                    break;
                case "3644":
                    Application.Run(new EncoderDecoderBoxStyleForm(false, true));
                    break;
            }

            TryClose();
        }

        public static event EventHandler ScreenUpdated;
        private static string LineOne_ = string.Empty;
        public static string LineOne
        {
            get
            {
                return LineOne_;
            }
            set
            {
                LineOne_ = value;
                ScreenUpdated?.Invoke(null, null);
            }
        }
        private static string LineTwo_ = string.Empty;
        private static string LineTwo
        {
            get
            {
                return LineTwo_;
            }
            set
            {
                LineTwo_ = value;
                ScreenUpdated?.Invoke(null, null);
            }
        }
        private static string LineThree_ = string.Empty;
        private static string LineThree
        {
            get
            {
                return LineThree_;
            }
            set
            {
                LineThree_ = value;
                ScreenUpdated?.Invoke(null, null);
            }
        }
        private static string LineFour_ = string.Empty;
        private static string LineFour
        {
            get
            {
                return LineFour_;
            }
            set
            {
                LineFour_ = value;
                ScreenUpdated?.Invoke(null, null);
            }
        }

        public static bool Ready = false;
        public static bool Running = true;
        public static SerialPort Port { get; private set; } = new SerialPort();

        public static readonly List<string> LineLocations = new List<string>
        {
            "0x40",
            "0x41",
            "0x42",
            "0x43",
            "0x44",
            "0x45",
            "0x46",
            "0x47",
            "0x48",
            "0x49",
            "0x4a",
            "0x4b",
            "0x4a", // I'm basing this off Aaron's code, idek if this should stay or not (duplicate)
            "0x4d",
            "0x4e",
            "0x4f",
            "0x50",
            "0x51",
            "0x52",
            "0x53"
        };

        private static void TryClose()
        {
            lock (Commands)
            {
                Commands.Clear();

                lock (Port)
                {
                    try
                    {
                        Port.Close();
                    }
                    catch (Exception)
                    {
                    }

                    Environment.Exit(0);
                }
            }
        }

        private static void DisplayProcessor()
        {
            while (!Ready) Thread.Sleep(1);

            while (Running)
            {
                try
                {
                    if (!Port.IsOpen)
                    {
                        Port.PortName = $"COM{Settings.Default.COMPortNumber}";
                        Port.BaudRate = int.Parse(Settings.Default.COMBaudRate);
                        Port.ReadTimeout = 10000;
                        Port.WriteTimeout = 10000;
                        LineOne = "Opening port...";
                        LineTwo = string.Empty;
                        LineThree = string.Empty;
                        LineFour = string.Empty;
                        Thread.Sleep(500);
                        Port.Open();
                    }
                    else
                    {
                        Port.Close();
                        LineOne = "Reopening port...";
                        LineTwo = string.Empty;
                        LineThree = string.Empty;
                        LineFour = string.Empty;
                        Thread.Sleep(500);
                        Port.Open();
                    }

                    LineOne = string.Empty;
                    LineTwo = string.Empty;
                    LineThree = string.Empty;
                    LineFour = string.Empty;

                    StringBuilder buffer = new StringBuilder();

                    //string LastByteBuffMen = "";

                    bool JustConnected = true;

                    DateTime LastDataReceived = DateTime.UtcNow;

                    int state = 0;
                    char location = '\0';
                    string to_update_buff = "";

                    while (Running & Port.IsOpen)
                    {
                        LastDataReceived = DateTime.UtcNow;

                        //while (Port.BytesToRead == 0)
                        //{
                        //    if ((int)(DateTime.UtcNow - LastDataReceived).TotalSeconds >= 15)
                        //    {
                        //        throw new TimeoutException("Waited too long for any data.");
                        //    }
                        //    Thread.Sleep(1);
                        //}

                        char LastReadChar = (char)Port.ReadChar();

                        switch (state)
                        {
                            case 0: // Waiting for ESC
                                if (LastReadChar == 0x1b) state = 1;
                                break;
                            case 1: // Waiting for 0x49
                                if (LastReadChar == 0x49) state = 2;
                                else state = 0;
                                break;
                            case 2: // Read location
                                location = LastReadChar;
                                state = 3;
                                break;
                            case 3:
                                if (LastReadChar == 0x40)
                                {
                                    to_update_buff = string.Empty;
                                    state = 4;
                                }
                                else
                                {
                                    if (LineLocations.Contains("0x" + ((int)LastReadChar).ToString("x2")))
                                    {
                                        to_update_buff = string.Empty;
                                        state = 200;
                                    }
                                    else
                                    {
                                        state = 0;
                                    }
                                }
                                break;
                            case 4:
                                if (LastReadChar == 0x1b) state = 5;
                                else
                                {
                                    to_update_buff += LastReadChar;
                                    if (to_update_buff.Length >= 20)
                                    {
                                        switch (location)
                                        {
                                            case '@': LineOne = to_update_buff; break;
                                            case 'A': LineTwo = to_update_buff; break;
                                            case 'B': LineThree = to_update_buff; break;
                                            case 'C': LineFour = to_update_buff; break;
                                        }
                                        state = 0;
                                    }
                                }
                                break;
                            case 5:
                                if (LastReadChar == 0x4B) // CLEAR THE FUCKING LINE
                                {
                                    switch (location)
                                    {
                                        case '@': 
                                            LineOne = string.Empty;
                                            break;
                                        case 'A':
                                            LineTwo = string.Empty;
                                            break;
                                        case 'B':
                                            LineThree = string.Empty;
                                            break;
                                        case 'C':
                                            LineFour = string.Empty;
                                            break;
                                    }
                                }
                                state = 0;
                                break;
                            case 200: // I don't know if I'll implement this, I haven't seen any usage of this while testing
                                if (LastReadChar == 0x1b)
                                {
                                    // SetCharAt(location, to_update_index, to_update_buff);
                                    // ???
                                    to_update_buff = "";
                                    state = 1;
                                }
                                else
                                {
                                    to_update_buff += LastReadChar;
                                    // set character at
                                }
                                break;
                        }

                        if (JustConnected)
                        {
                            JustConnected = false;
                            Commands.Add(CommandStatement.EnterButton);
                            Commands.Add(CommandStatement.BlankButton);
                            Commands.Add(CommandStatement.BlankButton);
                        }
                        else
                        {
                            //if (AGSASD)
                            //{
                            //    AGSASD = false;
                            //    Commands.Add(CommandStatement.EnterButton);
                            //    Commands.Add(CommandStatement.DownButton);
                            //    Commands.Add(CommandStatement.DownButton);
                            //    Commands.Add(CommandStatement.DownButton);
                            //    Commands.Add(CommandStatement.DownButton);
                            //    Commands.Add(CommandStatement.UpButton);
                            //    Commands.Add(CommandStatement.UpButton);
                            //    Commands.Add(CommandStatement.UpButton);
                            //    Commands.Add(CommandStatement.UpButton);
                            //}
                        }

                        //if (LastByteBuffMen.StartsWith("@@"))
                        //{
                        //    LineOne = LastByteBuffMen;
                        //}

                        //Thread.Sleep(100);
                    }
                }
                catch (TimeoutException ex)
                {
                    LineOne = $"Timed out!";
                    LineTwo = string.Empty;
                    LineThree = string.Empty;
                    LineFour = string.Empty;
                    Console.WriteLine($"[Display Processor] {ex.Message} {ex.StackTrace}");
                    Thread.Sleep(500);
                }
                catch (UnauthorizedAccessException ex)
                {
                    LineOne = $"Unauthorized!";
                    LineTwo = string.Empty;
                    LineThree = $"{ex.Message}";
                    LineFour = string.Empty;
                    Console.WriteLine($"[Display Processor] {ex.Message} {ex.StackTrace}");
                    Thread.Sleep(500);
                }
                catch (IOException ex)
                {
                    LineOne = string.Empty;
                    LineTwo = string.Empty;
                    LineThree = string.Empty;
                    LineFour = string.Empty;

                    if (ex.Message.Contains("The port") && ex.Message.Contains("does not exist."))
                    {
                        LineOne = $"Port non-existant!";
                        LineThree = $"Please update your";
                        LineFour = $"HardRemote config.";
                    }
                    else
                    {
                        if (ex.Message.Contains("Access is denied"))
                        {
                            LineOne = $"Port access denied!";
                        }
                        else
                        {
                            LineOne = $"I/O error!";
                            LineTwo = $"{ex.Message}";
                        }
                    }
                    Console.WriteLine($"[Display Processor] {ex.Message} {ex.StackTrace}");
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    LineOne = $"General error!";
                    LineTwo = $"{ex.GetType().Name}";
                    LineThree = $"{ex.Message}";
                    LineFour = string.Empty;
                    //LineFour = $"{ex.GetType().Name}";
                    Console.WriteLine($"[Display Processor] {ex.Message} {ex.StackTrace}");
                    Thread.Sleep(1000);
                }
                finally
                {
                    //Port.Dispose();
                    //Port = new SerialPort();
                }
            }
        }

        private static void ButtonProcessor()
        {
            while (!Ready) Thread.Sleep(1);

            while (Running)
            {
                try
                {
                    while (Running & Port.IsOpen)
                    {
                        byte ControlC = 0x03;
                        byte LetterA = 0x61;
                        byte LetterB = 0x62;
                        byte LetterC = 0x63;
                        byte LetterD = 0x64;

                        bool AnyAction = false;
                        CommandStatement command = CommandStatement.EnterButton;

                        // Enter Password
                        // Enter Admin

                        lock (Commands)
                        {
                            if (Commands.Any())
                            {
                                command = Commands[0];
                                Commands.RemoveAt(0);
                                AnyAction = true;
                            }
                        }

                        if (AnyAction)
                        {
                            PasswordStarCount++;

                            switch (command)
                            {
                                case CommandStatement.EnterButton:
                                    Port.Write(new byte[] { ControlC }, 0, 1);
                                    //Thread.Sleep(50);
                                    Port.Write(new byte[] { LetterA }, 0, 1);
                                    break;
                                case CommandStatement.BlankButton:
                                    Port.Write(new byte[] { ControlC }, 0, 1);
                                    //Thread.Sleep(50);
                                    Port.Write(new byte[] { LetterB }, 0, 1);
                                    break;
                                case CommandStatement.UpButton:
                                    Port.Write(new byte[] { ControlC }, 0, 1);
                                    //Thread.Sleep(50);
                                    Port.Write(new byte[] { LetterC }, 0, 1);
                                    break;
                                case CommandStatement.DownButton:
                                    Port.Write(new byte[] { ControlC }, 0, 1);
                                    //Thread.Sleep(50);
                                    Port.Write(new byte[] { LetterD }, 0, 1);
                                    break;
                                default:
                                    continue;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Button Processor] {ex.Message}");
                }
            }
        }

        public static void SendButtonPress(CommandStatement command)
        {
            lock (Commands)
            {
                Commands.Add(command);
            }
        }

        private static char LastLoaderCharacter = '.';
        
        private static string NextLoaderCharacter()
        {
            switch (LastLoaderCharacter)
            {
                default:
                    LastLoaderCharacter = '-';
                    return "-";
                case '-':
                    LastLoaderCharacter = '\\';
                    return @"\";
                case '\\':
                    LastLoaderCharacter = '|';
                    return "|";
                case '|':
                    LastLoaderCharacter = '/';
                    return "/";
                case '/':
                    LastLoaderCharacter = '-';
                    return "-";
            }
        }

        //private static readonly Random rnd = new Random();

        //private static bool RandomTrueFalse()
        //{
        //    return rnd.Next(0, 2) == 1;
        //}

        //private static bool Startup()
        //{
        //    string line1 = LineOne.ToLowerInvariant();
        //    string line2 = LineTwo.ToLowerInvariant();
        //    string line3 = LineThree.ToLowerInvariant();
        //    string line4 = LineFour.ToLowerInvariant();

        //    if (line1.Contains("sage eas endec") ||
        //        line2.Contains("loading dsp") ||
        //        line4.Contains("rom test") ||
        //        line2.Contains("self test"))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public static bool ButtonsLockedStatus()
        {
            if (!Port.IsOpen) return true;
            //return false;

            if (Control.IsKeyLocked(Keys.CapsLock)) return false;

            if (LineOne.ToLowerInvariant().StartsWith("lock"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool IncomingAlertLEDStatus()
        {
            //if (Startup()) return RandomTrueFalse();
            return false;
        }

        private static int HoldLightTime = 0;

        public static bool OutgoingAlertLEDStatus()
        {
            //if (Startup()) return RandomTrueFalse();

            string line = LineThree.ToLowerInvariant();
            if (line.Contains("alert in") ||
                line.Contains("audio in") ||
                line.Contains("no audio limit") ||
                line.Contains("remaining:") ||
                line.Contains("sending eom signal"))
            {
                HoldLightTime = 3;
                return true;
            }
            else
            {
                if (HoldLightTime != 0)
                {
                    HoldLightTime--;
                    return true;
                }

                return false;
            }
        }

        public static bool AttentionToneLEDStatus()
        {
            //if (Startup()) return RandomTrueFalse();
            return false;
        }
        
        public static bool AutomaticLEDStatus()
        {
            //if (Startup()) return RandomTrueFalse();

            return Settings.Default.EnableAutomaticLight;
        }

        public static bool PasswordEntry = false;
        public static int PasswordStarCount_ = 0;
        public static int PasswordStarCount
        {
            get
            {
                return PasswordStarCount_;
            }
            set
            {
                PasswordStarCount_ = value;
                if (PasswordEntry) ScreenUpdated?.Invoke(null, null);
            }
        }

        public static string CompileScreen()
        {
            // line 2 ENTER PASS
            // Enter Password
            // Enter Admin

            string line1 = LineOne;
            if (line1.Length > 20) line1 = line1.Substring(0, 20);
            string line2 = LineTwo;
            if (line2.Length > 20) line2 = line2.Substring(0, 20);
            string line3 = LineThree;
            if (line3.Length > 20) line3 = line3.Substring(0, 20);
            string line4 = LineFour;
            if (line4.Length > 20) line4 = line4.Substring(0, 20);

            if (LineTwo.ToLowerInvariant().Contains("enter password") ||
                LineTwo.ToLowerInvariant().Contains("enter admin"))
            {
                if (PasswordStarCount > 8)
                {
                    PasswordStarCount = 8;
                    PasswordEntry = false;
                }
                else
                {
                    line3 = new string('*', PasswordStarCount);
                    PasswordEntry = true;
                }
            }
            else
            {
                PasswordEntry = false;
                PasswordStarCount = 0;
            }

            return $"{line1}\r\n{line2}\r\n{line3}\r\n{line4}";
        }

        public static List<CommandStatement> Commands = new List<CommandStatement>();

        public enum CommandStatement
        {
            EnterButton,
            BlankButton,
            UpButton,
            DownButton
        }

        public class BorderPanel : Panel
        {
            private Color _BorderColor = Color.Black;

            public Color BorderColor
            {
                get
                {
                    return _BorderColor;
                }
                set
                {
                    _BorderColor = value;
                    Invalidate();
                }
            }

            public int BorderThickness { get; set; } = 2;

            public BorderPanel()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                using (var pen = new Pen(_BorderColor, BorderThickness))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Outset;
                    int offset = BorderThickness / 2;
                    var rect = new Rectangle(
                        offset,
                        offset,
                        Width - BorderThickness,
                        Height - BorderThickness);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
