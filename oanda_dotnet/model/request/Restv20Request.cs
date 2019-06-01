using RestSharp;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace oanda_dotnet.model
{
    public abstract class Restv20Request
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
                    Attribute.IsDefined(property, typeof(RequestParameterAttribute)) && //where is a request parameter
                    (Nullable.GetUnderlyingType(property.PropertyType) == null ||  //and is either isn't nullable or is nullable and not null
                        (Nullable.GetUnderlyingType(property.PropertyType) == null &&
                        property.GetValue(this) != null)))

                .ToList().ForEach(property =>
                {
                    RequestParameterAttribute requestParameterAttribute = property.GetCustomAttribute<RequestParameterAttribute>();
                    restRequest.AddParameter(requestParameterAttribute.Name, property.GetValue(this), requestParameterAttribute.Type);
                });

            return restRequest;
        }
    }
}
