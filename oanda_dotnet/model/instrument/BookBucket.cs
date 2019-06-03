using oanda_dotnet.model.pricing;

namespace oanda_dotnet.model.instrument
{
    /// <summary>
    /// The order/position book data for a partition of the instrument’s prices.
    /// </summary>
    public class BookBucket
    {
        /// <summary> 
        /// The lowest price (inclusive) covered by the bucket. The bucket covers the 
        /// price range from the price to price + the position book’s bucketWidth. 
        /// </summary> 
        public PriceValue Price { get; set; }

        /// <summary> 
        /// The percentage of the total number of orders/positions represented by the long 
        /// orders/positions found in this bucket. 
        /// </summary> 
        public decimal LongCountPercent { get; set; }

        /// <summary> 
        /// The percentage of the total number of orders/positions represented by the short 
        /// positions found in this bucket. 
        /// </summary> 
        public decimal ShortCountPercent { get; set; }
    }
}
