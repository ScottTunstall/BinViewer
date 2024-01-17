using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinViewer
{
    public class ControlAreaToClipboard
    {
        public void CopyFrom(Control source, Point location, int width, int height)
        {
            using Image img = new Bitmap(width, height);
            using var g = Graphics.FromImage(img);
            g.CopyFromScreen(source.PointToScreen(location), new Point(0, 0), new Size(width, height));
            Clipboard.SetImage(img);
        }
    }
}
