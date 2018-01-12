namespace Holdings.Balances.Queries.GetCurrentBalance
{
    public class GetCurrentBalanceQuery : IQuery<Balance>
    {
        public string Store { get; set; }
    }
}
