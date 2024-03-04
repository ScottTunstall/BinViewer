//
// Software developed by Scott Tunstall B.Sc
// Contact: scott.tunstall@ntlworld.com
// If you like this app and want to buy me a coffee, feel free! https://ko-fi.com/scotttunstall
//

using BinViewer.Renderers;
using Microsoft.Extensions.Logging;
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

        private readonly SpriteMemoryManager _spriteMemoryManager;
        private readonly MostRecentlyUsedFilesManager _mostRecentlyUsedFilesManager;
        private long _maxOffset;
        private readonly ILogger _logger;

        public MainForm(IOptions<AppSettings> settings, ILogger<MainForm> logger)
        {
            _spriteMemoryManager = new();
            _mostRecentlyUsedFilesManager = new(settings.Value.SettingsSubKey, settings.Value.MaxRecentlyUsedFiles);
            _logger = logger;

            InitializeComponent();
            ResetTitle();
            LoadMostRecentlyUsedFiles();
        }

        private void offsetUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.PageUp:
                    PreviousPage();
                    break;

                case Keys.PageDown:
                    NextPage();
                    break;
            }

            pictureBox1.Invalidate();
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
            ShowOpenFileDialog();
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
            CopyRenderAreaToClipboard();
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
            // TODO: Move into a control derived from PictureBox so we can encapsulate this logic
            using var backGroundBrush = new SolidBrush(pictureBox1.BackColor);
            e.Graphics.FillRectangle(backGroundBrush, e.ClipRectangle);

            if (!_spriteMemoryManager.HasData)
                return;

            var offset = (int)offsetUpDown.Value;
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;
            var zoomFactor = (int)zoomUpDown.Value;
            var enableGrid = viewGridlinesToolStripMenuItem.Checked;

            if (!_spriteMemoryManager.TryGetBytes(offset, bytesPerRow * rows, out var bytes))
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

        private void ShowOpenFileDialog()
        {
            var result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            var fileName = openFileDialog.FileName;

            try
            {
                LoadFile(fileName);
            }
            catch (Exception)
            {
                ShowLoadFailDialog(fileName);
            }
        }

        private void LoadFile(string fileName)
        {
            try
            {
                var fileSize = _spriteMemoryManager.Load(fileName);
                SetMaxOffset(fileSize - 1);
                SetFileNameInTitle(fileName);
                AddToMostRecentlyUsedFiles(fileName);
                ResetZoom();
                EnableEditing();

                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(LoadFile)}: MISSINGFILE: could not load file: {fileName}");

                // It's not for this method to decide what to do if you can't load a file - throw it up to its caller
                throw;
            }
        }

        private void CloseFile()
        {
            _spriteMemoryManager.Close();

            ResetTitle();
            ResetMaxOffset();
            ResetZoom();
            DisableEditing();
            pictureBox1.Invalidate();
        }

        private void ShowLoadFailDialog(string fileThatCouldntBeLoaded)
        {
            MessageBox.Show(this, $"The file{Environment.NewLine}'{fileThatCouldntBeLoaded}`{Environment.NewLine} could not be loaded.");
        }

        private void AddToMostRecentlyUsedFiles(string fileName)
        {
            _mostRecentlyUsedFilesManager.Add(fileName);
            LoadMostRecentlyUsedFiles();
        }

        private void LoadMostRecentlyUsedFiles()
        {
            var dropDownItems = recentFilesToolStripMenuItem.DropDownItems;
            dropDownItems.Clear();

            var mostRecentlyUsedFileNames = _mostRecentlyUsedFilesManager.Get().ToList();

            for (int i = 0; i < mostRecentlyUsedFileNames.Count; i++)
            {
                var toolStripItem = new ToolStripMenuItem();
                toolStripItem.Text = i < 9 ?
                    $"&{i + 1}. {mostRecentlyUsedFileNames[i]}" :
                    $"{i + 1}. {mostRecentlyUsedFileNames[i]}";

                toolStripItem.Tag = mostRecentlyUsedFileNames[i];
                toolStripItem.Click += MostRecentlyUsedFile_Click;
                dropDownItems.Add(toolStripItem);
            }

            recentFilesToolStripMenuItem.Visible = mostRecentlyUsedFileNames.Any();
        }

        private void MostRecentlyUsedFile_Click(object? sender, EventArgs e)
        {
            var toolStripItem = sender as ToolStripMenuItem;
            var fileName = (string)toolStripItem!.Tag;

            try
            {
                LoadFile(fileName);
            }
            catch (FileNotFoundException)
            {
                ShowConfirmRemovalOfMissingFileDialog(fileName);
            }
        }

        private void ShowConfirmRemovalOfMissingFileDialog(string fileName)
        {
            var result = MessageBox.Show(this, $"The file or folder {Environment.NewLine}'{fileName}'{Environment.NewLine}cannot be opened. Do you want to remove the references to it from the recent list?", Title, MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            _mostRecentlyUsedFilesManager.Remove(fileName);
            LoadMostRecentlyUsedFiles();
        }

        private void ShowCopyAsBinaryDialog()
        {
            var offset = (int)offsetUpDown.Value;
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;

            var optionsForm = new CopyAsBinaryToClipboardForm(offset, bytesPerRow, rows, _spriteMemoryManager);
            optionsForm.ShowDialog(this);
        }

        private void CopyRenderAreaToClipboard()
        {
            var clipboardCopier = new ControlRenderAreaToClipboardCopier();
            clipboardCopier.CopyFrom(this, pictureBox1.Location, pictureBox1.Width, pictureBox1.Height);
            MessageBox.Show("Render area copied to clipboard.");
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

        private void PreviousPage()
        {
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;
            var step = bytesPerRow * rows;

            offsetUpDown.Value -= step;
            offsetUpDown.Value = Math.Max(0, offsetUpDown.Value);
        }

        private void NextPage()
        {
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;
            var step = bytesPerRow * rows;

            if (offsetUpDown.Value + step <= _maxOffset)
                offsetUpDown.Value += bytesPerRow * rows;
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

        private void ZoomIn()
        {
            var zoomFactor = (int)zoomUpDown.Value;
            zoomFactor++;
            zoomFactor = Math.Min(zoomFactor, MaxZoomFactor);
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
            zoomFactor--;
            zoomFactor = Math.Max(zoomFactor, MinZoomFactor);
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