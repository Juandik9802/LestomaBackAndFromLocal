using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Medio
{
    public interface IMedioUnitOfWork
    {
        Task<ActionResponse<ClsMMedio>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync(PaginationDTO pagination);
    }
}
