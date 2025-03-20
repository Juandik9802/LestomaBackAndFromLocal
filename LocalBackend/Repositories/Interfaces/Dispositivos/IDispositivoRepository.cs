using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.Interfaces.Dispositivos
{
    public interface IDispositivoRepository 
    {
        Task<ActionResponse<ClsMDispositivo>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMDispositivo>>> GetAsync();
    }
}
