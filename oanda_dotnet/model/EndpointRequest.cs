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
    public abstract class EndpointRequest
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

        protected static IEnumerable<string> ConvertDynamicToString(ICollection listOfObjects)
        {
            foreach (var item in listOfObjects)
            {
                yield return (item.GetType().IsEnum ? GetEnumValue((Enum)item) : item.ToString());
            }
        }

        protected static string GetEnumValue<T>(T enumMember)
            where T : Enum
                => enumMember.GetType().GetMember(enumMember.ToString()).FirstOrDefault().GetCustomAttribute<EnumMemberAttribute>().Value;
    }
}
