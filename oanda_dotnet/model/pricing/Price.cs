using oanda_dotnet.model.order;
using System;
using System.Collections.Generic;

namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// The specification of an Account-specific Price.
    /// </summary>
    public class Price
    {
        /// <summary> 
        /// The string “PRICE”. Used to identify the a Price object when found in a 
        /// stream. 
        /// </summary> 
        public const string Type ="PRICE";

        /// <summary> 
        /// The Price’s Instrument. 
        /// </summary> 
        public InstrumentName Instrument { get; set; }

        /// <summary> 
        /// The date/time when the Price was created 
        /// </summary> 
        public System.DateTime Time { get; set; }

        /// <summary> 
        /// The status of the Price. 
        /// </summary> 
        [Obsolete(@"Deprecated: Will be removed in a future API update.", false)]
        public PriceStatus Status { get; set; }

        /// <summary> 
        /// Flag indicating if the Price is tradeable or not 
        /// </summary> 
        public bool Tradeable { get; set; }

        /// <summary> 
        /// The list of prices and liquidity available on the Instrument’s bid side. 
        /// It is possible for this list to be empty if there is no bid liquidity 
        /// currently available for the Instrument in the Account. 
        /// </summary> 
        public ICollection<PriceBucket> Bids { get; set; }

        /// <summary> 
        /// The list of prices and liquidity available on the Instrument’s ask side. 
        /// It is possible for this list to be empty if there is no ask liquidity 
        /// currently available for the Instrument in the Account. 
        /// </summary> 
        public ICollection<PriceBucket> Asks { get; set; }

        /// <summary> 
        /// The closeout bid Price. This Price is used when a bid is required to 
        /// closeout a Position (margin closeout or manual) yet there is no bid 
        /// liquidity. The closeout bid is never used to open a new position. 
        /// </summary> 
        public PriceValue? CloseoutBid { get; set; }

        /// <summary> 
        /// The closeout ask Price. This Price is used when a ask is required to 
        /// closeout a Position (margin closeout or manual) yet there is no ask 
        /// liquidity. The closeout ask is never used to open a new position. 
        /// </summary> 
        public PriceValue? CloseoutAsk { get; set; }

        /// <summary> 
        /// The factors used to convert quantities of this price’s Instrument’s quote 
        /// currency into a quantity of the Account’s home currency. When the 
        /// includeHomeConversions is present in the pricing request (regardless of 
        /// its value), this field will not be present. 
        /// </summary> 
        [Obsolete(@"Deprecated: Will be removed in a future API update.", false)]
        public QuoteHomeConversionFactors QuoteHomeConversionFactors { get; set; }

        /// <summary> 
        /// Representation of how many units of an Instrument are available to be 
        /// traded by an Order depending on its postionFill option. 
        /// </summary> 
        [Obsolete(@"Deprecated: Will be removed in a future API update.", false)]
        public UnitsAvailable UnitsAvailable { get; set; }
    }
}
