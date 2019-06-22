using oanda_dotnet.model.account;
using oanda_dotnet.model.transaction;
using RestSharp;
using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.position
{
    public abstract class PositionRestv20EndpointRequest : Restv20EndpointRequest { }

    /// <summary>
    /// List all Positions for an Account. The Positions returned are for every instrument that has had a position during the lifetime of an the Account.
    /// </summary>
    public sealed class GetPositionsEndpoint : PositionRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/positions";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }
    }


    /// <summary>
    /// List all open Positions for an Account. An open Position is a Position in an Account that currently has a Trade opened for it.
    /// </summary>
    public sealed class GetOpenPositionsEndpoint : PositionRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/openPositions";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }
    }


    /// <summary>
    /// Get the details of a single Instrument’s Position in an Account. The Position may by open or not.
    /// </summary>
    public sealed class GetInstrumentPositionEndpoint : PositionRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/positions/{instrument}";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// Name of the Instrument
        /// </summary>
        [Required]
        [EndpointParameter(Name = "instrument", Type = ParameterType.UrlSegment)]
        public InstrumentName? Instrument { get; set; }
    }


    /// <summary>
    /// Closeout the open Position for a specific instrument in an Account.
    /// </summary>
    public sealed partial class CloseInstrumentPositionEndpoint : PositionRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/positions/{instrument}/close";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// Format of DateTime fields in the request and response. 
        /// </summary>
        [Required]
        [EndpointParameter(Name = "Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
        public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


        /// <summary>
        /// Name of the Instrument
        /// </summary>
        [Required]
        [EndpointParameter(Name = "instrument", Type = ParameterType.UrlSegment)]
        public InstrumentName? Instrument { get; set; }


        /// <summary>
        /// Request Data for the Body
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public RequestInfo RequestData { get; set; }
    }



    /// <summary>
    /// Dependencies for the CloseInstrumentPositionRequest
    /// </summary>
    public sealed partial class CloseInstrumentPositionEndpoint
    {
        [Obsolete("Needs error handling")]
        [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
        public struct CloseOutUnits
        {
            private CloseOutMethod? _closeOutMethod;
            private decimal? _closeOutAmount;

            private CloseOutMethod? CloseOutMethod
            {
                get => _closeOutMethod;
                set
                {
                    if (value != null)
                    {
                        _closeOutMethod = value;
                        _closeOutAmount = null;
                    }
                }
            }

            private decimal? CloseOutAmount
            {
                get => _closeOutAmount;
                set
                {
                    if (value != null)
                    {
                        _closeOutMethod = null;
                        _closeOutAmount = value;
                    }
                }
            }



            public static implicit operator CloseOutMethod? (CloseOutUnits closeOutUnits) => closeOutUnits.CloseOutMethod;
            public static implicit operator decimal? (CloseOutUnits closeOutUnits) => closeOutUnits.CloseOutAmount;
            public static implicit operator string(CloseOutUnits closeOutUnits)
            {
                if (closeOutUnits.CloseOutMethod != null) { return Enum.GetName(typeof(CloseOutUnits), closeOutUnits.CloseOutMethod.Value).ToUpper(); }
                else if (closeOutUnits.CloseOutAmount != null) { return closeOutUnits.CloseOutAmount.Value.ToString(); }
                else { throw new Exception(); }
            }

            public static implicit operator CloseOutUnits(CloseOutMethod closeOutMethod) => new CloseOutUnits() { CloseOutMethod = closeOutMethod };
            public static implicit operator CloseOutUnits(decimal closeOutAmount) => new CloseOutUnits() { CloseOutAmount = closeOutAmount };
            public static implicit operator CloseOutUnits(string closeOutUnits)
            {
                if (decimal.TryParse(closeOutUnits, out decimal result)) { return new CloseOutUnits() { CloseOutAmount = result }; }
                else if (Enum.TryParse(closeOutUnits, out CloseOutMethod closeOutMethod)) { return new CloseOutUnits() { CloseOutMethod = closeOutMethod }; }
                else { throw new Exception(); }
            }
        }

        public enum CloseOutMethod
        {
            All,
            None
        }

        public class RequestInfo
        {
            /// <summary> 
            /// Indication of how much of the long Position to closeout. Either the 
            /// string “ALL”, the string “NONE”, or a DecimalNumber representing how many 
            /// units of the long position to close using a PositionCloseout MarketOrder. 
            /// The units specified must always be positive. 
            /// </summary> 
            public CloseOutUnits LongUnits { get; set; } = CloseOutMethod.All;

            /// <summary> 
            /// The client extensions to add to the MarketOrder used to close the long 
            /// position. 
            /// </summary> 
            public ClientExtensions LongClientExtensions { get; set; }

            /// <summary> 
            /// Indication of how much of the short Position to closeout. Either the 
            /// string “ALL”, the string “NONE”, or a DecimalNumber representing how many 
            /// units of the short position to close using a PositionCloseout 
            /// MarketOrder. The units specified must always be positive. 
            /// </summary> 
            public CloseOutUnits ShortUnits { get; set; } = CloseOutMethod.All;

            /// <summary> 
            /// The client extensions to add to the MarketOrder used to close the short 
            /// position. 
            /// </summary> 
            public ClientExtensions ShortClientExtensions { get; set; }
        }
    }
}
