using LocalShare.Responses;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.Interfaces.Elementos
{
    public interface ITipoElementoRepository
    {
        Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync();
    }
}
