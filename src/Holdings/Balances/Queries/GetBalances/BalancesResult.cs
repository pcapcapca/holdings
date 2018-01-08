using System.Collections.Generic;

namespace Holdings.Balances.Queries.GetBalances
{
    public class BalancesResult
    {
        public IEnumerable<Balance> Balances { get; set; }
    }
}
