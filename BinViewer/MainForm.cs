namespace BinViewer
{
    public partial class MainForm : Form
    {
        private const int DEFAULT_ZOOM_FACTOR = 3;

        private MemoryStream? _stream;
        int _zoomFactor = DEFAULT_ZOOM_FACTOR;

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

            if (_stream!=null)
                _stream.Dispose();

            _stream = new MemoryStream(File.ReadAllBytes(openFileDialog.FileName));
            EnableEditing();
            pictureBox1.Invalidate();
        }


        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _zoomFactor = DEFAULT_ZOOM_FACTOR;
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

            if (_stream == null)
                return;

            using var foreGroundBrush = new SolidBrush(Color.Black);

            var offset = (int)offsetUpDown.Value;
            var bytesPerRow = (int)bytesPerRowUpdown.Value;
            var rows = (int)rowsUpDown.Value;

            var bufferSize = bytesPerRow * rows;
            var buffer = new byte[bufferSize];

            _stream.Position = offset;
            _stream.Read(buffer, 0, bufferSize);

            var renderer = new PixelRenderer(buffer, bytesPerRow, rows, e.Graphics, 0, 0, 1 << _zoomFactor, 1 << _zoomFactor, backGroundBrush, foreGroundBrush);
            renderer.Render();
        }

        void EnableEditing()
        {
            viewToolStripMenuItem.Enabled = true;
            zoomInToolStripMenuItem.Enabled = true;
            zoomOutToolStripMenuItem.Enabled = true;
            resetZoomToolStripMenuItem.Enabled = true;

            offsetUpDown.Enabled = true;
            bytesPerRowUpdown.Enabled = true;
            rowsUpDown.Enabled = true;
        }


    }
}