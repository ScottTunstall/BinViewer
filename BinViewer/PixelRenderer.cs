namespace BinViewer
{
    public class PixelRenderer
    {
        private const int BITS_PER_BYTE = 8;

        private readonly Brush _backGroundBrush;
        private readonly Brush _pixelBrush;
        private readonly byte[] _source;
        private readonly int _bytesPerRow;
        private readonly int _rows;
        private readonly Graphics _graphics;
        private readonly int _x;
        private readonly int _y;
        private readonly int _pixelWidth;
        private readonly int _pixelHeight;

        public PixelRenderer(byte[] source, int bytesPerRow, int rows, Graphics graphics, int startX, int startY, int pixelWidth, int pixelHeight, Brush backGroundBrush, Brush pixelBrush)
        {
            _source = source;
            _bytesPerRow = bytesPerRow;
            _rows = rows;
            _graphics = graphics;
            _x = startX;
            _y = startY;
            _pixelWidth = pixelWidth;
            _pixelHeight = pixelHeight;
            _backGroundBrush = backGroundBrush;
            _pixelBrush = pixelBrush;
        }


        public void Render()
        {
            var sourceIndex = 0;
            var x = _x;
            var y = _y;

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _bytesPerRow; j++)
                {
                    PixelsFromByte(_source[sourceIndex], x, y);
                    sourceIndex++;
                    x += _pixelWidth * BITS_PER_BYTE;
                }

                x = _x;
                y += _pixelHeight;
            }
        }

        private void PixelsFromByte(byte source, int x, int y)
        {
            var read = source;
            for (int i=0; i< BITS_PER_BYTE; i++)
            {
                var rect = new Rectangle(x, y, _pixelWidth, _pixelHeight);
                var brush = ((read & 0x80) !=0) ? _pixelBrush : _backGroundBrush;
                _graphics.FillRectangle(brush, rect);

                read <<= 1;
                x += _pixelWidth;
            }
        }

    }
}
