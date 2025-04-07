using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.Interfaces.Elementos
{
    public interface ITipoElementosRepository
    {
        Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync(PaginationDTO pagination);
    }
}
