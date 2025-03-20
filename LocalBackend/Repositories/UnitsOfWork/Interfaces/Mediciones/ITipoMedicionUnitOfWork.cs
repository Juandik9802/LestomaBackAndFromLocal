using LocalShare.Responses;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones
{
    public interface ITipoMedicionUnitOfWork
    {
        Task<ActionResponse<ClsMTipoMedicion>> GetAsync(Guid Id);

        Task<ActionResponse<IEnumerable<ClsMTipoMedicion>>> GetAsync();
    }
}
