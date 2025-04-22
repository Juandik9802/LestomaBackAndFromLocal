using LocalShare.Responses;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos
{
    public interface IEventoUnitOfWork
    {
        Task<ActionResponse<ClsMEvento>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMEvento>>> GetAsync();
    }
}
