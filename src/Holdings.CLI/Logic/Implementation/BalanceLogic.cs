using Holdings.Balances.Queries.GetBalances;
using Holdings.CLI.Options;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Holdings.CLI.Logic.Implementation
{
    public class BalanceLogic : IApplicationLogic<BalanceOptions>
    {
        private readonly IQueryHandler<GetBalancesQuery, BalancesResult> handler;

        public BalanceLogic(IQueryHandler<GetBalancesQuery, BalancesResult> handler)
        {
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            this.handler = handler;
        }

        public async Task<int> Run(BalanceOptions options)
        {
            if (!string.IsNullOrEmpty(options.ListStore))
            {
                var balances = await handler.Handle(new GetBalancesQuery { Store = options.ListStore });
                Console.WriteLine("Balances:");
                Console.WriteLine(JsonConvert.SerializeObject(balances.Balances));
            }

            return 0;
        }
    }
}
