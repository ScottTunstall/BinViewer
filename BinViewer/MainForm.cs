//
// Software developed by Scott Tunstall B.Sc
// Contact: scott.tunstall@ntlworld.com
//

using Microsoft.Extensions.Options;

namespace BinViewer
{
    public partial class MainForm : Form
    {
        private const string Title = "Binary to pixel viewer";
        private const int DefaultZoomFactor = 3;
        private const int MinZoomFactor = 3;
        private const int MaxZoomFactor = 8;
        private const int PixelsPerByte = 8; // 8 pixels packed to 1 byte, meaning 1bit per pixel (1bpp)

        private readonly SpriteMemoryManager _memoryManager;
        private readonly MostRecentlyUsedFilesManager _mruFilesManager;
        private long _maxOffset;

        public MainForm(IOptions<AppSettings> settings)
        {
            _memoryManager = new();
            _mruFilesManager = new(settings.Value.SettingsSubKey, settings.Value.MaxRecentlyUsedFiles);

            InitializeComponent();
            ResetTitle();
            LoadMostRecentlyUsedFiles();
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

            LoadFile(openFileDialog.FileName);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void copyAsBinaryToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCopyAsBinaryDialog();
        }

        private void copyRenderAreaToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clipboardCopier = new ControlRenderAreaToClipboardCopier();
            clipboardCopier.CopyFrom(this, pictureBox1.Location, pictureBox1.Width, pictureBox1.Height);

            MessageBox.Show("Render area copied to clipboard.");
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
                var gridRenderParams = new GridRenderParams(e.Graphics, 0, 0, bytesPerRow, rows, PixelsPerByte, 1 << zoomFactor, 1 << zoomFactor, pictureBox1.ForeColor);
                var gridRenderer = new GridRenderer(gridRenderParams);
                gridRenderer.Render();
            }

            var spriteRenderParams = new SpriteRenderParams(bytes!, bytesPerRow, rows, e.Graphics, 0, 0, 1 << zoomFactor, 1 << zoomFactor, PixelsPerByte, pictureBox1.ForeColor);
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

        private void LoadFile(string fileName)
        {
            var fileSize = _memoryManager.Load(fileName);
            SetMaxOffset(fileSize - 1);
            SetFileNameInTitle(fileName);
            AddToMostRecentlyUsedFiles(fileName);
            ResetZoom();
            EnableEditing();
            pictureBox1.Invalidate();
        }

        private void CloseFile()
        {
            _memoryManager.Close();

            ResetTitle();
            ResetMaxOffset();
            ResetZoom();
            DisableEditing();
            pictureBox1.Invalidate();
        }



        private void AddToMostRecentlyUsedFiles(string fileName)
        {
            _mruFilesManager.Add(fileName);
            LoadMostRecentlyUsedFiles();
        }

        private void LoadMostRecentlyUsedFiles()
        {
            var dropDownItems = recentFilesToolStripMenuItem.DropDownItems;
            dropDownItems.Clear();

            var mostRecentlyUsedFileNames = _mruFilesManager.Get().ToList();
            for (int i=0; i<mostRecentlyUsedFileNames.Count; i++)
            {
                var toolStripItem = new ToolStripMenuItem($"&{i+1}. {mostRecentlyUsedFileNames[i]}");
                dropDownItems.Add(toolStripItem);
            }

            recentFilesToolStripMenuItem.Enabled = recentFilesToolStripMenuItem.Visible = mostRecentlyUsedFileNames.Any();
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

            resetZoomToolStripMenuItem.Enabled = true;
            var currentZoomFactor = (int)zoomUpDown.Value;
            zoomOutToolStripMenuItem.Enabled = currentZoomFactor > MinZoomFactor;
            zoomInToolStripMenuItem.Enabled = currentZoomFactor < MaxZoomFactor;
            pictureBox1.Invalidate();
        }

        private void ShowCopyAsBinaryDialog()
        {
            var offset = (int)offsetUpDown.Value;
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;

            var optionsForm = new CopyAsBinaryToClipboardForm(offset, bytesPerRow, rows, _memoryManager);
            optionsForm.ShowDialog(this);
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
            closeToolStripMenuItem.Enabled = true;

            editToolStripMenuItem.Enabled = true;
            viewToolStripMenuItem.Enabled = true;

            offsetUpDown.Enabled = true;
            bytesPerRowUpdown.Enabled = true;
            rowsUpDown.Enabled = true;
            zoomUpDown.Enabled = true;
        }

        private void DisableEditing()
        {
            closeToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;

            offsetUpDown.Enabled = false;
            bytesPerRowUpdown.Enabled = false;
            rowsUpDown.Enabled = false;
            zoomUpDown.Enabled = false;
        }
    }
}