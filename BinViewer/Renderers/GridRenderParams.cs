namespace BinViewer.Renderers
{
    public record GridRenderParams(Graphics Graphics, int StartX, int StartY, int Columns, int Rows, int CellsPerColumn, int CellWidth, int CellHeight, Color CellColour)
    {
    }
}