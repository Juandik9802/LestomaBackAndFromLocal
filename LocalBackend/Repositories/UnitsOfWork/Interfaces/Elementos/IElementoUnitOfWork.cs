using LocalShare.Responses;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Elementos
{
    public interface IElementoUnitOfWork
    {
        Task<ActionResponse<ClsMElemento>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync();
    }
}
