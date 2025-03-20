using LocalShare.Responses;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos
{
    public interface ITipoEventoUnitOfWork
    {
        Task<ActionResponse<ClsMTipoEvento>> GetAsync(Guid Id);

        Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync();
    }
}
