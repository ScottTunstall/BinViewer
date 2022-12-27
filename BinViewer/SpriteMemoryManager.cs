namespace BinViewer
{
    public class SpriteMemoryManager : IDisposable
    {
        private MemoryStream? _stream;

        public bool HasData => _stream is { Length: > 0 };

        public void Dispose()
        {
            FreeMemory();
        }


        public long FromFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(fileName));

            FreeMemory();
            _stream = new MemoryStream(File.ReadAllBytes(fileName));
            return _stream.Length;
        }

        public void Close()
        {
            if (_stream == null)
                throw new InvalidOperationException("Nothing loaded.");

            FreeMemory();
        }

        public bool TryGetBytes(int offset, int numberOfBytes, out byte[]? bytes)
        {
            if (_stream == null)
            {
                bytes = null;
                return false;
            }

            if (offset >= _stream.Length)
            {
                bytes = null;
                return false;
            }

            var buffer = new byte[numberOfBytes];
            _stream.Position = offset;
            _stream.Read(buffer, 0, numberOfBytes);

            bytes = buffer;
            return true;
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