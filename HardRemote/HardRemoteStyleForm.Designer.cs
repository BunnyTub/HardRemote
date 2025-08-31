namespace HardRemote
{
    partial class HardRemoteStyleForm
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
            this.DisplayContainerPanel = new System.Windows.Forms.Panel();
            this.DisplayOutput = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.BlankButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.OpenSettingsButton = new System.Windows.Forms.Button();
            this.IncomingAlertText = new System.Windows.Forms.Label();
            this.AutomaticText = new System.Windows.Forms.Label();
            this.OutgoingAlertText = new System.Windows.Forms.Label();
            this.AttentionToneText = new System.Windows.Forms.Label();
            this.DisplayContainerPanel.SuspendLayout();
            this.ContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayContainerPanel
            // 
            this.DisplayContainerPanel.BackColor = System.Drawing.Color.Green;
            this.DisplayContainerPanel.Controls.Add(this.DisplayOutput);
            this.DisplayContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.DisplayContainerPanel.Name = "DisplayContainerPanel";
            this.DisplayContainerPanel.Size = new System.Drawing.Size(378, 153);
            this.DisplayContainerPanel.TabIndex = 2;
            // 
            // DisplayOutput
            // 
            this.DisplayOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
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
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EnterButton.FlatAppearance.BorderSize = 2;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.EnterButton.Location = new System.Drawing.Point(3, 162);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(90, 33);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "ENTER";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // BlankButton
            // 
            this.BlankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BlankButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BlankButton.FlatAppearance.BorderSize = 2;
            this.BlankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlankButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BlankButton.Location = new System.Drawing.Point(99, 162);
            this.BlankButton.Name = "BlankButton";
            this.BlankButton.Size = new System.Drawing.Size(90, 33);
            this.BlankButton.TabIndex = 1;
            this.BlankButton.UseVisualStyleBackColor = false;
            this.BlankButton.Click += new System.EventHandler(this.BlankButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.UpButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpButton.FlatAppearance.BorderSize = 2;
            this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpButton.Font = new System.Drawing.Font("Arial", 12F);
            this.UpButton.Location = new System.Drawing.Point(195, 162);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(90, 33);
            this.UpButton.TabIndex = 2;
            this.UpButton.Text = "🔼";
            this.UpButton.UseVisualStyleBackColor = false;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DownButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DownButton.FlatAppearance.BorderSize = 2;
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.Font = new System.Drawing.Font("Arial", 12F);
            this.DownButton.Location = new System.Drawing.Point(291, 162);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(90, 33);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "🔽";
            this.DownButton.UseVisualStyleBackColor = false;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContainerPanel.Controls.Add(this.OpenSettingsButton);
            this.ContainerPanel.Controls.Add(this.IncomingAlertText);
            this.ContainerPanel.Controls.Add(this.AutomaticText);
            this.ContainerPanel.Controls.Add(this.OutgoingAlertText);
            this.ContainerPanel.Controls.Add(this.DisplayContainerPanel);
            this.ContainerPanel.Controls.Add(this.AttentionToneText);
            this.ContainerPanel.Controls.Add(this.EnterButton);
            this.ContainerPanel.Controls.Add(this.BlankButton);
            this.ContainerPanel.Controls.Add(this.UpButton);
            this.ContainerPanel.Controls.Add(this.DownButton);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(386, 287);
            this.ContainerPanel.TabIndex = 16;
            // 
            // OpenSettingsButton
            // 
            this.OpenSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.OpenSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OpenSettingsButton.FlatAppearance.BorderSize = 2;
            this.OpenSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSettingsButton.Font = new System.Drawing.Font("Arial", 12F);
            this.OpenSettingsButton.Location = new System.Drawing.Point(3, 249);
            this.OpenSettingsButton.Name = "OpenSettingsButton";
            this.OpenSettingsButton.Size = new System.Drawing.Size(378, 33);
            this.OpenSettingsButton.TabIndex = 14;
            this.OpenSettingsButton.Text = "Open Settings";
            this.OpenSettingsButton.UseVisualStyleBackColor = false;
            this.OpenSettingsButton.Click += new System.EventHandler(this.OpenSettingsButton_Click);
            // 
            // IncomingAlertText
            // 
            this.IncomingAlertText.BackColor = System.Drawing.Color.Transparent;
            this.IncomingAlertText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.IncomingAlertText.ForeColor = System.Drawing.Color.White;
            this.IncomingAlertText.Location = new System.Drawing.Point(3, 198);
            this.IncomingAlertText.Margin = new System.Windows.Forms.Padding(0);
            this.IncomingAlertText.Name = "IncomingAlertText";
            this.IncomingAlertText.Size = new System.Drawing.Size(120, 24);
            this.IncomingAlertText.TabIndex = 10;
            this.IncomingAlertText.Text = "Incoming Alert";
            this.IncomingAlertText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AutomaticText
            // 
            this.AutomaticText.BackColor = System.Drawing.Color.Transparent;
            this.AutomaticText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AutomaticText.ForeColor = System.Drawing.Color.White;
            this.AutomaticText.Location = new System.Drawing.Point(261, 222);
            this.AutomaticText.Margin = new System.Windows.Forms.Padding(0);
            this.AutomaticText.Name = "AutomaticText";
            this.AutomaticText.Size = new System.Drawing.Size(120, 24);
            this.AutomaticText.TabIndex = 13;
            this.AutomaticText.Text = "Automatic";
            this.AutomaticText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutgoingAlertText
            // 
            this.OutgoingAlertText.BackColor = System.Drawing.Color.Transparent;
            this.OutgoingAlertText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.OutgoingAlertText.ForeColor = System.Drawing.Color.White;
            this.OutgoingAlertText.Location = new System.Drawing.Point(3, 222);
            this.OutgoingAlertText.Margin = new System.Windows.Forms.Padding(0);
            this.OutgoingAlertText.Name = "OutgoingAlertText";
            this.OutgoingAlertText.Size = new System.Drawing.Size(120, 24);
            this.OutgoingAlertText.TabIndex = 11;
            this.OutgoingAlertText.Text = "Outgoing Alert";
            this.OutgoingAlertText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AttentionToneText
            // 
            this.AttentionToneText.BackColor = System.Drawing.Color.Transparent;
            this.AttentionToneText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AttentionToneText.ForeColor = System.Drawing.Color.White;
            this.AttentionToneText.Location = new System.Drawing.Point(261, 198);
            this.AttentionToneText.Margin = new System.Windows.Forms.Padding(0);
            this.AttentionToneText.Name = "AttentionToneText";
            this.AttentionToneText.Size = new System.Drawing.Size(120, 24);
            this.AttentionToneText.TabIndex = 12;
            this.AttentionToneText.Text = "Attention Tone";
            this.AttentionToneText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HardRemoteStyleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(386, 287);
            this.Controls.Add(this.ContainerPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HardRemoteStyleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardRemote";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EASENDECStyleForm_Load);
            this.DisplayContainerPanel.ResumeLayout(false);
            this.ContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DisplayContainerPanel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button BlankButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Label IncomingAlertText;
        private System.Windows.Forms.Label AutomaticText;
        private System.Windows.Forms.Label OutgoingAlertText;
        private System.Windows.Forms.Label AttentionToneText;
        private System.Windows.Forms.Label DisplayOutput;
        private System.Windows.Forms.Button OpenSettingsButton;
    }
}

