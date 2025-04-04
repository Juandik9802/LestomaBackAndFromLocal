using LocalShare.Responses;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Elemento
{
    public interface IElementoUnitOfWork
    {
        Task<ActionResponse<ClsMElemento>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync();
    }
}
