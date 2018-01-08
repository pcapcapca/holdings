using Holdings.CLI.Logic;
using StructureMap;

namespace Holdings.CLI.Configuration
{
    public class CLIRegistry : Registry
    {
        public CLIRegistry()
        {
            Scan(scanner =>
            {
                scanner.AssemblyContainingType(typeof(IApplicationLogic<>));
                scanner.ConnectImplementationsToTypesClosing(typeof(IApplicationLogic<>));
            });
        }
    }
}
