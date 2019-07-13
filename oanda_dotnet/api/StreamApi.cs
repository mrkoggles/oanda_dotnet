using oanda_dotnet.client;
using oanda_dotnet.model;
using System.IO;
using System.Threading.Tasks;
using System;
using System.Text;
using oanda_dotnet.serialization;

namespace oanda_dotnet.api
{
    public abstract class StreamApi<T> : IDisposable
    {
        private readonly Task<Stream> _retrieveStreamTask;
        private Stream _stream;
        private StreamReader _streamReader;

        private Stream Stream
        {
            get
            {
                if (_stream == null) { _stream = _retrieveStreamTask.Result; }
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

        public T Response
        {
            get
            {
                string _response = null;
                while (StreamReader.Peek() != -1)  //.Peek() returns -1 when there is currently nothing to read
                {
                    string currentValue = StreamReader.ReadLine();
                    if (!Heartbeat.ResponseIsHeartBeat(currentValue))
                    {
                        _response = currentValue;
                    }            
                }
                return NewtonsoftJsonSerializer.Default.Deserialize<T>(_response);
            }
        }

        protected StreamApi(StreamClient client, StreamEndpointRequest<T> request)
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
