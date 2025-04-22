using LocalShare.Responses;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.Interfaces.Elementos
{
    public interface IElementoRepository
    {
        Task<ActionResponse<ClsMElemento>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync();
    }
}
