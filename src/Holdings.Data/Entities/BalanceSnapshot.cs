using System;

namespace Holdings.Data.Entities
{
    public class BalanceSnapshot
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public DateTime Timestamp { get; set; }
        public int TokenId { get; set; }
        public decimal Value { get; set; }

        public virtual Store Store { get; set; }
        public virtual Token Token { get; set; }
    }
}
