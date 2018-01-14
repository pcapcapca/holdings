using Holdings.Balances.Queries;
using Holdings.Balances.Queries.GetBalanceSnapshot;
using Holdings.Balances.Queries.GetCurrentBalance;
using Holdings.CLI.Options;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Holdings.CLI.Logic.Implementation
{
    public class BalanceLogic : IApplicationLogic<BalanceOptions>
    {
        private readonly IQueryHandler<GetLatestBalanceSnapshotQuery, Balance> snapshotsHandler;
        private readonly IQueryHandler<GetCurrentBalanceQuery, Balance> currentHandler;

        public BalanceLogic(
            IQueryHandler<GetLatestBalanceSnapshotQuery, Balance> snapshotsHandler,
            IQueryHandler<GetCurrentBalanceQuery, Balance> currentHandler)
        {
            if (currentHandler == null)
                throw new ArgumentNullException(nameof(currentHandler));
            if (snapshotsHandler == null)
                throw new ArgumentNullException(nameof(snapshotsHandler));

            this.currentHandler = currentHandler;
            this.snapshotsHandler = snapshotsHandler;
        }

        public async Task<int> Run(BalanceOptions options)
        {
            if (!string.IsNullOrEmpty(options.LatestSnapshot))
            {
                var balances = await snapshotsHandler.Handle(new GetLatestBalanceSnapshotQuery
                {
                    Store = options.LatestSnapshot
                });

                Console.WriteLine("Latest balance snapshot:");
                Console.WriteLine(JsonConvert.SerializeObject(balances.AssetBalances, Formatting.Indented));
            }

            if (!string.IsNullOrEmpty(options.CurrentBalance))
            {
                var balances = await currentHandler.Handle(new GetCurrentBalanceQuery
                {
                    Store = options.CurrentBalance
                });

                Console.WriteLine("Current balance:");
                Console.WriteLine(JsonConvert.SerializeObject(balances.AssetBalances, Formatting.Indented));
            }

            return 0;
        }
    }
}
