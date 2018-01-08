using System.Threading.Tasks;

namespace Holdings
{
    // TODO: IMPORTANT!!! QUERIES SHOULD NOT CHANGE _ANY_ STATE
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        Task<TResult> Handle(TQuery query);
    }
}
