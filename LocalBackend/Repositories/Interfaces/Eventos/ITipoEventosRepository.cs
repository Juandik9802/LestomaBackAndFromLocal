using LocalShare.Responses;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.Interfaces.Eventos
{
    public interface ITipoEventosRepository
    {
        Task<ActionResponse<ClsMTipoEvento>> GetAsync(Guid id);

        Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync();
    }
}
