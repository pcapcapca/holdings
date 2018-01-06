using System;

namespace Holdings.Data.Entities
{
    public class FiatWithdrawal
    {
        public int Id { get; set; }
        public int ExchangeId { get; set; }
        public DateTime Timestamp { get; set; }
        public int TokenId { get; set; }
        public decimal Value { get; set; }

        public virtual Exchange Exchange { get; set; }
        public virtual Token Token { get; set; }
    }
}
