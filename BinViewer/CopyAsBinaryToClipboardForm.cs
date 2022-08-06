using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinViewer
{
    public partial class CopyAsBinaryToClipboardForm : Form
    {
        private readonly int _offset;
        private int _bytesPerRow;
        private readonly int _originalBytesPerRow;
        private int _rows;
        private readonly int _originalRows;
        private readonly SpriteMemoryManager _memoryManager;

        private bool _requireOrigin;
        private string _separator = string.Empty;


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
            SetBytesPerRow();
            SetSeparator();
        }
        

        private void IncludeMemoryAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked)
                EnableOrigin();
            else
                DisableOrigin();
        }

        private void OneBytePerRowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetBytesPerRow();
        }

        private void BytesPerRowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetBytesPerRow();
        }

        private void SeparateBySpaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSeparator();
        }

        private void SeparateByCommaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSeparator();
        }

        private void SeparateByNothingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSeparator();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            var binary = new BinaryGenerator();
            var data = _memoryManager.GetBytes(_offset, _bytesPerRow * _rows);
            var asBinaryStrings = binary.FromBytes(data, _bytesPerRow, _rows, _separator);
            Clipboard.SetText(asBinaryStrings);
            MessageBox.Show("Copied to clipboard.");
        }


        private void EnableOrigin()
        {
            _requireOrigin = true;
            SetOriginLabel.Enabled = true;
            OriginUpDown.Enabled = true;
        }

        private void DisableOrigin()
        {
            _requireOrigin = false;
            SetOriginLabel.Enabled = false;
            OriginUpDown.Enabled = false;
        }

        private void SetBytesPerRow()
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

        private void SetSeparator()
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
