﻿using Holdings.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Holdings.Balances.Queries.GetBalanceSnapshot
{
    public class GetLatestBalanceSnapshotQueryHandler : IQueryHandler<GetLatestBalanceSnapshotQuery, Balance>
    {
        private readonly HoldingsContext context;

        public GetLatestBalanceSnapshotQueryHandler(HoldingsContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            this.context = context;
        }

        public async Task<Balance> Handle(GetLatestBalanceSnapshotQuery query)
        {
            List<AssetBalance> balances = await context.BalanceSnapshots
                .GroupBy(b => b.Store.Name)
                .Where(g => string.Equals(g.Key, query.Store, StringComparison.InvariantCultureIgnoreCase))
                .Select(g => g.OrderByDescending(b => b.Timestamp).First())
                .Select(b => new AssetBalance
                {
                    Asset = b.Asset.Symbol,
                    Store = b.Store.Name,
                    Value = b.Value
                })
                .ToListAsync();

            return new Balance { AssetBalances = balances };
        }
    }
}
