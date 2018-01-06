namespace Holdings.Data.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public int? ExchangeId { get; set; }
        public string Name { get; set; }

        public virtual Exchange Exchange { get; set; }
    }
}
