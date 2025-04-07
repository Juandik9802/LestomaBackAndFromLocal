using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.Interfaces.Eventos
{
    public interface ITipoEventosRepository
    {
        Task<ActionResponse<ClsMTipoEvento>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
