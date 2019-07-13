using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that the Market Order was created to perform a margin closeout
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketOrderMarginCloseoutReason
    {
        /// <summary>
        /// Trade closures resulted from violating OANDA’s margin policy
        /// </summary>
        [EnumMember(Value ="MARGIN_CHECK_VIOLATION")]
        MarginCheckViolation,

        /// <summary>
        /// Trade closures came from a margin closeout event resulting from regulatory conditions placed on the Account’s margin call
        /// </summary>
        [EnumMember(Value ="REGULATORY_MARGIN_CALL_VIOLATION")]
        RegulatoryMarginCallViolation
    }
}
