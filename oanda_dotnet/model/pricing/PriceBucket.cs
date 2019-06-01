namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// A Price Bucket represents a price available for an amount of liquidity
    /// </summary>
    public class PriceBucket
    {
        /// <summary> 
        /// The Price offered by the PriceBucket 
        /// </summary> 
        public PriceValue Price { get; set; }

        /// <summary> 
        /// The amount of liquidity offered by the PriceBucket 
        /// </summary> 
        public int Liquidity { get; set; }
    }
}