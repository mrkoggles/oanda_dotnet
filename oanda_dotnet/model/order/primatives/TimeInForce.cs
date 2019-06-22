using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The time-in-force of an Order. 
    /// TimeInForce describes how long an Order should remain pending before being automatically cancelled by the execution system.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeInForce
    {
        /// <summary>
        /// The Order is “Good unTil Cancelled”
        /// </summary>
        [EnumMember(Value ="GTC")]
        GTC,

        /// <summary>
        /// The Order is “Good unTil Date” and will be cancelled at the provided time
        /// </summary>
        [EnumMember(Value ="GTD")]
        GTD,

        /// <summary>
        /// The Order is “Good For Day” and will be cancelled at 5pm New York time
        /// </summary>
        [EnumMember(Value ="GFD")]
        GFD,

        /// <summary>
        /// The Order must be immediately “Filled Or Killed”
        /// </summary>
        [EnumMember(Value ="FOK")]
        FOK,

        /// <summary>
        /// The Order must be “Immediatedly paritally filled Or Cancelled”
        /// </summary>
        [EnumMember(Value ="IOC")]
        IOC
    }
}
