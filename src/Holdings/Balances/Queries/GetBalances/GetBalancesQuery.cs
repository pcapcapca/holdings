namespace Holdings.Balances.Queries.GetBalances
{
    public class GetBalancesQuery : IQuery<BalancesResult>
    {
        public string Store { get; set; }
    }
}
