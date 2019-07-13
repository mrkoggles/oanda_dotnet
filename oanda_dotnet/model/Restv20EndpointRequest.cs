using oanda_dotnet.serialization;
using RestSharp;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace oanda_dotnet.model
{
    public abstract class Restv20EndpointRequest : EndpointRequest
    {
        public IRestRequest GenerateRestRequest()
        {
            RestRequest restRequest = new RestRequest(this.Endpoint, this.Method);
            restRequest.JsonSerializer = NewtonsoftJsonSerializer.Default;

            this.GetType().GetProperties()
                .Where(property =>
                    Attribute.IsDefined(property, typeof(EndpointParameterAttribute)) && //where is a request parameter
                        property.GetValue(this) != null)

                .ToList().ForEach(property =>
                {
                    EndpointParameterAttribute requestParameterAttribute = property.GetCustomAttribute<EndpointParameterAttribute>();
                    var value = property.GetValue(this);
                    if (value.GetType().IsEnum) { value = GetEnumValue((Enum)value); };
                    if (value.GetType().GetInterface(nameof(ICollection)) != null) { value = string.Join(",", ConvertDynamicToString((ICollection)value)); }
                    if (requestParameterAttribute.Type == ParameterType.RequestBody)
                    {
                        restRequest.AddJsonBody(value);
                    }
                    else
                    {
                        restRequest.AddParameter(requestParameterAttribute.Name, value, requestParameterAttribute.Type);
                    }                    
                });

            return restRequest;
        }
    }
}
