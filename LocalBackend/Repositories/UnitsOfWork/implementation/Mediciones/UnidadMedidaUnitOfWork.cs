using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones;
using LocalShare.Responses;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones
{
    public class UnidadMedidaUnitOfWork : GenericUnitOfWork<ClsMUnidadMedida>, IUnidadMedidaUnitOfWork
    {
        private readonly IGenericRepository<ClsMUnidadMedida> _repository;

        public UnidadMedidaUnitOfWork(IGenericRepository<ClsMUnidadMedida> repository) : base(repository)
        {
            _repository = repository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync() => await _repository.GetAsync();
        public override async Task<ActionResponse<ClsMUnidadMedida>> GetAsync(Guid Id) => await _repository.GetAsync(Id); 
    }
}
