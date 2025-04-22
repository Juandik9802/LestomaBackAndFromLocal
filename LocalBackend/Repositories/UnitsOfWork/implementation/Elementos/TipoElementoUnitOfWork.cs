using LocalBackend.Repositories.Interfaces.Elementos;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elementos;
using LocalShare.Responses;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Elementos
{
    public class TipoElementoUnitOfWork : GenericUnitOfWork<ClsMTipoElemento>, ITipoElementoUnitOfWork
    {
        private readonly ITipoElementoRepository _Repository;

        public TipoElementoUnitOfWork(IGenericRepository<ClsMTipoElemento> repository, ITipoElementoRepository Repository) : base(repository)
        {
            _Repository = Repository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync() => await _Repository.GetAsync();
        public override async Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid id) => await _Repository.GetAsync(id);

    }
}