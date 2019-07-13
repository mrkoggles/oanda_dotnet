using Newtonsoft.Json;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System.IO;
using Newtonsoft.Json.Serialization;
using System;

namespace oanda_dotnet.serialization
{
    internal class NewtonsoftJsonSerializer : ISerializer, IDeserializer
    {
        private Newtonsoft.Json.JsonSerializer _serializer;

        public NewtonsoftJsonSerializer(Newtonsoft.Json.JsonSerializer serializer)
        {
            this._serializer = serializer;
            this._serializer.Error += HandleDeserializationError;
        }

        public string ContentType
        {
            get =>"application/json";
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
            => Deserialize<T>(response.Content);

        public T Deserialize<T>(string response)
        {
            try
            {
                using (StringReader stringReader = new StringReader(response))
                using (JsonTextReader jsonTextReader = new JsonTextReader(stringReader))
                {
                    return _serializer.Deserialize<T>(jsonTextReader);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static NewtonsoftJsonSerializer Default
            => new NewtonsoftJsonSerializer(new Newtonsoft.Json.JsonSerializer()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });


        public void HandleDeserializationError(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorEventArgs)
        {
            if (IsHandled(errorEventArgs))
            {
                errorEventArgs.ErrorContext.Handled = true;
            }
        }

        private static bool IsHandled(Newtonsoft.Json.Serialization.ErrorEventArgs errorEventArgs)
            => IgnoreZeroAsDate(errorEventArgs);

        private static bool IgnoreZeroAsDate(Newtonsoft.Json.Serialization.ErrorEventArgs errorEventArgs)
        {
            //need logic to ignore if the value = 0 on a DateTime Field
            return true;
        }
    }
}
