namespace Holdings.Data.Entities
{
    public class Exchange
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}
