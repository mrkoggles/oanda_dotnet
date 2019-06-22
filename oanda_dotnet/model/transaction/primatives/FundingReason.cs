using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that an Account is being funded.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FundingReason
    {
        /// <summary>
        /// The client has initiated a funds transfer
        /// </summary>
        [EnumMember(Value ="CLIENT_FUNDING")]
        ClientFunding,

        /// <summary>
        /// Funds are being transfered between two Accounts.
        /// </summary>
        [EnumMember(Value ="ACCOUNT_TRANSFER")]
        AccountTransfer,

        /// <summary>
        /// Funds are being transfered as part of a Division migration
        /// </summary>
        [EnumMember(Value ="DIVISION_MIGRATION")]
        DivisionMigration,

        /// <summary>
        /// Funds are being transfered as part of a Site migration
        /// </summary>
        [EnumMember(Value ="SITE_MIGRATION")]
        SiteMigration,

        /// <summary>
        /// Funds are being transfered as part of an Account adjustment
        /// </summary>
        [EnumMember(Value ="ADJUSTMENT")]
        Adjustment
    }
}
