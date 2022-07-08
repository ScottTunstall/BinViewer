namespace BinViewer
{


    public class PixelRenderer
    {
        private const int BITS_PER_BYTE = 8;

        private readonly PixelRenderParams _renderParams;
        

        public PixelRenderer(PixelRenderParams pixelRenderParams)
        {
            _renderParams = pixelRenderParams ?? throw new ArgumentNullException(nameof(pixelRenderParams));
        }


        public void Render()
        {
            var sourceIndex = 0;
            var x = _renderParams.StartX;
            var y = _renderParams.StartY;

            for (int i = 0; i < _renderParams.Rows; i++)
            {
                for (int j = 0; j < _renderParams.BytesPerRow; j++)
                {
                    PixelsFromByte(_renderParams.Source[sourceIndex++], x, y);
                    x += _renderParams.PixelWidth * BITS_PER_BYTE;
                }

                x = _renderParams.StartX;
                y += _renderParams.PixelHeight;
            }
        }

        private void PixelsFromByte(byte source, int x, int y)
        {
            var read = source;
            for (int i=0; i< BITS_PER_BYTE; i++)
            {
                var rect = new Rectangle(x, y, _renderParams.PixelWidth, _renderParams.PixelHeight);
                var brush = ((read & 0x80) !=0) ? _renderParams.PixelBrush: _renderParams.BackGroundBrush;
                _renderParams.Graphics.FillRectangle(brush, rect);

                read <<= 1;
                x += _renderParams.PixelWidth;
            }
        }

    }
}
