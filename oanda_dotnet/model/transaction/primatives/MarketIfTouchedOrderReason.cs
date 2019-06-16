using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that the Market-if-touched Order was initiated
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketIfTouchedOrderReason
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