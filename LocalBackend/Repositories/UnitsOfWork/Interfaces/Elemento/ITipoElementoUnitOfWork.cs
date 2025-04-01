using LocalShare.Responses;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Elemento
{
    public interface ITipoElementoUnitOfWork
    {
        Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync();
    }
}
