using System.Threading.Tasks;
using System.Collections.Generic;
using Binance.Account;
using Binance.Api;
using System;

using Microsoft.Extensions.Configuration;

namespace Holdings.ApiClients.Binance.Services.Implementation
{
    public class BalanceService : IBalanceService
    {
        private readonly IBinanceApi api;
        

        public BalanceService(IBinanceApi api, IConfiguration configuration)
        {
            this.api = api;
        }

        public async Task<IEnumerable<AccountBalance>> GetAccountBalances()
        {
            using (var apiUser = new BinanceApiUser("key", "secret"))
            {
                AccountInfo accountInfo = await api.GetAccountInfoAsync(apiUser);

                return accountInfo.Balances;
            }
        }

        public async Task CompareTime()
        {
            long localTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            long serverTimestamp = await api.GetTimestampAsync();    

            Console.WriteLine($"local: {localTimestamp}, server: {serverTimestamp}, diff: {Math.Abs(localTimestamp - serverTimestamp)}.");
        }
    }
}
