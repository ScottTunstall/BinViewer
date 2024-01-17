using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinViewer
{
    public record GridRenderParams(Graphics Graphics, int StartX, int StartY, int Columns, int Rows, int CellsPerColumn, int CellWidth, int CellHeight, Pen CellPen)
    {
    }
}
