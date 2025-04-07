using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Elemento
{
    public interface IElementoUnitOfWork
    {
        Task<ActionResponse<ClsMElemento>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
