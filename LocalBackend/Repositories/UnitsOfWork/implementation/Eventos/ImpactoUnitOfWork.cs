using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShare.Responses;
using LocalShared.Entities.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Eventos
{
    public class ImpactoUnitOfWork : GenericUnitOfWork<ClsMImpacto>, IImpactoUnitOfWork
    {
        private readonly IImpactoRepository _impactoRepository;

        public ImpactoUnitOfWork(IGenericRepository<ClsMImpacto> repository, IImpactoRepository impactoRepository ) : base(repository)
        {
            _impactoRepository = impactoRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMImpacto>>> GetAsync() => await _impactoRepository.GetAsync();
        public override async Task<ActionResponse<ClsMImpacto>> GetAsync(Guid id) => await _impactoRepository.GetAsync(id); 
    }
}
