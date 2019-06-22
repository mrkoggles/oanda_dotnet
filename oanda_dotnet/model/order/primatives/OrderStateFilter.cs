using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The current state of the Order.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderStateFilter
    {
        /// <summary>
        /// The Order is currently pending execution
        /// </summary>
        [EnumMember(Value ="PENDING")]
        Pending,

        /// <summary>
        /// The Order has been filled
        /// </summary>
        [EnumMember(Value ="FILLED")]
        Filled,

        /// <summary>
        /// The Order has been triggered
        /// </summary>
        [EnumMember(Value ="TRIGGERED")]
        Triggered,

        /// <summary>
        /// The Order has been cancelled
        /// </summary>
        [EnumMember(Value ="CANCELLED")]
        Cancelled,

        /// <summary>
        /// The Orders that are in any of the possible states listed above
        /// </summary>
        [EnumMember(Value ="ALL")]
        All,

    }
}
