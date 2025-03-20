using LocalShare.Responses;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.Interfaces.Eventos
{
    public interface IImpactoRepository
    {
        Task<ActionResponse<ClsMImpacto>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMImpacto>>> GetAsync();
    }
}
