using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos
{
    public interface IImpactoUnitOfWork
    {
        Task<ActionResponse<ClsMImpacto>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMImpacto>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMImpacto>>> GetAsync(PaginationDTO pagination);
    }
}
