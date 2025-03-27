using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.Interfaces.Dispositivos
{
    public interface IEstadosDispositivoRepository
    {
        Task<ActionResponse<ClsMEstadosDispositivo>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMEstadosDispositivo>>> GetAsync();
    }
}
