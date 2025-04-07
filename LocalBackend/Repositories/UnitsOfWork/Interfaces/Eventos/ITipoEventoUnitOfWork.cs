using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos
{
    public interface ITipoEventoUnitOfWork
    {
        Task<ActionResponse<ClsMTipoEvento>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
