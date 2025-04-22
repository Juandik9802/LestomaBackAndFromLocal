using LocalShare.Responses;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Elementos
{
    public interface ICantidadElementoUnitOfWork
    {
        Task<ActionResponse<ClsMCantidadElemento>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMCantidadElemento>>> GetAsync();
    }
}
