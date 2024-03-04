using BinViewer.Extensions;
using System;
using System.Buffers;
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
    public partial class CopyAsDecimalToClipboardForm : Form
    {
        private readonly int _offset;
        private readonly int _originalBytesPerRow;
        private readonly int _rows;
        private readonly SpriteMemoryManager _memoryManager;

        public CopyAsDecimalToClipboardForm(int offset, int bytesPerRow, int rows, SpriteMemoryManager memoryManager)
        {
            _offset = offset;
            _originalBytesPerRow = bytesPerRow;
            _rows = rows;
            _memoryManager = memoryManager;

            InitializeComponent();
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
            //if (!TryValidateInput(out var validationFailures))
            //{
            //    ShowValidationFailureDialog("Copy failed", validationFailures);
            //    DialogResult = DialogResult.None;
            //    return;
            //}

            //int rows = CopyBinaryToClipboard();

            //ShowCopyBinarySuccessDialog(rows);
        }
    }
}
