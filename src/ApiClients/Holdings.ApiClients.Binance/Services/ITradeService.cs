using Binance;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Holdings.ApiClients.Binance.Services
{
    public interface ITradeService
    {

        Task<IEnumerable<Trade>> GetTradesAsync();
    }
}
