using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using oanda_dotnet.model.transaction;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;


namespace oanda_dotnet.serialization
{
    public class ImplicitOperatorConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => HasImplicitConversion(objectType, typeof(string));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public static bool HasImplicitConversion(Type baseType, Type targetType)
        {
            return baseType.GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(mi => mi.Name == "op_Implicit" && mi.ReturnType == targetType)
                .Any(mi => {
                    ParameterInfo pi = mi.GetParameters().FirstOrDefault();
                    return pi != null && pi.ParameterType == baseType;
                });
        }
    }
}
