using LocalShare.Responses;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.Interfaces.Medio
{
    public interface IMedioRepository
    {
        Task<ActionResponse<ClsMMedio>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync();
    }
}
