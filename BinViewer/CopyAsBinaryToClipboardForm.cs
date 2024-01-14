namespace BinViewer
{
    public partial class CopyAsBinaryToClipboardForm : Form
    {
        private const int HexDigitsFor16BitAddress = 4;
        private const int HexDigitsFor32BitAddress = 8;

        private readonly int _offset;
        private readonly int _originalBytesPerRow;
        private readonly int _rows;
        private readonly SpriteMemoryManager _memoryManager;

        public CopyAsBinaryToClipboardForm(int offset, int bytesPerRow, int rows, SpriteMemoryManager memoryManager)
        {
            _offset = offset;
            _originalBytesPerRow = bytesPerRow;
            _rows = rows;
            _memoryManager = memoryManager;

            InitializeComponent();
        }

        private void CopyAsBinaryToClipboardForm_Load(object sender, EventArgs e)
        {
            SetBytesPerRowRadios();
            SetOriginFormattingRadiosFromRequireOriginCheckbox();
            SetOriginUpdownMaxValueFromRadios();
        }

        private void IncludeMemoryAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetOriginFormattingRadiosFromRequireOriginCheckbox();
        }

        private void FormatAddressesAsSixteenBitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetOriginUpdownMaxValueFromRadios();
        }

        private void FormatAddressesAsThirtyTwoBitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetOriginUpdownMaxValueFromRadios();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            CopyBinaryToClipboard();
        }

        private void SetOriginFormattingRadiosFromRequireOriginCheckbox()
        {
            FormatAddressesAsLabel.Enabled = IncludeMemoryAddressCheckBox.Checked;
            FormatAddressesAsSixteenBitRadioButton.Enabled = IncludeMemoryAddressCheckBox.Checked;
            FormatAddressesAsThirtyTwoBitRadioButton.Enabled = IncludeMemoryAddressCheckBox.Checked;
            SetOriginLabel.Enabled = IncludeMemoryAddressCheckBox.Checked;
            OriginUpDown.Enabled = IncludeMemoryAddressCheckBox.Checked;
        }

        private void SetBytesPerRowRadios()
        {
            OneBytePerRowRadioButton.Checked = _originalBytesPerRow == 1;
            BytesPerRowRadioButton.Visible = _originalBytesPerRow > 1;
            BytesPerRowRadioButton.Checked = _originalBytesPerRow > 1;
            BytesPerRowRadioButton.Text = $"{_originalBytesPerRow} bytes per row";
        }

        private void SetOriginUpdownMaxValueFromRadios()
        {
            var oldValue = (uint)OriginUpDown.Maximum;
            if (FormatAddressesAsSixteenBitRadioButton.Checked)
            {
                OriginUpDown.Maximum = ushort.MaxValue;
                OriginUpDown.Value = (ushort) (oldValue & 0xffff);
            }
            else
            {
                OriginUpDown.Maximum = int.MaxValue;
            }
        }



        private void CopyBinaryToClipboard()
        {
            (int bytesPerRow, int rows) = GetBytesPerRowAndRows();

            var binaryGenerator = new BinaryGenerator();
            var data = _memoryManager.GetBytes(_offset, bytesPerRow * rows);

            string asBinaryString;
            if (IncludeMemoryAddressCheckBox.Checked)
            {
                int origin = (int)OriginUpDown.Value;
                asBinaryString = binaryGenerator.FromBytes(data, origin, GetAddressDigitPadding(), bytesPerRow, rows, GetSeparator());
            }
            else
            {
                asBinaryString = binaryGenerator.FromBytes(data, bytesPerRow, rows, GetSeparator());
            }

            Clipboard.SetText(asBinaryString);

            MessageBox.Show($"Copied binary for {_rows} row(s) to clipboard.");
        }

        private (int bytesPerRow, int rows) GetBytesPerRowAndRows()
        {
            return OneBytePerRowRadioButton.Checked ? (1, _rows * _originalBytesPerRow) : (_originalBytesPerRow, _rows);
        }

        private int GetAddressDigitPadding()
        {
            return FormatAddressesAsSixteenBitRadioButton.Checked ? HexDigitsFor16BitAddress : HexDigitsFor32BitAddress;
        }

        private string GetSeparator()
        {
            if (SeparateByNothingRadioButton.Checked)
            {
                return string.Empty;
            }

            if (seperateBySpaceRadioButton.Checked)
            {
                return " ";
            }

            return ",";
        }


    }
}