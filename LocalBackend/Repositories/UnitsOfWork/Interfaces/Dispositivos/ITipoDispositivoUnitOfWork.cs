using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos
{
    public interface ITipoDispositivoUnitOfWork
    {
        Task<ActionResponse<ClsMTipoDispositivo>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMTipoDispositivo>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMTipoDispositivo>>> GetAsync(PaginationDTO pagination);
    }
}
