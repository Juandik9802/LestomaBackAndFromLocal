using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos
{
    public interface IMarcaUnitOfWork
    {
        Task<ActionResponse<ClsMMarca>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMMarca>>> GetAsync();
    }
}
