using CommandLine;
using System;
using System.Linq;
using System.Threading.Tasks;
using Holdings.ApiClients.Binance.Services;
using Holdings.StructureMap.Registries;
using Newtonsoft.Json;
using StructureMap;
using Holdings.CLI.Options;

namespace Holdings.CLI
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", args));

            return await Parser.Default.ParseArguments<BalanceOptions, TradeOptions>(args)
                .MapResult(
                    (BalanceOptions opts) => Balance(opts),
                    (TradeOptions opts) => Trade(opts),
                    err => Task.FromResult(1));

            /*



            var options = Parser.Default.ParseArguments<Options>(args);
            Console.WriteLine($"args: {string.Join(", ", args)}");
            Console.WriteLine(JsonConvert.SerializeObject(options, Formatting.Indented));
            return 0;


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
            */
        }

        static async Task<int> Balance(BalanceOptions opts)
        {
            Console.WriteLine("jea balance");
            return 0;
        }

        static async Task<int> Trade(TradeOptions opts)
        {
            Console.WriteLine("jea trade");
            return 0;
        }
    }
}
