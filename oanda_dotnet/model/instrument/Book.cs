using oanda_dotnet.model.pricing;
using System.Collections.Generic;

namespace oanda_dotnet.model.instrument
{
    /// <summary>
    /// The representation of an instrument’s order/position book at a point in time
    /// </summary>
    public class Book
    {
        /// <summary> 
        /// The order/position book’s instrument 
        /// </summary> 
        public InstrumentName Instrument { get; set; }

        /// <summary> 
        /// The time when the order/position book snapshot was created. 
        /// </summary> 
        public System.DateTime Time { get; set; }

        /// <summary> 
        /// The price (midpoint) for the order/position book’s instrument at the time of the 
        /// order/position book snapshot 
        /// </summary> 
        public PriceValue? Price { get; set; }

        /// <summary> 
        /// The price width for each bucket. Each bucket covers the price range from 
        /// the bucket’s price to the bucket’s price + bucketWidth. 
        /// </summary> 
        public PriceValue? BucketWidth { get; set; }

        /// <summary> 
        /// The partitioned order/position book, divided into buckets using a default bucket 
        /// width. These buckets are only provided for price ranges which actually 
        /// contain order or position data. 
        /// </summary> 
        public ICollection<BookBucket> Buckets { get; set; }
    }
}
