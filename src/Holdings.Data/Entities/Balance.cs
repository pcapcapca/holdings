namespace Holdings.Data.Entities
{
    public class Balance
    {
        public int Id { get; set; }
        public int TokenId { get; set; }
        public decimal Value { get; set; }

        public virtual Token Token { get; set; }
    }
}
