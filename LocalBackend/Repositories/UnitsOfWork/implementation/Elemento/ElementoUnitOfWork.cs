using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elemento;
using LocalShare.Responses;
using LocalShared.Entities.Elementos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Elemento
{
    public class ElementoUnitOfWork : GenericUnitOfWork<ClsMElemento>, IElementoUnitOfWork
    {
        private readonly IElementoRepository _elementoRepository;

        public ElementoUnitOfWork(IGenericRepository<ClsMElemento> repository, IElementoRepository elementoRepository) : base(repository)
        {
            _elementoRepository = elementoRepository;
        }
        public override async Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync() => await _elementoRepository.GetAsync();
        public override async Task<ActionResponse<ClsMElemento>> GetAsync(Guid id) => await _elementoRepository.GetAsync(id);
    }
}
