using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// Specification of how Positions in the Account are modified when the Order is filled.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderPositionFill
    {
        /// <summary>
        /// When the Order is filled, only allow Positions to be opened or extended.
        /// </summary>
        [EnumMember(Value ="OPEN_ONLY")]
        OpenOnly,

        /// <summary>
        /// When the Order is filled, always fully reduce an existing Position before opening a new Position.
        /// </summary>
        [EnumMember(Value ="REDUCE_FIRST")]
        ReduceFirst,

        /// <summary>
        /// When the Order is filled, only reduce an existing Position.
        /// </summary>
        [EnumMember(Value ="REDUCE_ONLY")]
        ReduceOnly,

        /// <summary>
        /// When the Order is filled, use REDUCE_FIRST behaviour for non-client hedging Accounts, and OPEN_ONLY behaviour for client hedging Accounts.
        /// </summary>
        [EnumMember(Value ="DEFAULT")]
        Default
    }
}
