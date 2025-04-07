using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.Interfaces.Dispositivos
{
    public interface IDispositivoRepository 
    {
        Task<ActionResponse<ClsMDispositivo>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMDispositivo>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMDispositivo>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
