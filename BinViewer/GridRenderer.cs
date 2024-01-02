using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinViewer
{
    public class GridRenderer
    {
        private readonly GridRenderParams _renderParams;

        public GridRenderer(GridRenderParams gridRendererParams)
        {
            _renderParams = gridRendererParams;
        }

        public void Render()
        {
            var graphics = _renderParams.Graphics;
            var gridTotalWidthInPixels = _renderParams.CellWidth * _renderParams.Columns;
            var gridTotalHeightInPixels = _renderParams.CellHeight * _renderParams.Rows;

            graphics.DrawRectangle(_renderParams.CellPen, _renderParams.StartX, _renderParams.StartY, gridTotalWidthInPixels, gridTotalHeightInPixels);

            var y = _renderParams.StartY+_renderParams.CellHeight;
            for (int i = 0; i < _renderParams.Rows-1; i++)
            {
                graphics.DrawLine(_renderParams.CellPen, _renderParams.StartX, y, _renderParams.StartX+gridTotalWidthInPixels, y);
                y += _renderParams.CellHeight;
            }

            var x = _renderParams.StartX+_renderParams.CellWidth;
            for (int j = 0; j < _renderParams.Columns-1; j++)
            {
                graphics.DrawLine(_renderParams.CellPen, x, _renderParams.StartY, x, _renderParams.StartY + gridTotalHeightInPixels);
                x += _renderParams.CellWidth;
            }
        }
    }
}
