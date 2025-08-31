namespace HardRemote
{
    partial class ConfigurationForm
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
            this.EnableAutomaticLightBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COMPortNumberInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.COMBaudRateCombo = new System.Windows.Forms.ComboBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ButtonAutoClicker = new System.Windows.Forms.Timer(this.components);
            this.StyleSelectorCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayBeepsDuringAlertBox = new System.Windows.Forms.CheckBox();
            this.TitleIsLineOneBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.COMPortNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // EnableAutomaticLightBox
            // 
            this.EnableAutomaticLightBox.AutoSize = true;
            this.EnableAutomaticLightBox.Location = new System.Drawing.Point(12, 12);
            this.EnableAutomaticLightBox.Name = "EnableAutomaticLightBox";
            this.EnableAutomaticLightBox.Size = new System.Drawing.Size(151, 19);
            this.EnableAutomaticLightBox.TabIndex = 0;
            this.EnableAutomaticLightBox.Text = "Enable Automatic Light";
            this.EnableAutomaticLightBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port number";
            // 
            // COMPortNumberInput
            // 
            this.COMPortNumberInput.Location = new System.Drawing.Point(12, 52);
            this.COMPortNumberInput.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.COMPortNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.COMPortNumberInput.Name = "COMPortNumberInput";
            this.COMPortNumberInput.Size = new System.Drawing.Size(46, 21);
            this.COMPortNumberInput.TabIndex = 2;
            this.COMPortNumberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate";
            // 
            // COMBaudRateCombo
            // 
            this.COMBaudRateCombo.FormattingEnabled = true;
            this.COMBaudRateCombo.Items.AddRange(new object[] {
            "9600",
            "2400",
            "1200"});
            this.COMBaudRateCombo.Location = new System.Drawing.Point(12, 94);
            this.COMBaudRateCombo.Name = "COMBaudRateCombo";
            this.COMBaudRateCombo.Size = new System.Drawing.Size(121, 23);
            this.COMBaudRateCombo.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Location = new System.Drawing.Point(12, 222);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(197, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ButtonAutoClicker
            // 
            this.ButtonAutoClicker.Interval = 1000;
            this.ButtonAutoClicker.Tick += new System.EventHandler(this.ButtonAutoClicker_Tick);
            // 
            // StyleSelectorCombo
            // 
            this.StyleSelectorCombo.FormattingEnabled = true;
            this.StyleSelectorCombo.Items.AddRange(new object[] {
            "hardremote",
            "1822-old",
            "1822-new",
            "3644"});
            this.StyleSelectorCombo.Location = new System.Drawing.Point(12, 138);
            this.StyleSelectorCombo.Name = "StyleSelectorCombo";
            this.StyleSelectorCombo.Size = new System.Drawing.Size(121, 23);
            this.StyleSelectorCombo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model selector (Visual only)";
            // 
            // PlayBeepsDuringAlertBox
            // 
            this.PlayBeepsDuringAlertBox.AutoSize = true;
            this.PlayBeepsDuringAlertBox.Location = new System.Drawing.Point(12, 167);
            this.PlayBeepsDuringAlertBox.Name = "PlayBeepsDuringAlertBox";
            this.PlayBeepsDuringAlertBox.Size = new System.Drawing.Size(197, 19);
            this.PlayBeepsDuringAlertBox.TabIndex = 12;
            this.PlayBeepsDuringAlertBox.Text = "Play beep sounds during alerts";
            this.PlayBeepsDuringAlertBox.UseVisualStyleBackColor = true;
            // 
            // TitleIsLineOneBox
            // 
            this.TitleIsLineOneBox.AutoSize = true;
            this.TitleIsLineOneBox.Location = new System.Drawing.Point(12, 192);
            this.TitleIsLineOneBox.Name = "TitleIsLineOneBox";
            this.TitleIsLineOneBox.Size = new System.Drawing.Size(166, 19);
            this.TitleIsLineOneBox.TabIndex = 13;
            this.TitleIsLineOneBox.Text = "Use line 1 for window title";
            this.TitleIsLineOneBox.UseVisualStyleBackColor = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(221, 257);
            this.ControlBox = false;
            this.Controls.Add(this.TitleIsLineOneBox);
            this.Controls.Add(this.PlayBeepsDuringAlertBox);
            this.Controls.Add(this.StyleSelectorCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.COMBaudRateCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.COMPortNumberInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnableAutomaticLightBox);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConfigurationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardRemote - Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.COMPortNumberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EnableAutomaticLightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown COMPortNumberInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COMBaudRateCombo;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Timer ButtonAutoClicker;
        private System.Windows.Forms.ComboBox StyleSelectorCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox PlayBeepsDuringAlertBox;
        private System.Windows.Forms.CheckBox TitleIsLineOneBox;
    }
}