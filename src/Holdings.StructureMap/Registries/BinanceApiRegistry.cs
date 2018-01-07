using Binance;
using Holdings.ApiClients.Binance.Services;
using Holdings.ApiClients.Binance.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Holdings.StructureMap.Registries
{
    public class BinanceApiRegistry : Registry
    {
        public BinanceApiRegistry()
        {
            For<IBalanceService>().Use<BalanceService>();
            this.Populate(new ServiceCollection().AddBinance());
        }
    }
}
