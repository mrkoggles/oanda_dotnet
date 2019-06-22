using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model
{
    /// <summary>
    /// The type of an Instrument.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstrumentType
    {
        /// <summary>
        /// Currency
        /// </summary>
        [EnumMember(Value ="CURRENCY")]
        Currency,

        /// <summary>
        /// Contract For Difference
        /// </summary>
        [EnumMember(Value ="CFD")]
        CFD,

        /// <summary>
        /// Metal
        /// </summary>
        [EnumMember(Value ="METAL")]
        Metal
    }
}
