using RestSharp;
using System.Collections;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace oanda_dotnet.model
{
    public abstract class Restv20EndpointRequest
    {
        public abstract string Endpoint { get; }
        public abstract Method Method { get; }

        public bool IsValid()
        {
            return this.GetType().GetProperties()
                .Where(property =>
                    Attribute.IsDefined(property, typeof(RequiredAttribute)) &&
                    Nullable.GetUnderlyingType(property.PropertyType) != null)
                .All(property => property.GetValue(this) != null);
        }

        public IRestRequest GenerateRestRequest()
        {
            RestRequest restRequest = new RestRequest(this.Endpoint, this.Method);

            this.GetType().GetProperties()
                .Where(property =>
                    Attribute.IsDefined(property, typeof(EndpointParameterAttribute)) && //where is a request parameter
                        property.GetValue(this) != null)

                .ToList().ForEach(property =>
                {
                    EndpointParameterAttribute requestParameterAttribute = property.GetCustomAttribute<EndpointParameterAttribute>();
                    var value = property.GetValue(this);
                    if (value.GetType().GetInterface(nameof(ICollection)) != null)
                    {
                        value = string.Join(",", ConvertDynamicToString((ICollection)value));
                    }
                    restRequest.AddParameter(requestParameterAttribute.Name, value, requestParameterAttribute.Type);
                });

            return restRequest;
        }

        private static IEnumerable<string> ConvertDynamicToString(ICollection listOfObjects)
        {
            foreach (var item in listOfObjects)
            {
                yield return item.ToString();
            }
        }
    }
}
