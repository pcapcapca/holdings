using Holdings.CLI.Options;
using System;
using System.Threading.Tasks;

namespace Holdings.CLI.Logic.Implementation
{
    class BalanceLogic : IApplicationLogic<BalanceOptions>
    {
        public BalanceLogic()
        {
        }

        public Task<int> Run(BalanceOptions options)
        {
            Console.WriteLine("HELLO BALANCE");
            return Task.FromResult(0);
        }
    }
}
