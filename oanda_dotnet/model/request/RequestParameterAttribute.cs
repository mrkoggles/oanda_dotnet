using RestSharp;
using System;

namespace oanda_dotnet.model
{
    public class RequestParameterAttribute : Attribute
    {
        public string Name { get; set; }
        public ParameterType Type { get; set; }        
    }
}
