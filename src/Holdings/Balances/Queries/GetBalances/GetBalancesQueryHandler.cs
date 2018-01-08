﻿using Holdings.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Holdings.Balances.Queries.GetBalances
{
    public class GetBalancesQueryHandler : IQueryHandler<GetBalancesQuery, BalancesResult>
    {
        private readonly HoldingsContext context;

        public GetBalancesQueryHandler(HoldingsContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            this.context = context;
        }

        public async Task<BalancesResult> Handle(GetBalancesQuery query)
        {
            List<Balance> balances = await context.BalanceSnapshots
                   .Where(b => query.Store == GetBalancesQuery.All || query.Store == b.Store.Name)
                   .GroupBy(b => b.StoreId)
                   .Select(g => g.OrderByDescending(b => b.Timestamp).First())
                   .Select(b => new Balance
                   {
                       Asset = b.Asset.Symbol,
                       Store = b.Store.Name,
                       Value = b.Value
                   })
                   .ToListAsync();

            return new BalancesResult { Balances = balances };
        }
    }
}