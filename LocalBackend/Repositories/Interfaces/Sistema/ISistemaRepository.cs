using LocalShare.Responses;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.Interfaces.Sistema
{
    public interface ISistemaRepository
    {
        Task<ActionResponse<ClsMSistema>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMSistema>>> GetAsync();
    }
}
