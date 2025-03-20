using LocalShare.Responses;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos
{
    public interface IImpactoUnitOfWork
    {
        Task<ActionResponse<ClsMImpacto>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMImpacto>>> GetAsync();
    }
}
