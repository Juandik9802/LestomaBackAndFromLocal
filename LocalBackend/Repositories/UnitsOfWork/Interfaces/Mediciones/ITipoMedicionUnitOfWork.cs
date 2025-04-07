using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones
{
    public interface ITipoMedicionUnitOfWork
    {
        Task<ActionResponse<ClsMTipoMedicion>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMTipoMedicion>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMTipoMedicion>>> GetAsync(PaginationDTO pagination);
    }
}
