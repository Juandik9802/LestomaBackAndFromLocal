using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Dispositivo
{
    public class DispositivoUnitOfWork : GenericUnitOfWork<ClsMDispositivo>, IDispositivoUnitOfWork
    {       
        private readonly IDispositivoRepository _dispositivosRepository;

        public DispositivoUnitOfWork(IGenericRepository<ClsMDispositivo> repository, IDispositivoRepository dispositivosRepository) : base(repository)
        {
            _dispositivosRepository = dispositivosRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMDispositivo>>> GetAsync() => await _dispositivosRepository.GetAsync();
        public override async Task<ActionResponse<ClsMDispositivo>> GetAsync(Guid id) => await _dispositivosRepository.GetAsync(id);

    }
}
