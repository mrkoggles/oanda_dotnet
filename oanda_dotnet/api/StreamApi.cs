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
        private Stream _stream;
        private Task<Stream> _retrieveStreamTask;
        private StreamReader _streamReader;
        private StreamClient _client;
        public StreamEndpointRequest<T> Request { get; private set; }

        public string Response
        {
            get
            {
                if (_streamReader == null)
                {
                    _stream = _retrieveStreamTask.Result;
                    _streamReader = new StreamReader(_stream, Encoding.UTF8, true, 1024, true);
                }

                string _response = null;
                while (_streamReader.Peek() != -1)  //.Peek() returns -1 when there is currently nothing to read
                {
                    var currentValue = _streamReader.ReadLine();
                    if (true) { _response = currentValue; } //replace with logic to make sure not a heartbeat object                    
                }
                return _response;
            }
        }

        public StreamApi(StreamClient client, StreamEndpointRequest<T> request) { }

        public void Dispose()
        {
            _stream?.Dispose();
            _streamReader?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
