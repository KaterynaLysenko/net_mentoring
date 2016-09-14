using System;
using System.IO;

namespace NetMentoring
{
    public class MemoryStreamLogger : IDisposable
    {
        private FileStream _memoryStream;
        private StreamWriter _streamWriter;

        public MemoryStreamLogger()
        {
            _memoryStream = new FileStream(@"\log.txt", FileMode.OpenOrCreate);
            _streamWriter = new StreamWriter(_memoryStream);
        }

        public void Log(string message)
        {
            _streamWriter.WriteLine(message);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_streamWriter != null)
                {
                    _streamWriter.Dispose();
                    _streamWriter = null;
                }
                if (_memoryStream != null)
                {
                    _memoryStream.Dispose();
                    _memoryStream = null;
                }     
            }
        }
    }
}