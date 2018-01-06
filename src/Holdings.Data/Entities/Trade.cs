using System;

namespace Holdings.Data.Entities
{
    public class Trade
    {
        public int Id { get; set; }
        public int ExchangeId { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }
        public int TokenFromId { get; set; }
        public int TokenToId { get; set; }

        public virtual Exchange Exchange { get; set; }
        public virtual Token TokenFrom { get; set; }
        public virtual Token TokenTo { get; set; }
    }
}
