using Newtonsoft.Json;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System.IO;

namespace oanda_dotnet.serialization
{
    internal class NewtonsoftJsonSerializer : ISerializer, IDeserializer
    {
        private Newtonsoft.Json.JsonSerializer _serializer;

        public NewtonsoftJsonSerializer(Newtonsoft.Json.JsonSerializer serializer) { this._serializer = serializer; }

        public string ContentType
        {
            get => "application/json";
            set { }
        } 
        public string DateFormat { get; set; }
        public string Namespace { get; set; }
        public string RootElement { get; set; }

        public string Serialize(object obj)
        {
            using (StringWriter stringWriter = new StringWriter())
            using (JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter))
            {
                _serializer.Serialize(jsonTextWriter, obj);
                return stringWriter.ToString();
            }
        }

        public T Deserialize<T>(RestSharp.IRestResponse response)
        {
            using (StringReader stringReader = new StringReader(response.Content))
            using (JsonTextReader jsonTextReader = new JsonTextReader(stringReader))
            {
                return _serializer.Deserialize<T>(jsonTextReader);
            }
        }

        public static NewtonsoftJsonSerializer Default
            => new NewtonsoftJsonSerializer(new Newtonsoft.Json.JsonSerializer()
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
    }
}
