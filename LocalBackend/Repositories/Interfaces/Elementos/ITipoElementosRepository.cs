using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.Interfaces.Elementos
{
    public interface ITipoElementosRepository
    {
        Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync();
    }
}
