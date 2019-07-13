using oanda_dotnet.client;
using oanda_dotnet.model;
using System.IO;
using System.Threading.Tasks;
using System;
using System.Text;

namespace oanda_dotnet.api
{
    public abstract class StreamApi<T> : IDisposable
        where T : StreamEndpointRequest<T>, new()
    {
        private Task<Stream> _retrieveStreamTask;
        private Stream _stream;
        private StreamReader _streamReader;

        private Stream Stream
        {
            get
            {
                if(_stream == null) { _stream = _retrieveStreamTask.Result; }
                return _stream;
            }
        }

        private StreamReader StreamReader
        {
            get
            {
                if (_streamReader == null) { _streamReader = new StreamReader(Stream, Encoding.UTF8, true, 1024, true); }
                return _streamReader;
            }
        }

        public string Response
        {
            get
            {
                string _response = null;
                while (StreamReader.Peek() != -1)  //.Peek() returns -1 when there is currently nothing to read
                {
                    var currentValue = StreamReader.ReadLine();
                    if (true) { _response = currentValue; } //replace with logic to make sure not a heartbeat object                    
                }
                return _response;
            }
        }

        public StreamApi(StreamClient client, StreamEndpointRequest<T> request)
        {
            _retrieveStreamTask = client.Execute(request);
        }

        public void Dispose()
        {
            _stream.Dispose();
            _streamReader?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
