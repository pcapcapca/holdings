namespace Holdings.Balances.Queries.GetBalances
{
    public class GetBalancesQuery : IQuery<BalancesResult>
    {
        public const string All = "all";

        public string Store { get; set; }
    }
}
