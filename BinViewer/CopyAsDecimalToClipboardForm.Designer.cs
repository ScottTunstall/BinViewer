namespace BinViewer
{
    partial class CopyAsDecimalToClipboardForm
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
            OriginTextBox = new TextBox();
            AddressSize32BitRadioButton = new RadioButton();
            AddressSizeLabel = new Label();
            MemoryAddressPanel = new Panel();
            AddressSize16BitRadioButton = new RadioButton();
            SetOriginLabel = new Label();
            IncludeMemoryAddressCheckBox = new CheckBox();
            FormatBytesAsLabel = new Label();
            FormatBytesAsDecimalRadioButton = new RadioButton();
            FormatBytesAsHexRadioButton = new RadioButton();
            SeparateByteBitsByPanel = new Panel();
            button1 = new Button();
            CopyButton = new Button();
            labelSetOrigin = new Label();
            panel1 = new Panel();
            HexFormatAmpersandRadioButton = new RadioButton();
            HexFormatSpecifierLabel = new Label();
            HexFormatCStyleRadioButton = new RadioButton();
            HexFormatDollarSymbolRadioButton = new RadioButton();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            MemoryAddressPanel.SuspendLayout();
            SeparateByteBitsByPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // MemoryAddressPanel
            // 
            MemoryAddressPanel.Controls.Add(OriginTextBox);
            MemoryAddressPanel.Controls.Add(AddressSize32BitRadioButton);
            MemoryAddressPanel.Controls.Add(AddressSize16BitRadioButton);
            MemoryAddressPanel.Controls.Add(AddressSizeLabel);
            MemoryAddressPanel.Controls.Add(SetOriginLabel);
            MemoryAddressPanel.Controls.Add(IncludeMemoryAddressCheckBox);
            MemoryAddressPanel.Location = new Point(13, 5);
            MemoryAddressPanel.Margin = new Padding(2);
            MemoryAddressPanel.Name = "MemoryAddressPanel";
            MemoryAddressPanel.Size = new Size(360, 68);
            MemoryAddressPanel.TabIndex = 0;
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
            // 
            // FormatBytesAsLabel
            // 
            FormatBytesAsLabel.AutoSize = true;
            FormatBytesAsLabel.Location = new Point(49, 5);
            FormatBytesAsLabel.Margin = new Padding(2, 0, 2, 0);
            FormatBytesAsLabel.Name = "FormatBytesAsLabel";
            FormatBytesAsLabel.Size = new Size(93, 15);
            FormatBytesAsLabel.TabIndex = 0;
            FormatBytesAsLabel.Text = "Format bytes as:";
            // 
            // FormatBytesAsDecimalRadioButton
            // 
            FormatBytesAsDecimalRadioButton.AutoSize = true;
            FormatBytesAsDecimalRadioButton.Checked = true;
            FormatBytesAsDecimalRadioButton.Location = new Point(147, 5);
            FormatBytesAsDecimalRadioButton.Margin = new Padding(2);
            FormatBytesAsDecimalRadioButton.Name = "FormatBytesAsDecimalRadioButton";
            FormatBytesAsDecimalRadioButton.Size = new Size(68, 19);
            FormatBytesAsDecimalRadioButton.TabIndex = 1;
            FormatBytesAsDecimalRadioButton.TabStop = true;
            FormatBytesAsDecimalRadioButton.Text = "Decimal";
            FormatBytesAsDecimalRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormatBytesAsHexRadioButton
            // 
            FormatBytesAsHexRadioButton.AutoSize = true;
            FormatBytesAsHexRadioButton.Location = new Point(216, 5);
            FormatBytesAsHexRadioButton.Margin = new Padding(2);
            FormatBytesAsHexRadioButton.Name = "FormatBytesAsHexRadioButton";
            FormatBytesAsHexRadioButton.Size = new Size(46, 19);
            FormatBytesAsHexRadioButton.TabIndex = 2;
            FormatBytesAsHexRadioButton.Text = "Hex";
            FormatBytesAsHexRadioButton.UseVisualStyleBackColor = true;
            // 
            // SeparateByteBitsByPanel
            // 
            SeparateByteBitsByPanel.Controls.Add(FormatBytesAsLabel);
            SeparateByteBitsByPanel.Controls.Add(FormatBytesAsDecimalRadioButton);
            SeparateByteBitsByPanel.Controls.Add(FormatBytesAsHexRadioButton);
            SeparateByteBitsByPanel.Location = new Point(13, 75);
            SeparateByteBitsByPanel.Margin = new Padding(2);
            SeparateByteBitsByPanel.Name = "SeparateByteBitsByPanel";
            SeparateByteBitsByPanel.Size = new Size(360, 26);
            SeparateByteBitsByPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(295, 193);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 27);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            CopyButton.DialogResult = DialogResult.OK;
            CopyButton.Location = new Point(11, 193);
            CopyButton.Margin = new Padding(2);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(78, 27);
            CopyButton.TabIndex = 4;
            CopyButton.Text = "&Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // labelSetOrigin
            // 
            labelSetOrigin.AutoSize = true;
            labelSetOrigin.Location = new Point(6, 16);
            labelSetOrigin.Margin = new Padding(2, 0, 2, 0);
            labelSetOrigin.Name = "labelSetOrigin";
            labelSetOrigin.Size = new Size(0, 15);
            labelSetOrigin.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(HexFormatAmpersandRadioButton);
            panel1.Controls.Add(HexFormatSpecifierLabel);
            panel1.Controls.Add(HexFormatCStyleRadioButton);
            panel1.Controls.Add(HexFormatDollarSymbolRadioButton);
            panel1.Location = new Point(13, 105);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 26);
            panel1.TabIndex = 2;
            // 
            // HexFormatAmpersandRadioButton
            // 
            HexFormatAmpersandRadioButton.AutoSize = true;
            HexFormatAmpersandRadioButton.Location = new Point(216, 3);
            HexFormatAmpersandRadioButton.Margin = new Padding(2);
            HexFormatAmpersandRadioButton.Name = "HexFormatAmpersandRadioButton";
            HexFormatAmpersandRadioButton.Size = new Size(35, 19);
            HexFormatAmpersandRadioButton.TabIndex = 2;
            HexFormatAmpersandRadioButton.Text = "&&";
            HexFormatAmpersandRadioButton.UseVisualStyleBackColor = true;
            // 
            // HexFormatSpecifierLabel
            // 
            HexFormatSpecifierLabel.AutoSize = true;
            HexFormatSpecifierLabel.Location = new Point(25, 5);
            HexFormatSpecifierLabel.Margin = new Padding(2, 0, 2, 0);
            HexFormatSpecifierLabel.Name = "HexFormatSpecifierLabel";
            HexFormatSpecifierLabel.Size = new Size(117, 15);
            HexFormatSpecifierLabel.TabIndex = 0;
            HexFormatSpecifierLabel.Text = "Hex format specifier:";
            // 
            // HexFormatCStyleRadioButton
            // 
            HexFormatCStyleRadioButton.AutoSize = true;
            HexFormatCStyleRadioButton.Location = new Point(282, 3);
            HexFormatCStyleRadioButton.Margin = new Padding(2);
            HexFormatCStyleRadioButton.Name = "HexFormatCStyleRadioButton";
            HexFormatCStyleRadioButton.Size = new Size(37, 19);
            HexFormatCStyleRadioButton.TabIndex = 3;
            HexFormatCStyleRadioButton.Text = "0x";
            HexFormatCStyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // HexFormatDollarSymbolRadioButton
            // 
            HexFormatDollarSymbolRadioButton.AutoSize = true;
            HexFormatDollarSymbolRadioButton.Checked = true;
            HexFormatDollarSymbolRadioButton.Location = new Point(148, 3);
            HexFormatDollarSymbolRadioButton.Margin = new Padding(2);
            HexFormatDollarSymbolRadioButton.Name = "HexFormatDollarSymbolRadioButton";
            HexFormatDollarSymbolRadioButton.Size = new Size(31, 19);
            HexFormatDollarSymbolRadioButton.TabIndex = 1;
            HexFormatDollarSymbolRadioButton.TabStop = true;
            HexFormatDollarSymbolRadioButton.Text = "$";
            HexFormatDollarSymbolRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 52);
            panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(149, 2);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 22);
            textBox1.TabIndex = 1;
            textBox1.Text = "999";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 4);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 0;
            label2.Text = "New line after:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 4);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 2;
            label4.Text = "bytes on row";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(149, 25);
            textBox2.MaxLength = 3;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(31, 22);
            textBox2.TabIndex = 4;
            textBox2.Text = "999";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 27);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 3;
            label3.Text = "OR:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 27);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 5;
            label5.Text = "column limit";
            // 
            // CopyAsDecimalToClipboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 231);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(MemoryAddressPanel);
            Controls.Add(SeparateByteBitsByPanel);
            Controls.Add(button1);
            Controls.Add(CopyButton);
            Controls.Add(labelSetOrigin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CopyAsDecimalToClipboardForm";
            Text = "Copy As Decimal To Clipboard";
            MemoryAddressPanel.ResumeLayout(false);
            MemoryAddressPanel.PerformLayout();
            SeparateByteBitsByPanel.ResumeLayout(false);
            SeparateByteBitsByPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OriginTextBox;
        private RadioButton AddressSize32BitRadioButton;
        private Label AddressSizeLabel;
        private Panel MemoryAddressPanel;
        private RadioButton AddressSize16BitRadioButton;
        private Label SetOriginLabel;
        private CheckBox IncludeMemoryAddressCheckBox;
        private Label FormatBytesAsLabel;
        private RadioButton FormatBytesAsDecimalRadioButton;
        private RadioButton FormatBytesAsHexRadioButton;
        private Panel SeparateByteBitsByPanel;
        private Button button1;
        private Button CopyButton;
        private Label labelSetOrigin;
        private Panel panel1;
        private RadioButton HexFormatAmpersandRadioButton;
        private Label HexFormatSpecifierLabel;
        private RadioButton HexFormatCStyleRadioButton;
        private RadioButton HexFormatDollarSymbolRadioButton;
        private Panel panel2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label3;
    }
}