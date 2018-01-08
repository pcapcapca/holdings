using System.Threading.Tasks;

namespace Holdings.CLI.Logic
{
    public interface IApplicationLogic<TOptions>
    {
        Task<int> Run(TOptions options);
    }
}
