using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elemento;
using LocalShare.Responses;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Elemento
{
    public class TipoElementoUnitOfWork : GenericUnitOfWork<ClsMTipoElemento>, ITipoElementoUnitOfWork
    {
        private readonly ITipoElementosRepository _tipoElementosRepository;

        public TipoElementoUnitOfWork(IGenericRepository<ClsMTipoElemento> repository, ITipoElementosRepository tipoElementosRepository) : base(repository)
        {
            _tipoElementosRepository = tipoElementosRepository;
        }
        public override async Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync() => await _tipoElementosRepository.GetAsync();
        public override async Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid id) => await _tipoElementosRepository.GetAsync(id);
    }
}
