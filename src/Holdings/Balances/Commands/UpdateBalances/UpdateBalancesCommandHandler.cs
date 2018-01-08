using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Binance.Account;
using Holdings.ApiClients.Binance.Services;
using Holdings.Data;
using Holdings.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Holdings.Balances.Commands.UpdateBalances
{
    public class UpdateBalancesCommandHandler : ICommandHandler<UpdateBalancesCommand>
    {
        private readonly HoldingsContext context;
        private readonly IBalanceService service;

        public UpdateBalancesCommandHandler(HoldingsContext context, IBalanceService service)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (service == null)
                throw new ArgumentNullException(nameof(service));

            this.context = context;
            this.service = service;
        }

        public async Task Handle(UpdateBalancesCommand command)
        {
            // TODO: co z innymi giełdami
            IEnumerable<AccountBalance> balances = await service.GetAccountBalances();
            List<Asset> assets = await GetAssets(balances.Select(b => b.Asset).Distinct());
            Exchange exchange = await GetExchange("binance");
            DateTime now = DateTime.UtcNow;

            context.BalanceSnapshots.AddRange(balances.Select(b => new BalanceSnapshot
            {
                Asset = assets.Single(a => a.Symbol == b.Asset), 
                Store = exchange.Store,
                Value = b.Free,
                Timestamp = now
            }));
            await context.SaveChangesAsync();
        }

        private Task<List<Asset>> GetAssets(IEnumerable<string> symbols)
        {
            return context.Assets
                          .Where(a => symbols.Any(s => string.Equals(a.Symbol, s, StringComparison.InvariantCultureIgnoreCase)))
                          .ToListAsync();
        }

        private Task<Exchange> GetExchange(string name)
        {
            return context.Exchanges
                          .Include(e => e.Store)
                          .SingleAsync(e => string.Equals(e.Name, name, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
