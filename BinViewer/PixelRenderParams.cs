using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinViewer
{
    public class PixelRenderParams
    {
        public const int DefaultPixelWidth = 8;
        public const int DefaultPixelHeight = 8;


        public PixelRenderParams(byte[] source, int bytesPerRow, int rows, Graphics graphics)
            : this(source, bytesPerRow, rows, graphics, 0, 0, DefaultPixelWidth, DefaultPixelHeight, Brushes.White, Brushes.Black)
        {

        }
        
        public PixelRenderParams(byte[] source, int bytesPerRow, int rows, Graphics graphics, int startX, int startY, int pixelWidth, int pixelHeight, Brush backGroundBrush, Brush pixelBrush)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));

            if (bytesPerRow < 1) throw new ArgumentException("bytesperrow must be nonzero positive integer", nameof(bytesPerRow));
            BytesPerRow = bytesPerRow;

            if (rows < 1) throw new ArgumentException("rows must be nonzero positive integer", nameof(rows));

            Rows = rows;
            Graphics = graphics ?? throw new ArgumentNullException(nameof(graphics));

            if (startX < 0) throw new ArgumentException("startX must be a positive integer", nameof(startX));
            StartX = startX;

            if (startY < 0) throw new ArgumentException("startY must be a positive integer", nameof(startY));
            StartY = startY;

            if (pixelWidth<1) throw new ArgumentException("pixelWidth must be nonzero positive integer", nameof(pixelWidth));
            PixelWidth = pixelWidth;

            if (pixelHeight < 1) throw new ArgumentException("pixelHeight must be nonzero positive integer", nameof(pixelHeight));
            PixelHeight = pixelHeight;

            BackGroundBrush = backGroundBrush ?? Brushes.White;
            PixelBrush = pixelBrush ?? Brushes.Black;
        }

        public byte[] Source { get; private set; }
        public int BytesPerRow { get; private set; }
        public int Rows { get; private set; }
        public Graphics Graphics { get; private set; }
        public int StartX { get; private set; }
        public int StartY { get; private set; }
        public int PixelWidth { get; private set; } = DefaultPixelWidth;
        public int PixelHeight { get; private set; } = DefaultPixelHeight;
        public Brush BackGroundBrush { get; private set; } = Brushes.White;
        public Brush PixelBrush { get; private set; } = Brushes.Black;
    }
}
