using System.Threading.Tasks;

namespace Holdings
{
    public interface ICommandHandler<TCommand>
    {
        Task Handle(TCommand command);
    }
}
