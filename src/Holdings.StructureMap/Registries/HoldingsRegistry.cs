using StructureMap;

namespace Holdings.StructureMap.Registries
{
    public class HoldingsRegistry : Registry
    {
        public HoldingsRegistry() 
        {
            Scan(scanner =>
            {
                scanner.AssemblyContainingType(typeof(IQuery<>));

                scanner.ConnectImplementationsToTypesClosing(typeof(IQueryHandler<,>));
                scanner.ConnectImplementationsToTypesClosing(typeof(ICommandHandler<>));
            });
        } 
    }
}
