using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that the Stop Loss Order was initiated
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StopLossOrderReason
    {
        /// <summary>
        /// The Stop Loss Order was initiated at the request of a client
        /// </summary>
        [EnumMember(Value ="CLIENT_ORDER")]
        ClientOrder,

        /// <summary>
        /// The Stop Loss Order was initiated as a replacement for an existing Order
        /// </summary>
        [EnumMember(Value ="REPLACEMENT")]
        Replacement,

        /// <summary>
        /// The Stop Loss Order was initiated automatically when an Order was filled that opened a new Trade requiring a Stop Loss Order.
        /// </summary>
        [EnumMember(Value ="ON_FILL")]
        OnFill
    }
}
