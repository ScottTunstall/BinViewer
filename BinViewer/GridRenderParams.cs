using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinViewer
{
    public class GridRenderParams
    {
        public GridRenderParams(Graphics graphics, int startX, int startY, int columns, int rows, int cellsPerColumn, int cellWidth, int cellHeight, Pen cellPen)
        {

            Graphics = graphics ?? throw new ArgumentNullException(nameof(graphics));

            if (startX < 0) throw new ArgumentOutOfRangeException(nameof(startX));
            StartX = startX;

            if (startY < 0) throw new ArgumentOutOfRangeException(nameof(startY));
            StartY = startY;

            if (columns <= 0) throw new ArgumentOutOfRangeException(nameof(columns));
            Columns = columns;

            if (rows <= 0) throw new ArgumentOutOfRangeException(nameof(rows));
            Rows = rows;

            if (cellWidth <= 0) throw new ArgumentOutOfRangeException(nameof(cellWidth));
            CellWidth = cellWidth;

            if (cellHeight <= 0) throw new ArgumentOutOfRangeException(nameof(cellHeight));
            CellHeight = cellHeight;

            if (cellsPerColumn <= 0) throw new ArgumentOutOfRangeException(nameof(cellsPerColumn));
            CellsPerColumn = cellsPerColumn;

            CellPen = cellPen ?? throw new ArgumentNullException(nameof(cellPen));
        }


        public Graphics Graphics { get; private set; }
        public int StartX { get; init; }
        public int StartY { get; init; }
        public int Columns { get; init; }
        public int Rows { get; init; }

        public int CellsPerColumn { get; set; }
        public int CellWidth { get; init; }
        public int CellHeight { get; init; }

        public Pen CellPen { get; init; }
    }
}
