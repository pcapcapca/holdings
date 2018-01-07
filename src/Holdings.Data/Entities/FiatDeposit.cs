using System;

namespace Holdings.Data.Entities
{
    public class FiatDeposit
    {
        public int Id { get; set; }
        public int ExchangeId { get; set; }
        public int AssetId { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Value { get; set; }

        public virtual Exchange Exchange { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
