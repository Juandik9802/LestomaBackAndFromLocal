using LocalShare.Responses;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Sistema
{
    public interface ISistemaUnitOfWork
    {
        Task<ActionResponse<ClsMSistema>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMSistema>>> GetAsync();
    }
}
