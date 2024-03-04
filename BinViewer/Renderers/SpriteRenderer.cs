namespace BinViewer.Renderers
{
    public class SpriteRenderer
    {
        private const int PixelsPerByte = 8;

        private readonly SpriteRenderParams _renderParams;

        public SpriteRenderer(SpriteRenderParams spriteRenderParams)
        {
            _renderParams = spriteRenderParams ?? throw new ArgumentNullException(nameof(spriteRenderParams));
        }

        public void Render()
        {
            var sourceIndex = 0;
            var x = _renderParams.StartX;
            var y = _renderParams.StartY;
            var brush = new SolidBrush(_renderParams.PixelColour);
            
            for (int i = 0; i < _renderParams.Rows; i++)
            {
                for (int j = 0; j < _renderParams.BytesPerRow; j++)
                {
                    PixelsFromByte(_renderParams.Source[sourceIndex++], x, y, brush);
                    x += _renderParams.PixelWidth * PixelsPerByte;
                }

                x = _renderParams.StartX;
                y += _renderParams.PixelHeight;
            }
        }

        private void PixelsFromByte(byte source, int x, int y, Brush brush)
        {
            var rect = new Rectangle(0, 0, _renderParams.PixelWidth, _renderParams.PixelHeight);

            var read = source;
            for (int i = 0; i < PixelsPerByte; i++)
            {
                if ((read & 0x80) != 0)
                {
                    // reuse rectangle struct
                    rect.X = x;
                    rect.Y = y;
                    _renderParams.Graphics.FillRectangle(brush, rect);
                }

                read <<= 1;
                x += _renderParams.PixelWidth;
            }
        }
    }
}