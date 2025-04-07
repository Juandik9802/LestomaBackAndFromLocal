using LocalBackend.Repositories.implementation.Dispositivo;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Dispositivo
{
    public class TipoDispositivoUnitOfWork : GenericUnitOfWork<ClsMTipoDispositivo>, ITipoDispositivoUnitOfWork
    {
        private readonly ITipoDispositivoRepository _tipoDispositivosRepository;

        public TipoDispositivoUnitOfWork(IGenericRepository<ClsMTipoDispositivo> repository, ITipoDispositivoRepository tipoDispositivosRepository) : base(repository)
        {
            _tipoDispositivosRepository = tipoDispositivosRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMTipoDispositivo>>> GetAsync() => await _tipoDispositivosRepository.GetAsync();
        public override async Task<ActionResponse<ClsMTipoDispositivo>> GetAsync(Guid id) => await _tipoDispositivosRepository.GetAsync(id);
        public override async Task<ActionResponse<IEnumerable<ClsMTipoDispositivo>>> GetAsync(PaginationDTO pagination) => await _tipoDispositivosRepository.GetAsync(pagination);

    }
}
