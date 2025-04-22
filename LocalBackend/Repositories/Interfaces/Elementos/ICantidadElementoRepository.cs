using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.Interfaces.Elementos
{
    public interface ICantidadElementoRepository
    {
        Task<ActionResponse<ClsMCantidadElemento>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMCantidadElemento>>> GetAsync();
    }
}
