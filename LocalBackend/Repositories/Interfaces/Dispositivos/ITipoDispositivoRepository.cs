using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.Interfaces.Dispositivos
{
    public interface ITipoDispositivoRepository
    {
        Task<ActionResponse<ClsMTipoDispositivo>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMTipoDispositivo>>> GetAsync();

    }
}
