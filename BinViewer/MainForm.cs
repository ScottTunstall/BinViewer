namespace BinViewer
{
    public partial class MainForm : Form
    {
        private const string Title = "Binary to pixel viewer";
        private const int DefaultZoomFactor = 3;
        private const int MinZoomFactor = 3;
        private const int MaxZoomFactor = 8;
        private const int PixelsPerByte = 8; // 8 pixels packed to 1 byte, meaning 1bit per pixel (1bpp)

        private readonly SpriteMemoryManager _memoryManager = new();
        private long _maxOffset;

        public MainForm()
        {
            InitializeComponent();
            ResetTitle();
        }

        private void offsetUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;
            var step = bytesPerRow * rows;

            switch (e.KeyCode)
            {
                case Keys.PageUp:
                    offsetUpDown.Value -= step;
                    offsetUpDown.Value = Math.Max(0, offsetUpDown.Value);
                    break;

                case Keys.PageDown:
                    if (offsetUpDown.Value + step <= _maxOffset)
                        offsetUpDown.Value += bytesPerRow * rows;
                    break;
            }
        }

        private void offsetUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void bytesPerRowUpdown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void rowsUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void zoomUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            var fileSize = _memoryManager.FromFile(openFileDialog.FileName);

            SetFileNameInTitle(openFileDialog.FileName);
            SetMaxOffset(fileSize - 1);
            ResetZoom();
            EnableEditing();
            pictureBox1.Invalidate();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _memoryManager.Close();

            ResetTitle();
            ResetMaxOffset();
            ResetZoom();
            DisableEditing();
            pictureBox1.Invalidate();
        }

        private void copyAsBinaryToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var offset = (int)offsetUpDown.Value;
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;

            var optionsForm = new CopyAsBinaryToClipboardForm(offset, bytesPerRow, rows, _memoryManager);
            optionsForm.ShowDialog(this);
        }

        private void copyRenderAreaToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using Image img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using var g = Graphics.FromImage(img);

            g.CopyFromScreen(PointToScreen(pictureBox1.Location), new Point(0, 0), new Size(pictureBox1.Width, pictureBox1.Height));

            Clipboard.SetImage(img);
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetZoom();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void gridlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewGridlinesToolStripMenuItem.Checked = !viewGridlinesToolStripMenuItem.Checked;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using var backGroundBrush = new SolidBrush(pictureBox1.BackColor);
            e.Graphics.FillRectangle(backGroundBrush, e.ClipRectangle);

            if (!_memoryManager.HasData)
                return;

            var offset = (int)offsetUpDown.Value;
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;
            var zoomFactor = (int)zoomUpDown.Value;
            var enableGrid = viewGridlinesToolStripMenuItem.Checked;

            if (!_memoryManager.TryGetBytes(offset, bytesPerRow * rows, out var bytes))
                return;

            if (enableGrid)
            {
                var gridRenderParams = new GridRenderParams(e.Graphics, 0,0, bytesPerRow, rows, PixelsPerByte, 1<< zoomFactor, 1<<zoomFactor, Pens.Black );
                var gridRenderer = new GridRenderer(gridRenderParams);
                gridRenderer.Render();
            }

            var spriteRenderParams = new SpriteRenderParams(bytes!, bytesPerRow, rows, e.Graphics, 0, 0, 1 << zoomFactor, 1 << zoomFactor, PixelsPerByte, Brushes.Black);
            var spriteRenderer = new SpriteRenderer(spriteRenderParams);
            spriteRenderer.Render();
        }

        private void ResetTitle()
        {
            this.Text = Title;
        }

        private void SetFileNameInTitle(string fileName)
        {
            this.Text = $"{fileName} - {Title}";
        }

        private void SetMaxOffset(long maxOffset)
        {
            _maxOffset = maxOffset;
            offsetUpDown.Maximum = maxOffset;
        }

        private void ResetMaxOffset()
        {
            _maxOffset = 0;
            offsetUpDown.Minimum = offsetUpDown.Maximum = _maxOffset;
        }

        private void ResetZoom()
        {
            zoomUpDown.Value = DefaultZoomFactor;
            zoomUpDown.Minimum = MinZoomFactor;
            zoomUpDown.Maximum = MaxZoomFactor;

            var currentZoomFactor = (int)zoomUpDown.Value;
            zoomOutToolStripMenuItem.Enabled = currentZoomFactor > MinZoomFactor;
            zoomInToolStripMenuItem.Enabled = currentZoomFactor < MaxZoomFactor;
            pictureBox1.Invalidate();
        }

        private void ZoomIn()
        {
            var zoomFactor = (int)zoomUpDown.Value;

            if (zoomFactor >= MaxZoomFactor)
            {
                zoomUpDown.Value = MaxZoomFactor;
                return;
            }

            zoomFactor++;
            zoomUpDown.Value = zoomFactor;

            if (zoomFactor == MaxZoomFactor)
            {
                zoomInToolStripMenuItem.Enabled = false;
            }

            zoomOutToolStripMenuItem.Enabled = true;

            pictureBox1.Invalidate();
        }

        private void ZoomOut()
        {
            var zoomFactor = (int)zoomUpDown.Value;

            if (zoomFactor <= MinZoomFactor)
            {
                zoomUpDown.Value = MinZoomFactor;
                return;
            }

            zoomFactor--;
            zoomUpDown.Value = zoomFactor;

            if (zoomFactor == MinZoomFactor)
            {
                zoomOutToolStripMenuItem.Enabled = false;
            }

            zoomInToolStripMenuItem.Enabled = true;

            pictureBox1.Invalidate();
        }

        private void EnableEditing()
        {
            editToolStripMenuItem.Enabled = true;
            viewToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = true;

            offsetUpDown.Enabled = true;
            bytesPerRowUpdown.Enabled = true;
            rowsUpDown.Enabled = true;
            zoomUpDown.Enabled = true;
        }

        private void DisableEditing()
        {
            editToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;
            closeToolStripMenuItem.Enabled = false;

            offsetUpDown.Enabled = false;
            bytesPerRowUpdown.Enabled = false;
            rowsUpDown.Enabled = false;
            zoomUpDown.Enabled = false;
        }
    }
}