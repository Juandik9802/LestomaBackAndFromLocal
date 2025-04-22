using LocalBackend.Repositories.Interfaces.Elementos;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elementos;
using LocalShare.Responses;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Elementos
{
    public class ElementoUnitOfWork : GenericUnitOfWork<ClsMElemento>, IElementoUnitOfWork
    {
        private readonly IElementoRepository _Repository;

        public ElementoUnitOfWork(IGenericRepository<ClsMElemento> repository, IElementoRepository Repository) : base(repository)
        {
            _Repository = Repository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync() => await _Repository.GetAsync();
        public override async Task<ActionResponse<ClsMElemento>> GetAsync(Guid id) => await _Repository.GetAsync(id);

    }
    
    
}
