using System;

namespace Holdings.Data.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public int TokenFromId { get; set; }
        public int TokenToId { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual Token TokenFrom { get; set; }
        public virtual Token TokenTo { get; set; }
    }
}
