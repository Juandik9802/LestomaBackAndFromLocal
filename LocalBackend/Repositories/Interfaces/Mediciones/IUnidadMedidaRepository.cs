using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.Interfaces.Mediciones
{
    public interface IUnidadMedidaRepository
    {
        Task<ActionResponse<ClsMUnidadMedida>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
