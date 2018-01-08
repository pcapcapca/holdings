using Holdings.CLI.Logic;
using Holdings.CLI.Logic.Implementation;
using Holdings.CLI.Options;
using StructureMap;

namespace Holdings.CLI.Configuration
{
    public class CLIRegistry : Registry
    {
        public CLIRegistry()
        {
            For<IApplicationLogic<BalanceOptions>>().Use<BalanceLogic>();
            For<IApplicationLogic<TradeOptions>>().Use<TradeLogic>();
        }
    }
}
