﻿using System.Collections.Generic;

namespace Holdings.Balances.Queries
{
    public class Balance
    {
        public IEnumerable<AssetBalance> AssetBalances { get; set; }
    }
}
