using oanda_dotnet.serialization;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

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

        private static IEnumerable<string> ConvertDynamicToString(ICollection listOfObjects)
        {
            foreach (var item in listOfObjects)
            {
                yield return (item.GetType().IsEnum ? GetEnumValue((Enum)item) : item.ToString());
            }
        }

        private static string GetEnumValue<T>(T enumMember)
            where T : Enum
                => enumMember.GetType().GetMember(enumMember.ToString()).FirstOrDefault().GetCustomAttribute<EnumMemberAttribute>().Value;

            
        
    }
}
