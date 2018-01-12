namespace Holdings.Balances.Queries.GetBalanceSnapshot
{
    public class GetLatestBalanceSnapshotQuery : IQuery<Balance>
    {
        public string Store { get; set; }
    }
}
