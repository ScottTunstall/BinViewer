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
            labelSetOrigin = new Label();
            OriginUpDown = new NumericUpDown();
            CopyButton = new Button();
            button1 = new Button();
            IncludeMemoryAddressCheckBox = new CheckBox();
            SetOriginLabel = new Label();
            SeparateByteBitsByPanel = new Panel();
            SeparateByteBitsByLabel = new Label();
            SeparateByNothingRadioButton = new RadioButton();
            seperateByCommaRadioButton = new RadioButton();
            seperateBySpaceRadioButton = new RadioButton();
            BytesPerRowPanel = new Panel();
            BytesPerRowRadioButton = new RadioButton();
            OneBytePerRowRadioButton = new RadioButton();
            BytesPerRowLabel = new Label();
            MemoryAddressPanel = new Panel();
            FormatAddressesAsThirtyTwoBitRadioButton = new RadioButton();
            FormatAddressesAsSixteenBitRadioButton = new RadioButton();
            FormatAddressesAsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OriginUpDown).BeginInit();
            SeparateByteBitsByPanel.SuspendLayout();
            BytesPerRowPanel.SuspendLayout();
            MemoryAddressPanel.SuspendLayout();
            SuspendLayout();
            // 
            // labelSetOrigin
            // 
            labelSetOrigin.AutoSize = true;
            labelSetOrigin.Location = new Point(7, 9);
            labelSetOrigin.Margin = new Padding(2, 0, 2, 0);
            labelSetOrigin.Name = "labelSetOrigin";
            labelSetOrigin.Size = new Size(0, 15);
            labelSetOrigin.TabIndex = 0;
            // 
            // OriginUpDown
            // 
            OriginUpDown.Hexadecimal = true;
            OriginUpDown.Location = new Point(147, 45);
            OriginUpDown.Margin = new Padding(2);
            OriginUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            OriginUpDown.Name = "OriginUpDown";
            OriginUpDown.Size = new Size(75, 23);
            OriginUpDown.TabIndex = 6;
            // 
            // CopyButton
            // 
            CopyButton.DialogResult = DialogResult.OK;
            CopyButton.Location = new Point(12, 143);
            CopyButton.Margin = new Padding(2);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(78, 27);
            CopyButton.TabIndex = 14;
            CopyButton.Text = "&Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(300, 143);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 27);
            button1.TabIndex = 15;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // IncludeMemoryAddressCheckBox
            // 
            IncludeMemoryAddressCheckBox.AutoSize = true;
            IncludeMemoryAddressCheckBox.Checked = true;
            IncludeMemoryAddressCheckBox.CheckState = CheckState.Checked;
            IncludeMemoryAddressCheckBox.Location = new Point(6, 2);
            IncludeMemoryAddressCheckBox.Margin = new Padding(2);
            IncludeMemoryAddressCheckBox.Name = "IncludeMemoryAddressCheckBox";
            IncludeMemoryAddressCheckBox.Size = new Size(158, 19);
            IncludeMemoryAddressCheckBox.TabIndex = 1;
            IncludeMemoryAddressCheckBox.Text = "Include memory &Address";
            IncludeMemoryAddressCheckBox.UseVisualStyleBackColor = true;
            IncludeMemoryAddressCheckBox.CheckedChanged += IncludeMemoryAddressCheckBox_CheckedChanged;
            // 
            // SetOriginLabel
            // 
            SetOriginLabel.AutoSize = true;
            SetOriginLabel.Location = new Point(13, 47);
            SetOriginLabel.Margin = new Padding(2, 0, 2, 0);
            SetOriginLabel.Name = "SetOriginLabel";
            SetOriginLabel.Size = new Size(111, 15);
            SetOriginLabel.TabIndex = 5;
            SetOriginLabel.Text = "Set &Origin (ORG) to:";
            // 
            // SeparateByteBitsByPanel
            // 
            SeparateByteBitsByPanel.Controls.Add(SeparateByteBitsByLabel);
            SeparateByteBitsByPanel.Controls.Add(SeparateByNothingRadioButton);
            SeparateByteBitsByPanel.Controls.Add(seperateByCommaRadioButton);
            SeparateByteBitsByPanel.Controls.Add(seperateBySpaceRadioButton);
            SeparateByteBitsByPanel.Location = new Point(12, 113);
            SeparateByteBitsByPanel.Margin = new Padding(2);
            SeparateByteBitsByPanel.Name = "SeparateByteBitsByPanel";
            SeparateByteBitsByPanel.Size = new Size(366, 26);
            SeparateByteBitsByPanel.TabIndex = 5;
            // 
            // SeparateByteBitsByLabel
            // 
            SeparateByteBitsByLabel.AutoSize = true;
            SeparateByteBitsByLabel.Location = new Point(6, 5);
            SeparateByteBitsByLabel.Margin = new Padding(2, 0, 2, 0);
            SeparateByteBitsByLabel.Name = "SeparateByteBitsByLabel";
            SeparateByteBitsByLabel.Size = new Size(119, 15);
            SeparateByteBitsByLabel.TabIndex = 10;
            SeparateByteBitsByLabel.Text = "Separate byte bits by:";
            // 
            // SeparateByNothingRadioButton
            // 
            SeparateByNothingRadioButton.AutoSize = true;
            SeparateByNothingRadioButton.Location = new Point(279, 3);
            SeparateByNothingRadioButton.Margin = new Padding(2);
            SeparateByNothingRadioButton.Name = "SeparateByNothingRadioButton";
            SeparateByNothingRadioButton.Size = new Size(69, 19);
            SeparateByNothingRadioButton.TabIndex = 13;
            SeparateByNothingRadioButton.Text = "Nothing";
            SeparateByNothingRadioButton.UseVisualStyleBackColor = true;
            // 
            // seperateByCommaRadioButton
            // 
            seperateByCommaRadioButton.AutoSize = true;
            seperateByCommaRadioButton.Checked = true;
            seperateByCommaRadioButton.Location = new Point(147, 2);
            seperateByCommaRadioButton.Margin = new Padding(2);
            seperateByCommaRadioButton.Name = "seperateByCommaRadioButton";
            seperateByCommaRadioButton.Size = new Size(68, 19);
            seperateByCommaRadioButton.TabIndex = 11;
            seperateByCommaRadioButton.TabStop = true;
            seperateByCommaRadioButton.Text = "Comma";
            seperateByCommaRadioButton.UseVisualStyleBackColor = true;
            // 
            // seperateBySpaceRadioButton
            // 
            seperateBySpaceRadioButton.AutoSize = true;
            seperateBySpaceRadioButton.Location = new Point(216, 2);
            seperateBySpaceRadioButton.Margin = new Padding(2);
            seperateBySpaceRadioButton.Name = "seperateBySpaceRadioButton";
            seperateBySpaceRadioButton.Size = new Size(56, 19);
            seperateBySpaceRadioButton.TabIndex = 12;
            seperateBySpaceRadioButton.Text = "Space";
            seperateBySpaceRadioButton.UseVisualStyleBackColor = true;
            // 
            // BytesPerRowPanel
            // 
            BytesPerRowPanel.Controls.Add(BytesPerRowRadioButton);
            BytesPerRowPanel.Controls.Add(OneBytePerRowRadioButton);
            BytesPerRowPanel.Controls.Add(BytesPerRowLabel);
            BytesPerRowPanel.Location = new Point(12, 85);
            BytesPerRowPanel.Margin = new Padding(2);
            BytesPerRowPanel.Name = "BytesPerRowPanel";
            BytesPerRowPanel.Size = new Size(367, 24);
            BytesPerRowPanel.TabIndex = 4;
            // 
            // BytesPerRowRadioButton
            // 
            BytesPerRowRadioButton.AutoSize = true;
            BytesPerRowRadioButton.Checked = true;
            BytesPerRowRadioButton.Location = new Point(216, 4);
            BytesPerRowRadioButton.Margin = new Padding(2);
            BytesPerRowRadioButton.Name = "BytesPerRowRadioButton";
            BytesPerRowRadioButton.Size = new Size(120, 19);
            BytesPerRowRadioButton.TabIndex = 9;
            BytesPerRowRadioButton.TabStop = true;
            BytesPerRowRadioButton.Text = "999 Bytes Per Row";
            BytesPerRowRadioButton.UseVisualStyleBackColor = true;
            // 
            // OneBytePerRowRadioButton
            // 
            OneBytePerRowRadioButton.AutoSize = true;
            OneBytePerRowRadioButton.Location = new Point(147, 1);
            OneBytePerRowRadioButton.Margin = new Padding(2);
            OneBytePerRowRadioButton.Name = "OneBytePerRowRadioButton";
            OneBytePerRowRadioButton.Size = new Size(47, 19);
            OneBytePerRowRadioButton.TabIndex = 8;
            OneBytePerRowRadioButton.Text = "One";
            OneBytePerRowRadioButton.UseVisualStyleBackColor = true;
            // 
            // BytesPerRowLabel
            // 
            BytesPerRowLabel.AutoSize = true;
            BytesPerRowLabel.Location = new Point(4, 5);
            BytesPerRowLabel.Margin = new Padding(2, 0, 2, 0);
            BytesPerRowLabel.Name = "BytesPerRowLabel";
            BytesPerRowLabel.Size = new Size(84, 15);
            BytesPerRowLabel.TabIndex = 7;
            BytesPerRowLabel.Text = "Bytes Per Row:";
            // 
            // MemoryAddressPanel
            // 
            MemoryAddressPanel.Controls.Add(FormatAddressesAsThirtyTwoBitRadioButton);
            MemoryAddressPanel.Controls.Add(FormatAddressesAsSixteenBitRadioButton);
            MemoryAddressPanel.Controls.Add(FormatAddressesAsLabel);
            MemoryAddressPanel.Controls.Add(SetOriginLabel);
            MemoryAddressPanel.Controls.Add(IncludeMemoryAddressCheckBox);
            MemoryAddressPanel.Controls.Add(OriginUpDown);
            MemoryAddressPanel.Location = new Point(12, 4);
            MemoryAddressPanel.Margin = new Padding(2);
            MemoryAddressPanel.Name = "MemoryAddressPanel";
            MemoryAddressPanel.Size = new Size(369, 77);
            MemoryAddressPanel.TabIndex = 0;
            // 
            // FormatAddressesAsThirtyTwoBitRadioButton
            // 
            FormatAddressesAsThirtyTwoBitRadioButton.AutoSize = true;
            FormatAddressesAsThirtyTwoBitRadioButton.Location = new Point(216, 23);
            FormatAddressesAsThirtyTwoBitRadioButton.Margin = new Padding(2);
            FormatAddressesAsThirtyTwoBitRadioButton.Name = "FormatAddressesAsThirtyTwoBitRadioButton";
            FormatAddressesAsThirtyTwoBitRadioButton.Size = new Size(56, 19);
            FormatAddressesAsThirtyTwoBitRadioButton.TabIndex = 4;
            FormatAddressesAsThirtyTwoBitRadioButton.Text = "32-bit";
            FormatAddressesAsThirtyTwoBitRadioButton.UseVisualStyleBackColor = true;
            FormatAddressesAsThirtyTwoBitRadioButton.CheckedChanged += FormatAddressesAsThirtyTwoBitRadioButton_CheckedChanged;
            // 
            // FormatAddressesAsSixteenBitRadioButton
            // 
            FormatAddressesAsSixteenBitRadioButton.AutoSize = true;
            FormatAddressesAsSixteenBitRadioButton.Checked = true;
            FormatAddressesAsSixteenBitRadioButton.Location = new Point(147, 23);
            FormatAddressesAsSixteenBitRadioButton.Margin = new Padding(2);
            FormatAddressesAsSixteenBitRadioButton.Name = "FormatAddressesAsSixteenBitRadioButton";
            FormatAddressesAsSixteenBitRadioButton.Size = new Size(56, 19);
            FormatAddressesAsSixteenBitRadioButton.TabIndex = 3;
            FormatAddressesAsSixteenBitRadioButton.TabStop = true;
            FormatAddressesAsSixteenBitRadioButton.Text = "16-Bit";
            FormatAddressesAsSixteenBitRadioButton.UseVisualStyleBackColor = true;
            FormatAddressesAsSixteenBitRadioButton.CheckedChanged += FormatAddressesAsSixteenBitRadioButton_CheckedChanged;
            // 
            // FormatAddressesAsLabel
            // 
            FormatAddressesAsLabel.AutoSize = true;
            FormatAddressesAsLabel.Location = new Point(6, 23);
            FormatAddressesAsLabel.Margin = new Padding(2, 0, 2, 0);
            FormatAddressesAsLabel.Name = "FormatAddressesAsLabel";
            FormatAddressesAsLabel.Size = new Size(118, 15);
            FormatAddressesAsLabel.TabIndex = 2;
            FormatAddressesAsLabel.Text = "&Format Addresses as:";
            // 
            // CopyAsBinaryToClipboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 174);
            Controls.Add(MemoryAddressPanel);
            Controls.Add(BytesPerRowPanel);
            Controls.Add(SeparateByteBitsByPanel);
            Controls.Add(button1);
            Controls.Add(CopyButton);
            Controls.Add(labelSetOrigin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "CopyAsBinaryToClipboardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Copy As Binary To Clipboard";
            Load += CopyAsBinaryToClipboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)OriginUpDown).EndInit();
            SeparateByteBitsByPanel.ResumeLayout(false);
            SeparateByteBitsByPanel.PerformLayout();
            BytesPerRowPanel.ResumeLayout(false);
            BytesPerRowPanel.PerformLayout();
            MemoryAddressPanel.ResumeLayout(false);
            MemoryAddressPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel MemoryAddressPanel;
        private RadioButton FormatAddressesAsThirtyTwoBitRadioButton;
        private RadioButton FormatAddressesAsSixteenBitRadioButton;
        private Label FormatAddressesAsLabel;
    }
}