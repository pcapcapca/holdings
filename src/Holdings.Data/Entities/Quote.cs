using System;

namespace Holdings.Data.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public int BaseAssetId { get; set; }
        public int QuoteAssetId { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual Asset BaseAsset { get; set; }
        public virtual Asset QuoteAsset { get; set; }
    }
}
