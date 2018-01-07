using System;
using System.Linq;
using System.Threading.Tasks;
using Holdings.ApiClients.Binance.Services;
using Holdings.StructureMap.Registries;
using Newtonsoft.Json;
using StructureMap;

namespace Holdings.CLI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Container container = new Container(new BinanceApiRegistry());

            try
            {
                IBalanceService svc = container.GetInstance<IBalanceService>();

                await svc.CompareTime();

                var balances = await svc.GetAccountBalances();
                string serialized = JsonConvert.SerializeObject(balances.Where(b => b.Free > 0).ToList(), Formatting.Indented);
                Console.WriteLine(serialized);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
