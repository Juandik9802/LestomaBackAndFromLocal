using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Medio;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Medio;
using LocalShare.Responses;
using LocalShared.Entities.Sistemas;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Medio
{
    public class MedioUnitOfWork : GenericUnitOfWork<ClsMMedio>, IMedioUnitOfWork
    {
        private readonly IMedioRepository _medioRepository;

        public MedioUnitOfWork(IGenericRepository<ClsMMedio> repository, IMedioRepository medioRepository) : base(repository)
        {
            _medioRepository = medioRepository;
        }

        public override async Task<ActionResponse<ClsMMedio>> GetAsync(Guid Id) => await _medioRepository.GetAsync(Id);

        public override async Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync() => await _medioRepository.GetAsync();
    }
}
