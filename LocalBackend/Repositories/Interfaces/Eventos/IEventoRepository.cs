using LocalShare.Responses;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.Interfaces.Eventos
{
    public interface IEventoRepository
    {
        Task<ActionResponse<ClsMEvento>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMEvento>>> GetAsync();
    }
}
