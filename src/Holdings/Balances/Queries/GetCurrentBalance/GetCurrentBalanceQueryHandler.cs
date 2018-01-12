using Binance.Account;
using Holdings.ApiClients.Binance.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holdings.Balances.Queries.GetCurrentBalance
{
    public class GetCurrentBalanceQueryHandler : IQueryHandler<GetCurrentBalanceQuery, Balance>
    {
        private readonly IBalanceService service;

        public GetCurrentBalanceQueryHandler(IBalanceService service)
        {
            this.service = service;
        }

        public async Task<Balance> Handle(GetCurrentBalanceQuery query)
        {
            // TODO: fabryka dla różnych giełd
            IEnumerable<AccountBalance> accountBalances = await service.GetAccountBalances();

            List<AssetBalance> balances = accountBalances
                .Select(ab => new AssetBalance { Asset = ab.Asset, Value = ab.Free, Store = "binance" })
                .ToList();

            return new Balance { AssetBalance = balances };
        }
    }
}
