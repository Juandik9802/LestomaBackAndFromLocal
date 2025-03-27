using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos
{
    public interface IEstadosDispositivoUnitOfWork
    {
        Task<ActionResponse<ClsMEstadosDispositivo>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMEstadosDispositivo>>> GetAsync();
    }
}
