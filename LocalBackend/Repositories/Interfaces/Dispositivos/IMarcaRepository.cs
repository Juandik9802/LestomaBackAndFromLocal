using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.Interfaces.Dispositivos
{
    public interface IMarcaRepository
    {
        Task<ActionResponse<ClsMMarca>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMMarca>>> GetAsync();
    }
}
