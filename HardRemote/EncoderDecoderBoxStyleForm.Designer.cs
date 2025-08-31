namespace HardRemote
{
    partial class EncoderDecoderBoxStyleForm
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
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.BlankButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.DisplayContainerPanel = new System.Windows.Forms.Panel();
            this.DisplayOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RS232ConnectorImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.Model1822Lights = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.OutgoingAlertPanel = new HardRemote.Program.BorderPanel();
            this.IncomingAlertPanel = new HardRemote.Program.BorderPanel();
            this.AttentionTonePanel = new HardRemote.Program.BorderPanel();
            this.AutomaticPanel = new HardRemote.Program.BorderPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Model3644Lights = new System.Windows.Forms.Panel();
            this.IncomingAlertText3644 = new System.Windows.Forms.Label();
            this.AutomaticText3644 = new System.Windows.Forms.Label();
            this.OutgoingAlertText3644 = new System.Windows.Forms.Label();
            this.AttentionToneText3644 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SpeakerImage = new System.Windows.Forms.PictureBox();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.EnterButtonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executeMultiplePressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS232ConnectorImage)).BeginInit();
            this.Model1822Lights.SuspendLayout();
            this.Model3644Lights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakerImage)).BeginInit();
            this.ContainerPanel.SuspendLayout();
            this.EnterButtonMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownButton
            // 
            this.DownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DownButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DownButton.FlatAppearance.BorderSize = 2;
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.Font = new System.Drawing.Font("Arial", 12F);
            this.DownButton.Location = new System.Drawing.Point(299, 215);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(90, 33);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "🔽";
            this.DownButton.UseVisualStyleBackColor = false;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.UpButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpButton.FlatAppearance.BorderSize = 2;
            this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpButton.Font = new System.Drawing.Font("Arial", 12F);
            this.UpButton.Location = new System.Drawing.Point(203, 215);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(90, 33);
            this.UpButton.TabIndex = 2;
            this.UpButton.Text = "🔼";
            this.UpButton.UseVisualStyleBackColor = false;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // BlankButton
            // 
            this.BlankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BlankButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BlankButton.FlatAppearance.BorderSize = 2;
            this.BlankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlankButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BlankButton.Location = new System.Drawing.Point(107, 215);
            this.BlankButton.Name = "BlankButton";
            this.BlankButton.Size = new System.Drawing.Size(90, 33);
            this.BlankButton.TabIndex = 1;
            this.BlankButton.UseVisualStyleBackColor = false;
            this.BlankButton.Click += new System.EventHandler(this.BlankButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.EnterButton.ContextMenuStrip = this.EnterButtonMenu;
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EnterButton.FlatAppearance.BorderSize = 2;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.EnterButton.Location = new System.Drawing.Point(11, 215);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(90, 33);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "ENTER";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // DisplayContainerPanel
            // 
            this.DisplayContainerPanel.BackColor = System.Drawing.Color.Green;
            this.DisplayContainerPanel.Controls.Add(this.DisplayOutput);
            this.DisplayContainerPanel.Location = new System.Drawing.Point(11, 55);
            this.DisplayContainerPanel.Name = "DisplayContainerPanel";
            this.DisplayContainerPanel.Size = new System.Drawing.Size(378, 153);
            this.DisplayContainerPanel.TabIndex = 2;
            // 
            // DisplayOutput
            // 
            this.DisplayOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(201)))), ((int)(((byte)(68)))));
            this.DisplayOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayOutput.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.DisplayOutput.ForeColor = System.Drawing.Color.Black;
            this.DisplayOutput.Location = new System.Drawing.Point(0, 0);
            this.DisplayOutput.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayOutput.Name = "DisplayOutput";
            this.DisplayOutput.Size = new System.Drawing.Size(378, 153);
            this.DisplayOutput.TabIndex = 4;
            this.DisplayOutput.Text = "Please wait...";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(141, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "EAS ENDEC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Maroon;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1096, 11);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 22);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RS232ConnectorImage
            // 
            this.RS232ConnectorImage.Image = global::HardRemote.Properties.Resources.DSUBCONNECT;
            this.RS232ConnectorImage.Location = new System.Drawing.Point(396, 183);
            this.RS232ConnectorImage.Name = "RS232ConnectorImage";
            this.RS232ConnectorImage.Size = new System.Drawing.Size(147, 49);
            this.RS232ConnectorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RS232ConnectorImage.TabIndex = 18;
            this.RS232ConnectorImage.TabStop = false;
            this.RS232ConnectorImage.Click += new System.EventHandler(this.RS232ConnectorImage_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.MinimizeButton.FlatAppearance.BorderSize = 2;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Arial", 9F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(1096, 39);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(22, 22);
            this.MinimizeButton.TabIndex = 15;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Visible = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Model1822Lights
            // 
            this.Model1822Lights.Controls.Add(this.label3);
            this.Model1822Lights.Controls.Add(this.OutgoingAlertPanel);
            this.Model1822Lights.Controls.Add(this.IncomingAlertPanel);
            this.Model1822Lights.Controls.Add(this.AttentionTonePanel);
            this.Model1822Lights.Controls.Add(this.AutomaticPanel);
            this.Model1822Lights.Controls.Add(this.label6);
            this.Model1822Lights.Controls.Add(this.label4);
            this.Model1822Lights.Controls.Add(this.label5);
            this.Model1822Lights.Location = new System.Drawing.Point(393, 55);
            this.Model1822Lights.Name = "Model1822Lights";
            this.Model1822Lights.Size = new System.Drawing.Size(150, 139);
            this.Model1822Lights.TabIndex = 16;
            this.Model1822Lights.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Incoming Alert";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutgoingAlertPanel
            // 
            this.OutgoingAlertPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutgoingAlertPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.OutgoingAlertPanel.BorderThickness = 4;
            this.OutgoingAlertPanel.Location = new System.Drawing.Point(3, 33);
            this.OutgoingAlertPanel.Name = "OutgoingAlertPanel";
            this.OutgoingAlertPanel.Size = new System.Drawing.Size(26, 26);
            this.OutgoingAlertPanel.TabIndex = 7;
            // 
            // IncomingAlertPanel
            // 
            this.IncomingAlertPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IncomingAlertPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.IncomingAlertPanel.BorderThickness = 4;
            this.IncomingAlertPanel.Location = new System.Drawing.Point(3, 1);
            this.IncomingAlertPanel.Name = "IncomingAlertPanel";
            this.IncomingAlertPanel.Size = new System.Drawing.Size(26, 26);
            this.IncomingAlertPanel.TabIndex = 6;
            // 
            // AttentionTonePanel
            // 
            this.AttentionTonePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AttentionTonePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.AttentionTonePanel.BorderThickness = 4;
            this.AttentionTonePanel.Location = new System.Drawing.Point(3, 65);
            this.AttentionTonePanel.Name = "AttentionTonePanel";
            this.AttentionTonePanel.Size = new System.Drawing.Size(26, 26);
            this.AttentionTonePanel.TabIndex = 8;
            // 
            // AutomaticPanel
            // 
            this.AutomaticPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutomaticPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.AutomaticPanel.BorderThickness = 4;
            this.AutomaticPanel.Location = new System.Drawing.Point(3, 97);
            this.AutomaticPanel.Name = "AutomaticPanel";
            this.AutomaticPanel.Size = new System.Drawing.Size(26, 26);
            this.AutomaticPanel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Automatic";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Outgoing Alert";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Attention Tone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Model3644Lights
            // 
            this.Model3644Lights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Model3644Lights.Controls.Add(this.IncomingAlertText3644);
            this.Model3644Lights.Controls.Add(this.AutomaticText3644);
            this.Model3644Lights.Controls.Add(this.OutgoingAlertText3644);
            this.Model3644Lights.Controls.Add(this.AttentionToneText3644);
            this.Model3644Lights.Location = new System.Drawing.Point(549, 175);
            this.Model3644Lights.Name = "Model3644Lights";
            this.Model3644Lights.Size = new System.Drawing.Size(577, 71);
            this.Model3644Lights.TabIndex = 17;
            this.Model3644Lights.Visible = false;
            // 
            // IncomingAlertText3644
            // 
            this.IncomingAlertText3644.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IncomingAlertText3644.BackColor = System.Drawing.Color.DimGray;
            this.IncomingAlertText3644.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.IncomingAlertText3644.ForeColor = System.Drawing.Color.White;
            this.IncomingAlertText3644.Location = new System.Drawing.Point(4, 8);
            this.IncomingAlertText3644.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.IncomingAlertText3644.Name = "IncomingAlertText3644";
            this.IncomingAlertText3644.Size = new System.Drawing.Size(130, 24);
            this.IncomingAlertText3644.TabIndex = 10;
            this.IncomingAlertText3644.Text = "Incoming Alert";
            this.IncomingAlertText3644.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutomaticText3644
            // 
            this.AutomaticText3644.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AutomaticText3644.BackColor = System.Drawing.Color.DimGray;
            this.AutomaticText3644.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AutomaticText3644.ForeColor = System.Drawing.Color.White;
            this.AutomaticText3644.Location = new System.Drawing.Point(442, 8);
            this.AutomaticText3644.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AutomaticText3644.Name = "AutomaticText3644";
            this.AutomaticText3644.Size = new System.Drawing.Size(130, 24);
            this.AutomaticText3644.TabIndex = 13;
            this.AutomaticText3644.Text = "Automatic";
            this.AutomaticText3644.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutgoingAlertText3644
            // 
            this.OutgoingAlertText3644.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OutgoingAlertText3644.BackColor = System.Drawing.Color.DimGray;
            this.OutgoingAlertText3644.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.OutgoingAlertText3644.ForeColor = System.Drawing.Color.White;
            this.OutgoingAlertText3644.Location = new System.Drawing.Point(150, 8);
            this.OutgoingAlertText3644.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OutgoingAlertText3644.Name = "OutgoingAlertText3644";
            this.OutgoingAlertText3644.Size = new System.Drawing.Size(130, 24);
            this.OutgoingAlertText3644.TabIndex = 11;
            this.OutgoingAlertText3644.Text = "Outgoing Alert";
            this.OutgoingAlertText3644.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttentionToneText3644
            // 
            this.AttentionToneText3644.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AttentionToneText3644.BackColor = System.Drawing.Color.DimGray;
            this.AttentionToneText3644.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AttentionToneText3644.ForeColor = System.Drawing.Color.White;
            this.AttentionToneText3644.Location = new System.Drawing.Point(296, 8);
            this.AttentionToneText3644.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AttentionToneText3644.Name = "AttentionToneText3644";
            this.AttentionToneText3644.Size = new System.Drawing.Size(130, 24);
            this.AttentionToneText3644.TabIndex = 12;
            this.AttentionToneText3644.Text = "Attention Tone";
            this.AttentionToneText3644.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(396, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Open Settings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpeakerImage
            // 
            this.SpeakerImage.Location = new System.Drawing.Point(783, 40);
            this.SpeakerImage.Name = "SpeakerImage";
            this.SpeakerImage.Size = new System.Drawing.Size(147, 129);
            this.SpeakerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpeakerImage.TabIndex = 20;
            this.SpeakerImage.TabStop = false;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContainerPanel.Controls.Add(this.SpeakerImage);
            this.ContainerPanel.Controls.Add(this.label7);
            this.ContainerPanel.Controls.Add(this.Model3644Lights);
            this.ContainerPanel.Controls.Add(this.MinimizeButton);
            this.ContainerPanel.Controls.Add(this.label1);
            this.ContainerPanel.Controls.Add(this.RS232ConnectorImage);
            this.ContainerPanel.Controls.Add(this.ExitButton);
            this.ContainerPanel.Controls.Add(this.label2);
            this.ContainerPanel.Controls.Add(this.DisplayContainerPanel);
            this.ContainerPanel.Controls.Add(this.EnterButton);
            this.ContainerPanel.Controls.Add(this.BlankButton);
            this.ContainerPanel.Controls.Add(this.UpButton);
            this.ContainerPanel.Controls.Add(this.DownButton);
            this.ContainerPanel.Controls.Add(this.Model1822Lights);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1131, 261);
            this.ContainerPanel.TabIndex = 16;
            // 
            // EnterButtonMenu
            // 
            this.EnterButtonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeMultiplePressesToolStripMenuItem});
            this.EnterButtonMenu.Name = "EnterButtonMenu";
            this.EnterButtonMenu.Size = new System.Drawing.Size(204, 48);
            // 
            // executeMultiplePressesToolStripMenuItem
            // 
            this.executeMultiplePressesToolStripMenuItem.Name = "executeMultiplePressesToolStripMenuItem";
            this.executeMultiplePressesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.executeMultiplePressesToolStripMenuItem.Text = "Execute multiple presses";
            this.executeMultiplePressesToolStripMenuItem.Click += new System.EventHandler(this.ExecuteMultiplePressesToolStripMenuItem_Click);
            // 
            // EncoderDecoderBoxStyleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1131, 261);
            this.Controls.Add(this.ContainerPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EncoderDecoderBoxStyleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardRemote";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EASENDECStyleForm_Load);
            this.DisplayContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RS232ConnectorImage)).EndInit();
            this.Model1822Lights.ResumeLayout(false);
            this.Model3644Lights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpeakerImage)).EndInit();
            this.ContainerPanel.ResumeLayout(false);
            this.EnterButtonMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button BlankButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Panel DisplayContainerPanel;
        private System.Windows.Forms.Label DisplayOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox RS232ConnectorImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel Model1822Lights;
        private System.Windows.Forms.Label label3;
        private Program.BorderPanel OutgoingAlertPanel;
        private Program.BorderPanel IncomingAlertPanel;
        private Program.BorderPanel AttentionTonePanel;
        private Program.BorderPanel AutomaticPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Model3644Lights;
        private System.Windows.Forms.Label IncomingAlertText3644;
        private System.Windows.Forms.Label AutomaticText3644;
        private System.Windows.Forms.Label OutgoingAlertText3644;
        private System.Windows.Forms.Label AttentionToneText3644;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox SpeakerImage;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.ContextMenuStrip EnterButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem executeMultiplePressesToolStripMenuItem;
    }
}

