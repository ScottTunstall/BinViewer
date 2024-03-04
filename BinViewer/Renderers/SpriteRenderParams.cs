namespace BinViewer.Renderers
{
    public record SpriteRenderParams(byte[] Source, int BytesPerRow, int Rows, Graphics Graphics, int StartX, int StartY, int PixelWidth, int PixelHeight, int PixelsPerByte, Color PixelColour)
    {
    }
}