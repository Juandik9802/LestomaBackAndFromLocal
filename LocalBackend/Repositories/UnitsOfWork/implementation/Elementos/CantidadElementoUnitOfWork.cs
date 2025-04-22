using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalShare.Responses;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elementos;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Elementos
{
    public class CantidadElementoUnitOfWork : GenericUnitOfWork<ClsMCantidadElemento>, ICantidadElementoUnitOfWork
    {
        private readonly ICantidadElementoRepository _Repository;

        public CantidadElementoUnitOfWork(IGenericRepository<ClsMCantidadElemento> repository, ICantidadElementoRepository Repository) : base(repository)
        {
            _Repository = Repository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMCantidadElemento>>> GetAsync() => await _Repository.GetAsync();
        public override async Task<ActionResponse<ClsMCantidadElemento>> GetAsync(Guid id) => await _Repository.GetAsync(id);

    }
}


