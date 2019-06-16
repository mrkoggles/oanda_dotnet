using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that the Fixed Price Order was created
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FixedPriceOrderReason
    {
        /// <summary>
        /// The Fixed Price Order was created as part of a platform account migration
        /// </summary>
        [EnumMember(Value = "PLATFORM_ACCOUNT_MIGRATION")]
        PlatformAccountMigration
    }
}