using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.Interfaces.Elementos
{
    public interface IElementoRepository
    {
        Task<ActionResponse<ClsMElemento>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
