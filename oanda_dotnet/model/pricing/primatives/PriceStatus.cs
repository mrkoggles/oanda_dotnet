using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// The status of the Price.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriceStatus
    {
        /// <summary>
        /// The Instrument of the price is invalid or there is no valid Price for the Instrument.
        /// </summary>
        [EnumMember(Value ="invalid")]
        Invalid,

        /// <summary>
        /// The Instrument’s price is not tradeable.
        /// </summary>
        [EnumMember(Value ="non-tradeable")]
        NonTradeable,

        /// <summary>
        /// The Instrument’s price is tradeable.
        /// </summary>
        [EnumMember(Value ="tradeable")]
        Tradeable
    }
}