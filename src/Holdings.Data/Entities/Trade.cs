using System;

namespace Holdings.Data.Entities
{
    public class Trade
    {
        public int Id { get; set; }
        public decimal Commission { get; set; }
        public int ExchangeId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime Timestamp { get; set; }
        public int BaseAssetId { get; set; }
        public int QuoteAssetId { get; set; }

        public virtual Exchange Exchange { get; set; }
        public virtual Asset BaseAsset { get; set; }
        public virtual Asset QuoteAsset { get; set; }
    }
}
