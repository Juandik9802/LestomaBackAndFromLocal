using LocalShare.Responses;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Elementos
{
    public interface ITipoElementoUnitOfWork
    {
        Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync();
    }
}
