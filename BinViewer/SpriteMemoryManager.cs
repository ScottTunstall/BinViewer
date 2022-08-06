using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinViewer
{
    public class SpriteMemoryManager: IDisposable
    {
        private MemoryStream? _stream;
        
        public bool HasData => _stream is { Length: > 0 };

        public void Dispose()
        {
            FreeMemory();
        }

        public void FromFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(fileName));
            
            FreeMemory();
            _stream = new MemoryStream(File.ReadAllBytes(fileName));
        }

        public void Close()
        {
            if (_stream == null)
                throw new InvalidOperationException("Nothing loaded."); 

            FreeMemory();
        }

        public byte[] GetBytes(int offset, int numberOfBytes)
        {
            if (_stream == null)
                throw new InvalidOperationException("Nothing loaded.");

            var buffer = new byte[numberOfBytes];

            _stream.Position = offset;
            _stream.Read(buffer, 0, numberOfBytes);

            return buffer;
        }

        private void FreeMemory()
        {
            _stream?.Dispose();
            _stream = null;
        }


    }
}
