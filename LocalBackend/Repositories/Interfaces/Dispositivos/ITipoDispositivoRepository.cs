using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.Interfaces.Dispositivos
{
    public interface ITipoDispositivoRepository
    {
        Task<ActionResponse<ClsMTipoDispositivo>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMTipoDispositivo>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMTipoDispositivo>>> GetAsync(PaginationDTO pagination);   
    }
}
