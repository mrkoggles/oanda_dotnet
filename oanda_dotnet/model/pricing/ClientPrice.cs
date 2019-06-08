using System.Collections.Generic;

namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// Client price for an Account.
    /// </summary>
    public class ClientPrice
    {
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
        public PriceValue CloseoutBid { get; set; }

        /// <summary> 
        /// The closeout ask Price. This Price is used when a ask is required to 
        /// closeout a Position (margin closeout or manual) yet there is no ask 
        /// liquidity. The closeout ask is never used to open a new position. 
        /// </summary> 
        public PriceValue CloseoutAsk { get; set; }

        /// <summary> 
        /// The date/time when the Price was created. 
        /// </summary> 
        public System.DateTime Timestamp { get; set; }
    }
}
