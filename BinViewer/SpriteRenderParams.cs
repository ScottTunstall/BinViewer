namespace BinViewer
{
    public class SpriteRenderParams
    {
        public const int DefaultPixelWidth = 8;
        public const int DefaultPixelHeight = 8;


        public SpriteRenderParams(byte[] source, int bytesPerRow, int rows, Graphics graphics): this(source, bytesPerRow, rows, graphics,0,0,DefaultPixelWidth,DefaultPixelHeight, Brushes.Black)
        {

        }

        public SpriteRenderParams(byte[] source, int bytesPerRow, int rows, Graphics graphics, int startX, int startY, int pixelWidth, int pixelHeight, Brush pixelBrush)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));

            if (bytesPerRow < 1) throw new ArgumentOutOfRangeException(nameof(bytesPerRow), "bytesperrow must be nonzero positive integer");
            BytesPerRow = bytesPerRow;

            if (rows < 1) throw new ArgumentOutOfRangeException(nameof(rows),"rows must be nonzero positive integer");

            Rows = rows;
            Graphics = graphics ?? throw new ArgumentNullException(nameof(graphics));

            if (startX < 0) throw new ArgumentOutOfRangeException(nameof(startX), "startX must be a positive integer");
            StartX = startX;

            if (startY < 0) throw new ArgumentOutOfRangeException(nameof(startY), "startY must be a positive integer");
            StartY = startY;

            if (pixelWidth < 1) throw new ArgumentOutOfRangeException(nameof(pixelWidth),"pixelWidth must be nonzero positive integer");
            PixelWidth = pixelWidth;

            if (pixelHeight < 1) throw new ArgumentOutOfRangeException(nameof(pixelHeight),"pixelHeight must be nonzero positive integer");
            PixelHeight = pixelHeight;

            PixelBrush = pixelBrush ?? Brushes.Black;
        }

        public byte[] Source { get; private set; }
        public int BytesPerRow { get; private set; }
        public int Rows { get; private set; }
        public Graphics Graphics { get; private set; }
        public int StartX { get; init ; }
        public int StartY { get; init; }
        public int PixelWidth { get; init; }
        public int PixelHeight { get; init; } 
        public Brush PixelBrush { get; init; }
    }
}