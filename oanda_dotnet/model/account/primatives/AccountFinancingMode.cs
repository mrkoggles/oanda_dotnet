using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.account
{
    /// <summary>
    /// The financing mode of an Account
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountFinancingMode
    {
        /// <summary>
        /// No financing is paid/charged for open Trades in the Account
        /// </summary>
        [EnumMember(Value = "NO_FINANCING")]
        NoFinancing,

        /// <summary>
        /// Second-by-second financing is paid/charged for open Trades in the Account, both daily and when the the Trade is closed
        /// </summary>
        [EnumMember(Value = "SECOND_BY_SECOND")]
        SecondBySecond,

        /// <summary>
        /// A full day’s worth of financing is paid/charged for open Trades in the Account daily at 5pm New York time
        /// </summary>
        [EnumMember(Value = "DAILY")]
        Daily
    }
}
