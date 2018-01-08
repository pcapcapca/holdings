using Holdings.StructureMap.Registries;
using StructureMap;

namespace Holdings.CLI.Configuration
{
    static class ContainerConfiguration
    {
        public static IContainer Configure()
        {
            return new Container(config =>
            {
                config.AddRegistry<CLIRegistry>();
                config.AddRegistry<HoldingsRegistry>();
                config.AddRegistry<BinanceApiRegistry>();
            });
        }
    }
}
