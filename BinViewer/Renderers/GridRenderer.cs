namespace BinViewer.Renderers
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
            var gridTotalWidthInPixels = _renderParams.CellWidth * _renderParams.Columns * _renderParams.CellsPerColumn;
            var gridTotalHeightInPixels = _renderParams.CellHeight * _renderParams.Rows;

            using var gridCellPen = new Pen(_renderParams.CellColour);

            graphics.DrawRectangle(gridCellPen, _renderParams.StartX, _renderParams.StartY, gridTotalWidthInPixels, gridTotalHeightInPixels);

            var y = _renderParams.StartY + _renderParams.CellHeight;
            for (int i = 0; i < _renderParams.Rows - 1; i++)
            {
                graphics.DrawLine(gridCellPen, _renderParams.StartX, y, _renderParams.StartX + gridTotalWidthInPixels, y);
                y += _renderParams.CellHeight;
            }

            var x = _renderParams.StartX + _renderParams.CellWidth;
            for (int j = 0; j < _renderParams.Columns * _renderParams.CellsPerColumn - 1; j++)
            {
                graphics.DrawLine(gridCellPen, x, _renderParams.StartY, x, _renderParams.StartY + gridTotalHeightInPixels);
                x += _renderParams.CellWidth;
            }
        }
    }
}