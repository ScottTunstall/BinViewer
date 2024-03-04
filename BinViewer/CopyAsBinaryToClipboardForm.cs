using System.Text;
using BinViewer.Extensions;
using BinViewer.Generators;

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
        }

        private void IncludeMemoryAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetOriginFormattingRadiosFromRequireOriginCheckbox();
        }

        private void OriginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var keypressed = e.KeyChar;

            if (keypressed == (char)Keys.Back || keypressed == (char)Keys.Delete)
                return;

            if (!keypressed.IsHexadecimal())
                e.Handled = true;

            e.KeyChar = char.ToUpper(keypressed);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (!TryValidateInput(out var validationFailures))
            {
                ShowValidationFailureDialog("Copy failed", validationFailures);
                DialogResult = DialogResult.None;
                return;
            }

            int rows = CopyBinaryToClipboard();

            ShowCopyBinarySuccessDialog(rows);
        }

        private void SetOriginFormattingRadiosFromRequireOriginCheckbox()
        {
            AddressSizeLabel.Enabled = IncludeMemoryAddressCheckBox.Checked;
            AddressSize16BitRadioButton.Enabled = IncludeMemoryAddressCheckBox.Checked;
            AddressSize32BitRadioButton.Enabled = IncludeMemoryAddressCheckBox.Checked;
            SetOriginLabel.Enabled = IncludeMemoryAddressCheckBox.Checked;
            OriginTextBox.Enabled = IncludeMemoryAddressCheckBox.Checked;
        }

        private void SetBytesPerRowRadios()
        {
            OneBytePerRowRadioButton.Checked = _originalBytesPerRow == 1;
            BytesPerRowRadioButton.Visible = _originalBytesPerRow > 1;
            BytesPerRowRadioButton.Checked = _originalBytesPerRow > 1;
            BytesPerRowRadioButton.Text = $"{_originalBytesPerRow} bytes per row";
        }

        private bool TryValidateInput(out IEnumerable<string> errors)
        {
            var errorList = new List<string>();

            if (IncludeMemoryAddressCheckBox.Checked)
            {
                if (!uint.TryParse(OriginTextBox.Text, System.Globalization.NumberStyles.HexNumber, null, out uint origin))
                {
                    errorList.Add("Origin is not a valid hexadecimal number.");
                }

                if (AddressSize16BitRadioButton.Checked && origin > ushort.MaxValue)
                {
                    errorList.Add($"When formatting addresses as 16-bit, origin can only be between 0-0x{ushort.MaxValue:X}.");
                }
            }

            errors = errorList;
            return !errors.Any();
        }

        private void ShowValidationFailureDialog(string title, IEnumerable<string> validationFailures)
        {
            StringBuilder sb = new();
            sb.Append("There were input validation failures:");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.AppendJoin(Environment.NewLine, validationFailures);

            MessageBox.Show(this, sb.ToString());
        }

        private int CopyBinaryToClipboard()
        {
            (int bytesPerRow, int rows) = GetBytesPerRowAndRows();

            var binaryGenerator = new BinaryGenerator();
            var data = _memoryManager.GetBytes(_offset, bytesPerRow * rows);

            string asBinaryString;
            if (IncludeMemoryAddressCheckBox.Checked)
            {
                asBinaryString = binaryGenerator.FromBytes(data, OriginTextBox.Text, GetAddressDigitPadding(), bytesPerRow, rows, GetSeparator());
            }
            else
            {
                asBinaryString = binaryGenerator.FromBytes(data, bytesPerRow, rows, GetSeparator());
            }

            Clipboard.SetText(asBinaryString);
            return rows;
        }

        private void ShowCopyBinarySuccessDialog(int rowsCopied)
        {
            MessageBox.Show(this, $"Copied binary for {rowsCopied} row(s) to clipboard.");
        }

        private (int bytesPerRow, int rows) GetBytesPerRowAndRows()
        {
            return OneBytePerRowRadioButton.Checked ? (1, _rows * _originalBytesPerRow) : (_originalBytesPerRow, _rows);
        }

        private int GetAddressDigitPadding()
        {
            return AddressSize16BitRadioButton.Checked ? HexDigitsFor16BitAddress : HexDigitsFor32BitAddress;
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