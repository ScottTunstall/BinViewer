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
            OriginTextBox = new TextBox();
            AddressSize32BitRadioButton = new RadioButton();
            AddressSize16BitRadioButton = new RadioButton();
            AddressSizeLabel = new Label();
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
            // CopyButton
            // 
            CopyButton.DialogResult = DialogResult.OK;
            CopyButton.Location = new Point(12, 143);
            CopyButton.Margin = new Padding(2);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(78, 27);
            CopyButton.TabIndex = 15;
            CopyButton.Text = "&Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(294, 143);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 27);
            button1.TabIndex = 16;
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
            IncludeMemoryAddressCheckBox.TabIndex = 0;
            IncludeMemoryAddressCheckBox.Text = "Include memory &Address";
            IncludeMemoryAddressCheckBox.UseVisualStyleBackColor = true;
            IncludeMemoryAddressCheckBox.CheckedChanged += IncludeMemoryAddressCheckBox_CheckedChanged;
            // 
            // SetOriginLabel
            // 
            SetOriginLabel.AutoSize = true;
            SetOriginLabel.Location = new Point(2, 47);
            SetOriginLabel.Margin = new Padding(2, 0, 2, 0);
            SetOriginLabel.Name = "SetOriginLabel";
            SetOriginLabel.Size = new Size(141, 15);
            SetOriginLabel.TabIndex = 4;
            SetOriginLabel.Text = "Set &Origin (ORG) to (hex):";
            // 
            // SeparateByteBitsByPanel
            // 
            SeparateByteBitsByPanel.Controls.Add(SeparateByteBitsByLabel);
            SeparateByteBitsByPanel.Controls.Add(SeparateByNothingRadioButton);
            SeparateByteBitsByPanel.Controls.Add(seperateByCommaRadioButton);
            SeparateByteBitsByPanel.Controls.Add(seperateBySpaceRadioButton);
            SeparateByteBitsByPanel.Location = new Point(11, 75);
            SeparateByteBitsByPanel.Margin = new Padding(2);
            SeparateByteBitsByPanel.Name = "SeparateByteBitsByPanel";
            SeparateByteBitsByPanel.Size = new Size(360, 26);
            SeparateByteBitsByPanel.TabIndex = 6;
            // 
            // SeparateByteBitsByLabel
            // 
            SeparateByteBitsByLabel.AutoSize = true;
            SeparateByteBitsByLabel.Location = new Point(6, 7);
            SeparateByteBitsByLabel.Margin = new Padding(2, 0, 2, 0);
            SeparateByteBitsByLabel.Name = "SeparateByteBitsByLabel";
            SeparateByteBitsByLabel.Size = new Size(139, 15);
            SeparateByteBitsByLabel.TabIndex = 7;
            SeparateByteBitsByLabel.Text = "Separate binary digits by:";
            // 
            // SeparateByNothingRadioButton
            // 
            SeparateByNothingRadioButton.AutoSize = true;
            SeparateByNothingRadioButton.Location = new Point(276, 5);
            SeparateByNothingRadioButton.Margin = new Padding(2);
            SeparateByNothingRadioButton.Name = "SeparateByNothingRadioButton";
            SeparateByNothingRadioButton.Size = new Size(69, 19);
            SeparateByNothingRadioButton.TabIndex = 10;
            SeparateByNothingRadioButton.Text = "Nothing";
            SeparateByNothingRadioButton.UseVisualStyleBackColor = true;
            // 
            // seperateByCommaRadioButton
            // 
            seperateByCommaRadioButton.AutoSize = true;
            seperateByCommaRadioButton.Checked = true;
            seperateByCommaRadioButton.Location = new Point(147, 5);
            seperateByCommaRadioButton.Margin = new Padding(2);
            seperateByCommaRadioButton.Name = "seperateByCommaRadioButton";
            seperateByCommaRadioButton.Size = new Size(68, 19);
            seperateByCommaRadioButton.TabIndex = 8;
            seperateByCommaRadioButton.TabStop = true;
            seperateByCommaRadioButton.Text = "Comma";
            seperateByCommaRadioButton.UseVisualStyleBackColor = true;
            // 
            // seperateBySpaceRadioButton
            // 
            seperateBySpaceRadioButton.AutoSize = true;
            seperateBySpaceRadioButton.Location = new Point(216, 5);
            seperateBySpaceRadioButton.Margin = new Padding(2);
            seperateBySpaceRadioButton.Name = "seperateBySpaceRadioButton";
            seperateBySpaceRadioButton.Size = new Size(56, 19);
            seperateBySpaceRadioButton.TabIndex = 9;
            seperateBySpaceRadioButton.Text = "Space";
            seperateBySpaceRadioButton.UseVisualStyleBackColor = true;
            // 
            // BytesPerRowPanel
            // 
            BytesPerRowPanel.Controls.Add(BytesPerRowRadioButton);
            BytesPerRowPanel.Controls.Add(OneBytePerRowRadioButton);
            BytesPerRowPanel.Controls.Add(BytesPerRowLabel);
            BytesPerRowPanel.Location = new Point(12, 105);
            BytesPerRowPanel.Margin = new Padding(2);
            BytesPerRowPanel.Name = "BytesPerRowPanel";
            BytesPerRowPanel.Size = new Size(360, 24);
            BytesPerRowPanel.TabIndex = 11;
            // 
            // BytesPerRowRadioButton
            // 
            BytesPerRowRadioButton.AutoSize = true;
            BytesPerRowRadioButton.Location = new Point(216, 2);
            BytesPerRowRadioButton.Margin = new Padding(2);
            BytesPerRowRadioButton.Name = "BytesPerRowRadioButton";
            BytesPerRowRadioButton.Size = new Size(120, 19);
            BytesPerRowRadioButton.TabIndex = 14;
            BytesPerRowRadioButton.Text = "999 Bytes Per Row";
            BytesPerRowRadioButton.UseVisualStyleBackColor = true;
            // 
            // OneBytePerRowRadioButton
            // 
            OneBytePerRowRadioButton.AutoSize = true;
            OneBytePerRowRadioButton.Checked = true;
            OneBytePerRowRadioButton.Location = new Point(147, 1);
            OneBytePerRowRadioButton.Margin = new Padding(2);
            OneBytePerRowRadioButton.Name = "OneBytePerRowRadioButton";
            OneBytePerRowRadioButton.Size = new Size(47, 19);
            OneBytePerRowRadioButton.TabIndex = 13;
            OneBytePerRowRadioButton.TabStop = true;
            OneBytePerRowRadioButton.Text = "One";
            OneBytePerRowRadioButton.UseVisualStyleBackColor = true;
            // 
            // BytesPerRowLabel
            // 
            BytesPerRowLabel.AutoSize = true;
            BytesPerRowLabel.Location = new Point(57, 5);
            BytesPerRowLabel.Margin = new Padding(2, 0, 2, 0);
            BytesPerRowLabel.Name = "BytesPerRowLabel";
            BytesPerRowLabel.Size = new Size(84, 15);
            BytesPerRowLabel.TabIndex = 12;
            BytesPerRowLabel.Text = "Bytes Per Row:";
            // 
            // MemoryAddressPanel
            // 
            MemoryAddressPanel.Controls.Add(OriginTextBox);
            MemoryAddressPanel.Controls.Add(AddressSize32BitRadioButton);
            MemoryAddressPanel.Controls.Add(AddressSize16BitRadioButton);
            MemoryAddressPanel.Controls.Add(AddressSizeLabel);
            MemoryAddressPanel.Controls.Add(SetOriginLabel);
            MemoryAddressPanel.Controls.Add(IncludeMemoryAddressCheckBox);
            MemoryAddressPanel.Location = new Point(12, 4);
            MemoryAddressPanel.Margin = new Padding(2);
            MemoryAddressPanel.Name = "MemoryAddressPanel";
            MemoryAddressPanel.Size = new Size(360, 68);
            MemoryAddressPanel.TabIndex = 0;
            // 
            // OriginTextBox
            // 
            OriginTextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OriginTextBox.Location = new Point(147, 44);
            OriginTextBox.MaxLength = 8;
            OriginTextBox.Name = "OriginTextBox";
            OriginTextBox.Size = new Size(68, 22);
            OriginTextBox.TabIndex = 5;
            OriginTextBox.Text = "0";
            OriginTextBox.KeyPress += OriginTextBox_KeyPress;
            // 
            // AddressSize32BitRadioButton
            // 
            AddressSize32BitRadioButton.AutoSize = true;
            AddressSize32BitRadioButton.Location = new Point(216, 23);
            AddressSize32BitRadioButton.Margin = new Padding(2);
            AddressSize32BitRadioButton.Name = "AddressSize32BitRadioButton";
            AddressSize32BitRadioButton.Size = new Size(56, 19);
            AddressSize32BitRadioButton.TabIndex = 3;
            AddressSize32BitRadioButton.Text = "32-bit";
            AddressSize32BitRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddressSize16BitRadioButton
            // 
            AddressSize16BitRadioButton.AutoSize = true;
            AddressSize16BitRadioButton.Checked = true;
            AddressSize16BitRadioButton.Location = new Point(147, 23);
            AddressSize16BitRadioButton.Margin = new Padding(2);
            AddressSize16BitRadioButton.Name = "AddressSize16BitRadioButton";
            AddressSize16BitRadioButton.Size = new Size(56, 19);
            AddressSize16BitRadioButton.TabIndex = 2;
            AddressSize16BitRadioButton.TabStop = true;
            AddressSize16BitRadioButton.Text = "16-Bit";
            AddressSize16BitRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddressSizeLabel
            // 
            AddressSizeLabel.AutoSize = true;
            AddressSizeLabel.Location = new Point(66, 23);
            AddressSizeLabel.Margin = new Padding(2, 0, 2, 0);
            AddressSizeLabel.Name = "AddressSizeLabel";
            AddressSizeLabel.Size = new Size(75, 15);
            AddressSizeLabel.TabIndex = 1;
            AddressSizeLabel.Text = "&Address Size:";
            // 
            // CopyAsBinaryToClipboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 174);
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
        private RadioButton AddressSize32BitRadioButton;
        private RadioButton AddressSize16BitRadioButton;
        private Label AddressSizeLabel;
        private TextBox OriginTextBox;
    }
}