namespace BinViewer
{


    public class SpriteRenderer
    {
        private const int BitsPerByte = 8;

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

            for (int i = 0; i < _renderParams.Rows; i++)
            {
                for (int j = 0; j < _renderParams.BytesPerRow; j++)
                {
                    PixelsFromByte(_renderParams.Source[sourceIndex++], x, y);
                    x += _renderParams.PixelWidth * BitsPerByte;
                }

                x = _renderParams.StartX;
                y += _renderParams.PixelHeight;
            }
        }

        private void PixelsFromByte(byte source, int x, int y)
        {
            var read = source;
            for (int i=0; i< BitsPerByte; i++)
            {
                if ((read & 0x80) != 0)
                {
                    var rect = new Rectangle(x, y, _renderParams.PixelWidth, _renderParams.PixelHeight);
                    _renderParams.Graphics.FillRectangle(_renderParams.PixelBrush, rect);
                }

                read <<= 1;
                x += _renderParams.PixelWidth;
            }
        }

    }
}
