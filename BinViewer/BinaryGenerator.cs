using System.Text;

namespace BinViewer
{
    public class BinaryGenerator
    {
        public string FromBytes(byte[] data, int startAddress, int numberOfHexDigitsForAddress, int bytesPerRow, int numRows, string separator)
        {
            int dataOffset = 0;
            int currentAddress = startAddress;

            StringBuilder sb = new();
            for (int i = 0; i < numRows; i++)
            {
                var currentAddressAsHex = GenerateHexAddress(currentAddress, numberOfHexDigitsForAddress);
                sb.Append(currentAddressAsHex);
                sb.Append(":\t");
                var binaryAsString = GenerateBinaryForRow(data, dataOffset, bytesPerRow, separator);
                sb.AppendLine(binaryAsString);
                currentAddress += (int)bytesPerRow;
                dataOffset += bytesPerRow;
            }
            return sb.ToString();
        }

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

        private string GenerateHexAddress(int address, int numberOfHexDigitsForAddress)
        {
            return address.ToString("X").PadLeft(numberOfHexDigitsForAddress, '0');
        }

        private string GenerateBinaryForRow(byte[] data, int dataOffset, int bytesPerRow, string separator)
        {
            const int binaryDigitsPerByte = 8;

            List<string> binaryStrings = new();
            for (int i = dataOffset; i < dataOffset + bytesPerRow; i++)
            {
                var asBinary = Convert.ToString(data[i], 2).PadLeft(binaryDigitsPerByte, '0');
                binaryStrings.Add(asBinary);
            }

            return string.Join(separator, binaryStrings);
        }
    }
}