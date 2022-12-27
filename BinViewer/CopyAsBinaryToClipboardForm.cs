namespace BinViewer
{
    public partial class CopyAsBinaryToClipboardForm : Form
    {
        private const int HexDigitsFor16BitAddress = 4;
        private const int HexDigitsFor32BitAddress = 8;

        private readonly int _offset;
        private int _bytesPerRow;
        private readonly int _originalBytesPerRow;
        private int _rows;
        private readonly int _originalRows;
        private readonly SpriteMemoryManager _memoryManager;

        private bool _requireOrigin;
        private string _separator = string.Empty;
        private int _maxHexDigitsForAddress;

        public CopyAsBinaryToClipboardForm(int offset, int bytesPerRow, int rows, SpriteMemoryManager memoryManager)
        {
            _offset = offset;
            _bytesPerRow = bytesPerRow;
            _originalBytesPerRow = bytesPerRow;
            _rows = rows;
            _originalRows = rows;
            _memoryManager = memoryManager;

            InitializeComponent();
        }

        private void CopyAsBinaryToClipboardForm_Load(object sender, EventArgs e)
        {
            _requireOrigin = IncludeMemoryAddressCheckBox.Checked;

            SetBytesPerRowRadios();

            SetRequireOriginFromCheckBox();
            SetAddressDigitPaddingFromRadios();
            SetBytesPerRowFromRadios();
            SetSeparatorFromRadios();
        }

        private void IncludeMemoryAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetRequireOriginFromCheckBox();
        }

        private void FormatAddressesAsSixteenBitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetAddressDigitPaddingFromRadios();
        }

        private void FormatAddressesAsThirtyTwoBitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetAddressDigitPaddingFromRadios();
        }

        private void OneBytePerRowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetBytesPerRowFromRadios();
        }

        private void BytesPerRowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetBytesPerRowFromRadios();
        }

        private void SeparateBySpaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSeparatorFromRadios();
        }

        private void SeparateByCommaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSeparatorFromRadios();
        }

        private void SeparateByNothingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSeparatorFromRadios();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            var binaryGenerator = new BinaryGenerator();
            var data = _memoryManager.GetBytes(_offset, _bytesPerRow * _rows);

            string asBinaryString;
            if (_requireOrigin)
            {
                int origin = (int)OriginUpDown.Value;
                asBinaryString = binaryGenerator.FromBytes(data, origin, _maxHexDigitsForAddress, _bytesPerRow, _rows, _separator);
            }
            else
            {
                asBinaryString = binaryGenerator.FromBytes(data, _bytesPerRow, _rows, _separator);
            }

            Clipboard.SetText(asBinaryString);

            MessageBox.Show($"Copied binary for {_rows} row(s) to clipboard.");
        }

        private void SetRequireOriginFromCheckBox()
        {
            _requireOrigin = IncludeMemoryAddressCheckBox.Checked;
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

        private void SetAddressDigitPaddingFromRadios()
        {
            if (FormatAddressesAsThirtyTwoBitRadioButton.Checked)
            {
                _maxHexDigitsForAddress = HexDigitsFor32BitAddress;
                return;
            }

            _maxHexDigitsForAddress = HexDigitsFor16BitAddress;
        }

        private void SetBytesPerRowFromRadios()
        {
            if (OneBytePerRowRadioButton.Checked)
            {
                _bytesPerRow = 1;
                _rows = _originalRows * _originalBytesPerRow;
                return;
            }

            _bytesPerRow = _originalBytesPerRow;
            _rows = _originalRows;
        }

        private void SetSeparatorFromRadios()
        {
            if (SeparateByNothingRadioButton.Checked)
            {
                _separator = string.Empty;
                return;
            }

            if (seperateBySpaceRadioButton.Checked)
            {
                _separator = " ";
                return;
            }

            _separator = ",";
        }
    }
}