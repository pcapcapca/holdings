using System.Collections.Generic;
using System.Threading.Tasks;
using Binance.Account;

namespace Holdings.ApiClients.Binance.Services
{
    public interface IBalanceService
    {
        Task<IEnumerable<AccountBalance>> GetAccountBalances();
        Task CompareTime();
    }
}
