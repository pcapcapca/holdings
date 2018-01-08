using System;
using System.Threading.Tasks;
using CommandLine;
using Holdings.CLI.Configuration;
using Holdings.CLI.Options;
using Holdings.StructureMap.Registries;
using StructureMap;

namespace Holdings.CLI
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            IContainer container = ContainerConfiguration.Configure();

            Console.WriteLine(container.WhatDidIScan());
            Console.WriteLine(container.WhatDoIHave());

            //var opts = Parser.Default.ParseArguments<BalanceOptions, TradeOptions>(args)
            //.MapResult();


            return 1;

            /*
            IContainer container = new Container(new BinanceApiRegistry());

            return await Parser.Default.ParseArguments<BalanceOptions, TradeOptions>(args)
                .MapResult(
                    (BalanceOptions opts) => Balance(opts),
                    (TradeOptions opts) => Trade(opts),
                    err => Task.FromResult(1));
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
