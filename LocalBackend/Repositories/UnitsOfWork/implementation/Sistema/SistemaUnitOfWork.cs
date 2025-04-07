 using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Sistema;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Sistema;
using LocalShare.Responses;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Sistema
{
    public class SistemaUnitOfwork : GenericUnitOfWork<ClsMSistema> ,ISistemaUnitOfWork
    {
        private readonly ISistemaRepository _sistemaRepository;

        public SistemaUnitOfwork(IGenericRepository<ClsMSistema> repository, ISistemaRepository sistemaRepository) : base(repository)
        {
            _sistemaRepository = sistemaRepository;
        }

        public override async Task<ActionResponse<ClsMSistema>> GetAsync(Guid Id) => await _sistemaRepository.GetAsync(Id);

        public override async Task<ActionResponse<IEnumerable<ClsMSistema>>> GetAsync() => await _sistemaRepository.GetAsync();
    }
}
