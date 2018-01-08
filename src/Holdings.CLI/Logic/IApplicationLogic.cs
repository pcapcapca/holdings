using System.Threading.Tasks;

namespace Holdings.CLI.Logic
{
    interface IApplicationLogic<TOptions>
    {
        Task<int> Run(TOptions options);
    }
}
