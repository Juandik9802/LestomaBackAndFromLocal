using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Sistema
{
    public interface ISistemaUnitOfWork
    {
        Task<ActionResponse<ClsMSistema>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMSistema>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMSistema>>> GetAsync(PaginationDTO pagination);
    }
}
