namespace BinViewer
{
    public class SpriteMemoryManager : IDisposable
    {
        private MemoryStream? _stream;

        public bool HasData => _stream is { Length: > 0 };


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Suppress finalization if Dispose was called
        }

        // Protected virtual method to dispose of managed and unmanaged resources
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                FreeMemory();
            }
        }
        

        public long Load(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(fileName));

            if (!File.Exists(fileName))
                throw new FileNotFoundException($"{nameof(Load)}: the file {fileName} does not exist.", fileName);

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

        public bool TryGetBytes(long offset, int numberOfBytes, out byte[]? bytes)
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

        public byte[] GetBytes(long offset, int numberOfBytes)
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