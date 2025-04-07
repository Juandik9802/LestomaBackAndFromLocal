using LocalBackend.Data;
using LocalBackend.Repositories.implementation;
using LocalBackend.Repositories.implementation.Dispositivo;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Dispositivo
{
    public class EstadosDispositivosUnitOfWork : GenericUnitOfWork<ClsMEstadosDispositivo>, IEstadosDispositivoUnitOfWork
    {
        private readonly IEstadosDispositivoRepository _estadosDispositivoRepository;

        public EstadosDispositivosUnitOfWork(IGenericRepository<ClsMEstadosDispositivo> repository, IEstadosDispositivoRepository estadosDispositivoRepository) : base(repository)
        {
            _estadosDispositivoRepository = estadosDispositivoRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMEstadosDispositivo>>> GetAsync() => await _estadosDispositivoRepository.GetAsync();
        public override async Task<ActionResponse<ClsMEstadosDispositivo>> GetAsync(Guid id) => await _estadosDispositivoRepository.GetAsync(id);
        public override async Task<ActionResponse<IEnumerable<ClsMEstadosDispositivo>>> GetAsync(PaginationDTO pagination) => await _estadosDispositivoRepository.GetAsync(pagination);

    }
}
