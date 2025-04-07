using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.Interfaces.Dispositivos
{
    public interface IEstadosDispositivoRepository
    {
        Task<ActionResponse<ClsMEstadosDispositivo>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMEstadosDispositivo>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMEstadosDispositivo>>> GetAsync(PaginationDTO pagination);
    }
}
