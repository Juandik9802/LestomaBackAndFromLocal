using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.Interfaces.Medio
{
    public interface IMedioRepository
    {
        Task<ActionResponse<ClsMMedio>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync(PaginationDTO pagination);
    }
}
