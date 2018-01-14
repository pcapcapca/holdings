using System.Threading.Tasks;
using System.Collections.Generic;
using Binance.Account;
using Binance.Api;
using System;
using Holdings.ApiClients.Binance.Configuration;

namespace Holdings.ApiClients.Binance.Services.Implementation
{
    public class BalanceService : IBalanceService
    {
        private readonly IBinanceApi api;
        private readonly BinanceApiConfiguration configuration;

        public BalanceService(IBinanceApi api, BinanceApiConfiguration configuration)
        {
            this.api = api;
            this.configuration = configuration;
        }

        public async Task<IEnumerable<AccountBalance>> GetAccountBalances()
        {
            using (var apiUser = new BinanceApiUser(configuration.Key, configuration.Secret))
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
