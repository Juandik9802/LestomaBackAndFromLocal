using LocalShare.Responses;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Medio
{
    public interface IMedioUnitOfWork
    {
        Task<ActionResponse<ClsMMedio>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync();
    }
}
