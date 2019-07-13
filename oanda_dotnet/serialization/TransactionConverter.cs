using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using oanda_dotnet.model.transaction;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace oanda_dotnet.serialization
{
    public class TransactionConverter : JsonConverter
    {
        [Obsolete("Not Implemented")]
        public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Transaction));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject transactionJObject = JObject.Load(reader);
            TransactionType transactionType = GetTransactionTypeEnumMember(transactionJObject.Value<string>("type"));
            Type realObjectType = GetTransactionObjectType(transactionType);
            Transaction transaction = (Transaction)Activator.CreateInstance(realObjectType);
            serializer.Populate(transactionJObject.CreateReader(), transaction);
            return transaction;
        }

        public static TransactionType GetTransactionTypeEnumMember(string enumName)
        {
            return typeof(TransactionType)
                .GetEnumValues().Cast<TransactionType>()
                .ToDictionary(
                    f => f,
                    f => typeof(TransactionType).GetField(f.ToString()).GetCustomAttribute<EnumMemberAttribute>().Value)
                .FirstOrDefault(kvp => kvp.Value == enumName).Key;
        }

        public static Type GetTransactionObjectType(TransactionType transactionType)
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(Transaction).IsAssignableFrom(t) && !t.IsAbstract)
                .FirstOrDefault(t => (TransactionType)t.GetProperty("Type").GetValue((Transaction)Activator.CreateInstance(t)) == transactionType);
        }


        [Obsolete("Not Implemented")]
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
