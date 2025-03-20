using LocalShare.Responses;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.Interfaces.Mediciones
{
    public interface IUnidadMedidaRepository
    {
        Task<ActionResponse<ClsMUnidadMedida>> GetAsync(Guid Id);

        Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync();
    }
}
