using LocalShare.Responses;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.Interfaces
{
    public interface IUnidadMedidaRepository
    {
        Task<ActionResponse<ClsMUnidadMedida>> GetAsync(Guid Id);

        Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync();
    }
}
