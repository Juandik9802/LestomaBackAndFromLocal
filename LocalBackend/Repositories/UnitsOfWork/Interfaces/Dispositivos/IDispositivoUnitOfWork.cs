using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos
{
    public interface IDispositivoUnitOfWork
    {
        Task<ActionResponse<ClsMDispositivo>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMDispositivo>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMDispositivo>>> GetAsync(PaginationDTO pagination);
        Task <ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);

    }
}
