using System;

namespace Holdings.Data.Entities
{
    public class Deposit
    {
        public int Id { get; set; }
        public int TokenId { get; set; }
        public decimal Value { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual Token Token { get; set; }
    }
}
