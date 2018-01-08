using CommandLine;
using Holdings.CLI.Configuration;
using Holdings.CLI.Logic;
using Holdings.CLI.Options;
using StructureMap;
using System.Threading.Tasks;

namespace Holdings.CLI
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            IContainer container = ContainerConfiguration.Configure();

            return await Parser.Default.ParseArguments<BalanceOptions, TradeOptions>(args)
                .MapResult(
                    (BalanceOptions opts) => container.GetInstance<IApplicationLogic<BalanceOptions>>().Run(opts),
                    (TradeOptions opts) => container.GetInstance<IApplicationLogic<TradeOptions>>().Run(opts),
                    err => Task.FromResult(1)
                );
        }
    }
}
