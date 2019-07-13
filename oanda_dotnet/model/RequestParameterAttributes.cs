using RestSharp;
using System;

namespace oanda_dotnet.model
{
    public class EndpointParameterAttribute : Attribute
    {
        public string Name { get; set; }
        public ParameterType Type { get; set; }        
    }
}
