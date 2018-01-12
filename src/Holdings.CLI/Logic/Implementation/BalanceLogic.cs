using Holdings.Balances.Queries.GetBalanceSnapshot;
using Holdings.CLI.Options;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Holdings.CLI.Logic.Implementation
{
    public class BalanceLogic : IApplicationLogic<BalanceOptions>
    {
        private readonly IQueryHandler<GetLatestBalanceSnapshotQuery, Balance> handler;

        public BalanceLogic(IQueryHandler<GetLatestBalanceSnapshotQuery, Balance> handler)
        {
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            this.handler = handler;
        }

        public async Task<int> Run(BalanceOptions options)
        {
            if (!string.IsNullOrEmpty(options.ListStore))
            {
                var balances = await handler.Handle(new GetLatestBalanceSnapshotQuery { Store = options.ListStore });
                Console.WriteLine("Balances:");
                Console.WriteLine(JsonConvert.SerializeObject(balances.AssetBalance));
            }

            return 0;
        }
    }
}
