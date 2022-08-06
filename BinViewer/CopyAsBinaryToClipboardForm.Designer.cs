namespace BinViewer
{
    partial class CopyAsBinaryToClipboardForm
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
            this.labelSetOrigin = new System.Windows.Forms.Label();
            this.OriginUpDown = new System.Windows.Forms.NumericUpDown();
            this.CopyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IncludeMemoryAddressCheckBox = new System.Windows.Forms.CheckBox();
            this.SetOriginLabel = new System.Windows.Forms.Label();
            this.SeparateByteBitsByPanel = new System.Windows.Forms.Panel();
            this.SeparateByteBitsByLabel = new System.Windows.Forms.Label();
            this.SeparateByNothingRadioButton = new System.Windows.Forms.RadioButton();
            this.seperateByCommaRadioButton = new System.Windows.Forms.RadioButton();
            this.seperateBySpaceRadioButton = new System.Windows.Forms.RadioButton();
            this.BytesPerRowPanel = new System.Windows.Forms.Panel();
            this.BytesPerRowRadioButton = new System.Windows.Forms.RadioButton();
            this.OneBytePerRowRadioButton = new System.Windows.Forms.RadioButton();
            this.BytesPerRowLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormatAddressesAsThirtyTwoBitRadioButton = new System.Windows.Forms.RadioButton();
            this.FormatAddressesAsSixteenBitRadioButton = new System.Windows.Forms.RadioButton();
            this.FormatAddressesAsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginUpDown)).BeginInit();
            this.SeparateByteBitsByPanel.SuspendLayout();
            this.BytesPerRowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSetOrigin
            // 
            this.labelSetOrigin.AutoSize = true;
            this.labelSetOrigin.Location = new System.Drawing.Point(10, 15);
            this.labelSetOrigin.Name = "labelSetOrigin";
            this.labelSetOrigin.Size = new System.Drawing.Size(0, 25);
            this.labelSetOrigin.TabIndex = 0;
            // 
            // OriginUpDown
            // 
            this.OriginUpDown.Hexadecimal = true;
            this.OriginUpDown.Location = new System.Drawing.Point(435, 15);
            this.OriginUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.OriginUpDown.Name = "OriginUpDown";
            this.OriginUpDown.Size = new System.Drawing.Size(107, 31);
            this.OriginUpDown.TabIndex = 2;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(12, 211);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(112, 34);
            this.CopyButton.TabIndex = 6;
            this.CopyButton.Text = "&Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(425, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IncludeMemoryAddressCheckBox
            // 
            this.IncludeMemoryAddressCheckBox.AutoSize = true;
            this.IncludeMemoryAddressCheckBox.Checked = true;
            this.IncludeMemoryAddressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeMemoryAddressCheckBox.Location = new System.Drawing.Point(18, 14);
            this.IncludeMemoryAddressCheckBox.Name = "IncludeMemoryAddressCheckBox";
            this.IncludeMemoryAddressCheckBox.Size = new System.Drawing.Size(234, 29);
            this.IncludeMemoryAddressCheckBox.TabIndex = 0;
            this.IncludeMemoryAddressCheckBox.Text = "Include memory address";
            this.IncludeMemoryAddressCheckBox.UseVisualStyleBackColor = true;
            this.IncludeMemoryAddressCheckBox.CheckedChanged += new System.EventHandler(this.IncludeMemoryAddressCheckBox_CheckedChanged);
            // 
            // SetOriginLabel
            // 
            this.SetOriginLabel.AutoSize = true;
            this.SetOriginLabel.Location = new System.Drawing.Point(264, 18);
            this.SetOriginLabel.Name = "SetOriginLabel";
            this.SetOriginLabel.Size = new System.Drawing.Size(165, 25);
            this.SetOriginLabel.TabIndex = 1;
            this.SetOriginLabel.Text = "Set &Origin (ORG) to";
            // 
            // SeparateByteBitsByPanel
            // 
            this.SeparateByteBitsByPanel.Controls.Add(this.SeparateByteBitsByLabel);
            this.SeparateByteBitsByPanel.Controls.Add(this.SeparateByNothingRadioButton);
            this.SeparateByteBitsByPanel.Controls.Add(this.seperateByCommaRadioButton);
            this.SeparateByteBitsByPanel.Controls.Add(this.seperateBySpaceRadioButton);
            this.SeparateByteBitsByPanel.Location = new System.Drawing.Point(15, 144);
            this.SeparateByteBitsByPanel.Name = "SeparateByteBitsByPanel";
            this.SeparateByteBitsByPanel.Size = new System.Drawing.Size(527, 44);
            this.SeparateByteBitsByPanel.TabIndex = 5;
            // 
            // SeparateByteBitsByLabel
            // 
            this.SeparateByteBitsByLabel.AutoSize = true;
            this.SeparateByteBitsByLabel.Location = new System.Drawing.Point(8, 8);
            this.SeparateByteBitsByLabel.Name = "SeparateByteBitsByLabel";
            this.SeparateByteBitsByLabel.Size = new System.Drawing.Size(184, 25);
            this.SeparateByteBitsByLabel.TabIndex = 0;
            this.SeparateByteBitsByLabel.Text = "Separate byte bits by:";
            // 
            // SeparateByNothingRadioButton
            // 
            this.SeparateByNothingRadioButton.AutoSize = true;
            this.SeparateByNothingRadioButton.Location = new System.Drawing.Point(420, 8);
            this.SeparateByNothingRadioButton.Name = "SeparateByNothingRadioButton";
            this.SeparateByNothingRadioButton.Size = new System.Drawing.Size(102, 29);
            this.SeparateByNothingRadioButton.TabIndex = 3;
            this.SeparateByNothingRadioButton.Text = "Nothing";
            this.SeparateByNothingRadioButton.UseVisualStyleBackColor = true;
            this.SeparateByNothingRadioButton.CheckedChanged += new System.EventHandler(this.SeparateByNothingRadioButton_CheckedChanged);
            // 
            // seperateByCommaRadioButton
            // 
            this.seperateByCommaRadioButton.AutoSize = true;
            this.seperateByCommaRadioButton.Location = new System.Drawing.Point(304, 8);
            this.seperateByCommaRadioButton.Name = "seperateByCommaRadioButton";
            this.seperateByCommaRadioButton.Size = new System.Drawing.Size(100, 29);
            this.seperateByCommaRadioButton.TabIndex = 2;
            this.seperateByCommaRadioButton.Text = "Comma";
            this.seperateByCommaRadioButton.UseVisualStyleBackColor = true;
            this.seperateByCommaRadioButton.CheckedChanged += new System.EventHandler(this.SeparateByCommaRadioButton_CheckedChanged);
            // 
            // seperateBySpaceRadioButton
            // 
            this.seperateBySpaceRadioButton.AutoSize = true;
            this.seperateBySpaceRadioButton.Checked = true;
            this.seperateBySpaceRadioButton.Location = new System.Drawing.Point(208, 8);
            this.seperateBySpaceRadioButton.Name = "seperateBySpaceRadioButton";
            this.seperateBySpaceRadioButton.Size = new System.Drawing.Size(84, 29);
            this.seperateBySpaceRadioButton.TabIndex = 1;
            this.seperateBySpaceRadioButton.TabStop = true;
            this.seperateBySpaceRadioButton.Text = "Space";
            this.seperateBySpaceRadioButton.UseVisualStyleBackColor = true;
            this.seperateBySpaceRadioButton.CheckedChanged += new System.EventHandler(this.SeparateBySpaceRadioButton_CheckedChanged);
            // 
            // BytesPerRowPanel
            // 
            this.BytesPerRowPanel.Controls.Add(this.BytesPerRowRadioButton);
            this.BytesPerRowPanel.Controls.Add(this.OneBytePerRowRadioButton);
            this.BytesPerRowPanel.Controls.Add(this.BytesPerRowLabel);
            this.BytesPerRowPanel.Location = new System.Drawing.Point(18, 98);
            this.BytesPerRowPanel.Name = "BytesPerRowPanel";
            this.BytesPerRowPanel.Size = new System.Drawing.Size(524, 40);
            this.BytesPerRowPanel.TabIndex = 4;
            // 
            // BytesPerRowRadioButton
            // 
            this.BytesPerRowRadioButton.AutoSize = true;
            this.BytesPerRowRadioButton.Checked = true;
            this.BytesPerRowRadioButton.Location = new System.Drawing.Point(301, 6);
            this.BytesPerRowRadioButton.Name = "BytesPerRowRadioButton";
            this.BytesPerRowRadioButton.Size = new System.Drawing.Size(182, 29);
            this.BytesPerRowRadioButton.TabIndex = 2;
            this.BytesPerRowRadioButton.TabStop = true;
            this.BytesPerRowRadioButton.Text = "999 Bytes Per Row";
            this.BytesPerRowRadioButton.UseVisualStyleBackColor = true;
            this.BytesPerRowRadioButton.CheckedChanged += new System.EventHandler(this.BytesPerRowRadioButton_CheckedChanged);
            // 
            // OneBytePerRowRadioButton
            // 
            this.OneBytePerRowRadioButton.AutoSize = true;
            this.OneBytePerRowRadioButton.Location = new System.Drawing.Point(205, 6);
            this.OneBytePerRowRadioButton.Name = "OneBytePerRowRadioButton";
            this.OneBytePerRowRadioButton.Size = new System.Drawing.Size(70, 29);
            this.OneBytePerRowRadioButton.TabIndex = 1;
            this.OneBytePerRowRadioButton.Text = "One";
            this.OneBytePerRowRadioButton.UseVisualStyleBackColor = true;
            this.OneBytePerRowRadioButton.CheckedChanged += new System.EventHandler(this.OneBytePerRowRadioButton_CheckedChanged);
            // 
            // BytesPerRowLabel
            // 
            this.BytesPerRowLabel.AutoSize = true;
            this.BytesPerRowLabel.Location = new System.Drawing.Point(5, 8);
            this.BytesPerRowLabel.Name = "BytesPerRowLabel";
            this.BytesPerRowLabel.Size = new System.Drawing.Size(126, 25);
            this.BytesPerRowLabel.TabIndex = 0;
            this.BytesPerRowLabel.Text = "Bytes Per Row:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FormatAddressesAsThirtyTwoBitRadioButton);
            this.panel1.Controls.Add(this.FormatAddressesAsSixteenBitRadioButton);
            this.panel1.Controls.Add(this.FormatAddressesAsLabel);
            this.panel1.Location = new System.Drawing.Point(18, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 40);
            this.panel1.TabIndex = 3;
            // 
            // FormatAddressesAsThirtyTwoBitRadioButton
            // 
            this.FormatAddressesAsThirtyTwoBitRadioButton.AutoSize = true;
            this.FormatAddressesAsThirtyTwoBitRadioButton.Location = new System.Drawing.Point(301, 6);
            this.FormatAddressesAsThirtyTwoBitRadioButton.Name = "FormatAddressesAsThirtyTwoBitRadioButton";
            this.FormatAddressesAsThirtyTwoBitRadioButton.Size = new System.Drawing.Size(85, 29);
            this.FormatAddressesAsThirtyTwoBitRadioButton.TabIndex = 2;
            this.FormatAddressesAsThirtyTwoBitRadioButton.Text = "32-bit";
            this.FormatAddressesAsThirtyTwoBitRadioButton.UseVisualStyleBackColor = true;
            this.FormatAddressesAsThirtyTwoBitRadioButton.CheckedChanged += new System.EventHandler(this.FormatAddressesAsThirtyTwoBitRadioButton_CheckedChanged);
            // 
            // FormatAddressesAsSixteenBitRadioButton
            // 
            this.FormatAddressesAsSixteenBitRadioButton.AutoSize = true;
            this.FormatAddressesAsSixteenBitRadioButton.Checked = true;
            this.FormatAddressesAsSixteenBitRadioButton.Location = new System.Drawing.Point(205, 6);
            this.FormatAddressesAsSixteenBitRadioButton.Name = "FormatAddressesAsSixteenBitRadioButton";
            this.FormatAddressesAsSixteenBitRadioButton.Size = new System.Drawing.Size(84, 29);
            this.FormatAddressesAsSixteenBitRadioButton.TabIndex = 1;
            this.FormatAddressesAsSixteenBitRadioButton.TabStop = true;
            this.FormatAddressesAsSixteenBitRadioButton.Text = "16-Bit";
            this.FormatAddressesAsSixteenBitRadioButton.UseVisualStyleBackColor = true;
            this.FormatAddressesAsSixteenBitRadioButton.CheckedChanged += new System.EventHandler(this.FormatAddressesAsSixteenBitRadioButton_CheckedChanged);
            // 
            // FormatAddressesAsLabel
            // 
            this.FormatAddressesAsLabel.AutoSize = true;
            this.FormatAddressesAsLabel.Location = new System.Drawing.Point(5, 8);
            this.FormatAddressesAsLabel.Name = "FormatAddressesAsLabel";
            this.FormatAddressesAsLabel.Size = new System.Drawing.Size(182, 25);
            this.FormatAddressesAsLabel.TabIndex = 0;
            this.FormatAddressesAsLabel.Text = "Format Addresses as:";
            // 
            // CopyAsBinaryToClipboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 254);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BytesPerRowPanel);
            this.Controls.Add(this.SeparateByteBitsByPanel);
            this.Controls.Add(this.SetOriginLabel);
            this.Controls.Add(this.IncludeMemoryAddressCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.OriginUpDown);
            this.Controls.Add(this.labelSetOrigin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CopyAsBinaryToClipboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Copy As Binary To Clipboard";
            this.Load += new System.EventHandler(this.CopyAsBinaryToClipboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginUpDown)).EndInit();
            this.SeparateByteBitsByPanel.ResumeLayout(false);
            this.SeparateByteBitsByPanel.PerformLayout();
            this.BytesPerRowPanel.ResumeLayout(false);
            this.BytesPerRowPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSetOrigin;
        private NumericUpDown OriginUpDown;
        private Button CopyButton;
        private Button button1;
        private CheckBox IncludeMemoryAddressCheckBox;
        private Label SetOriginLabel;
        private Panel SeparateByteBitsByPanel;
        private Label SeparateByteBitsByLabel;
        private RadioButton SeparateByNothingRadioButton;
        private RadioButton seperateByCommaRadioButton;
        private RadioButton seperateBySpaceRadioButton;
        private Panel BytesPerRowPanel;
        private RadioButton BytesPerRowRadioButton;
        private RadioButton OneBytePerRowRadioButton;
        private Label BytesPerRowLabel;
        private Panel panel1;
        private RadioButton FormatAddressesAsThirtyTwoBitRadioButton;
        private RadioButton FormatAddressesAsSixteenBitRadioButton;
        private Label FormatAddressesAsLabel;
    }
}