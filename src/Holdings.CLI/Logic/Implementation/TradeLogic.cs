using Holdings.CLI.Options;
using System;
using System.Threading.Tasks;

namespace Holdings.CLI.Logic.Implementation
{
    public class TradeLogic : IApplicationLogic<TradeOptions>
    {
        public TradeLogic()
        {
        }

        public Task<int> Run(TradeOptions options)
        {
            Console.WriteLine("HELLO TRADE");
            return Task.FromResult(0);
        }
    }
}
