using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones
{
    public class UnidadMedidaUnitOfWork : GenericUnitOfWork<ClsMUnidadMedida>, IUnidadMedidaUnitOfWork
    {
        private readonly IUnidadMedidaRepository _unidadMedidaRepository;

        public UnidadMedidaUnitOfWork(IGenericRepository<ClsMUnidadMedida> repository,IUnidadMedidaRepository unidadMedidaRepository) : base(repository)
        {
            _unidadMedidaRepository = unidadMedidaRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync() => await _unidadMedidaRepository.GetAsync();
        public override async Task<ActionResponse<ClsMUnidadMedida>> GetAsync(Guid Id) => await _unidadMedidaRepository.GetAsync(Id);
        public override async Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync(PaginationDTO pagination) => await _unidadMedidaRepository.GetAsync(pagination);
        public override async Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination) => await _unidadMedidaRepository.GetTotalPagesAsync(pagination);
    }
}
