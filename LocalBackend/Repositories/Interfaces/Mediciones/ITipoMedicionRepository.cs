using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Medicion;
using System.Threading.Tasks;

namespace LocalBackend.Repositories.Interfaces.Mediciones
{
    public interface ITipoMedicionRepository
    {
        Task<ActionResponse<ClsMTipoMedicion>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMTipoMedicion>>> GetAsync();
        Task<ActionResponse<IEnumerable<ClsMTipoMedicion>>> GetAsync(PaginationDTO pagination);
         
    }
}
