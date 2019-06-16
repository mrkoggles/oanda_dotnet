using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that the Stop Order was initiated
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StopOrderReason
    {
        /// <summary>
        /// The Limit Order was initiated at the request of a client
        /// </summary>
        [EnumMember(Value = "CLIENT_ORDER")]
        ClientOrder,

        /// <summary>
        /// The Limit Order was initiated as a replacement for an existing Order
        /// </summary>
        [EnumMember(Value = "REPLACEMENT")]
        Replacement
    }
}