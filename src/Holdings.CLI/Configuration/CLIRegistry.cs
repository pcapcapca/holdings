using Holdings.CLI.Logic;
using Microsoft.Extensions.Configuration;
using StructureMap;
using System.IO;

namespace Holdings.CLI.Configuration
{
    public class CLIRegistry : Registry
    {
        public CLIRegistry()
        {
            For<IConfiguration>()
                .Use(context => CreateConfigurationRoot())
                .Singleton();

            Scan(scanner =>
            {
                scanner.AssemblyContainingType(typeof(IApplicationLogic<>));
                scanner.ConnectImplementationsToTypesClosing(typeof(IApplicationLogic<>));
            });
        }

        private IConfigurationRoot CreateConfigurationRoot()
        {
            System.Console.WriteLine("CREATING CONFIGURATION ROOT");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            return builder.Build();
        }
    }
}
