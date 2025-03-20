using LocalBackend.Controllers;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShare.Responses;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Eventos
{
    public class TipoEventoUnitOfWork : GenericUnitOfWork<ClsMTipoEvento> ,ITipoEventoUnitOfWork
    {
        private readonly ITipoEventosRepository _tipoEventosRepository;

        public TipoEventoUnitOfWork(IGenericRepository<ClsMTipoEvento> repository, ITipoEventosRepository tipoEventosRepository) : base(repository)
        {
            _tipoEventosRepository = tipoEventosRepository;
        }

        public override async Task<ActionResponse<ClsMTipoEvento>> GetAsync(Guid id) => await _tipoEventosRepository.GetAsync(id);

        public override async Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync() => await _tipoEventosRepository.GetAsync();
    }
}
