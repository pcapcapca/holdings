using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Binance;
using Binance.Api;

namespace Holdings.ApiClients.Binance.Services.Implementation
{
    public class TradeService : ITradeService
    {
        private readonly IBinanceApi api;

        public TradeService(IBinanceApi api)
        {
            if (api == null)
                throw new ArgumentNullException(nameof(api));

            this.api = api;
        }

        public Task<IEnumerable<Trade>> GetTradesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
