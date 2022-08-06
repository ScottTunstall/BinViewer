using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinViewer
{
    public class BinaryGenerator
    {

        public string FromBytes(byte[] data, int bytesPerRow, int numRows, string separator)
        {
            int dataOffset = 0;
            StringBuilder sb = new();
            for (int i = 0; i < numRows; i++)
            {
                var binaryAsString = GenerateBinaryForRow(data, dataOffset, bytesPerRow, separator);
                sb.AppendLine(binaryAsString);
                dataOffset += bytesPerRow;
            }
            return sb.ToString();
        }

        private string GenerateBinaryForRow(byte[] data, int dataOffset, int bytesPerRow, string separator)
        {
            List<string> binaryStrings = new();
            for (int i = dataOffset; i < dataOffset + bytesPerRow; i++)
            {
                var readByte = data[i];
                var asBinary = Convert.ToString(readByte, 2).PadLeft(8, '0');
                binaryStrings.Add(asBinary);
            }

            return string.Join(separator, binaryStrings);
        }
    }
}
