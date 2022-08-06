namespace BinViewer
{
    public partial class MainForm : Form
    {
        private const int DefaultZoomFactor = 3;

        private readonly SpriteMemoryManager _memoryManager = new();
        int _zoomFactor = DefaultZoomFactor;

        public MainForm()
        {
            InitializeComponent();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            _memoryManager.FromFile(openFileDialog.FileName);

            EnableEditing();
            pictureBox1.Invalidate();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _memoryManager.Close();

            pictureBox1.Invalidate();
            DisableEditing();
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
            _zoomFactor = DefaultZoomFactor;
            pictureBox1.Invalidate();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _zoomFactor++;
            pictureBox1.Invalidate();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_zoomFactor > 0)
                _zoomFactor--;

            pictureBox1.Invalidate();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using var backGroundBrush = new SolidBrush(pictureBox1.BackColor);
            e.Graphics.FillRectangle(backGroundBrush, e.ClipRectangle);

            if (!_memoryManager.HasData)
                return;

            using var foreGroundBrush = new SolidBrush(Color.Black);

            var offset = (int)offsetUpDown.Value;
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;
            
            var bytes = _memoryManager.GetBytes(offset, bytesPerRow * rows);

            var renderParams = new PixelRenderParams(bytes, bytesPerRow, rows, e.Graphics, 0, 0, 1 << _zoomFactor,
                1 << _zoomFactor, backGroundBrush, foreGroundBrush);
            var renderer = new PixelRenderer(renderParams);
            renderer.Render();
        }

        void EnableEditing()
        {
            editToolStripMenuItem.Enabled = true;
            viewToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = true;

            offsetUpDown.Enabled = true;
            bytesPerRowUpdown.Enabled = true;
            rowsUpDown.Enabled = true;
        }

        private void DisableEditing()
        {
            editToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;
            closeToolStripMenuItem.Enabled = false;

            offsetUpDown.Enabled = false;
            bytesPerRowUpdown.Enabled = false;
            rowsUpDown.Enabled = false;
        }


    }
}