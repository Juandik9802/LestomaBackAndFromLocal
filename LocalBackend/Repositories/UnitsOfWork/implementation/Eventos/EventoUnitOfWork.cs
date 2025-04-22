using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShare.Responses;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalShared.Entities.Eventos;
using LocalBackend.Repositories.Interfaces.Eventos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Eventos
{
    public class EventoUnitOfWork  : GenericUnitOfWork<ClsMEvento>, IEventoUnitOfWork
    {       
        private readonly IEventoRepository _eventosRepository;

    public EventoUnitOfWork(IGenericRepository<ClsMEvento> repository, IEventoRepository eventosRepository) : base(repository)
    {
        _eventosRepository = eventosRepository;
    }

    public override async Task<ActionResponse<IEnumerable<ClsMEvento>>> GetAsync() => await _eventosRepository.GetAsync();
    public override async Task<ActionResponse<ClsMEvento>> GetAsync(Guid id) => await _eventosRepository.GetAsync(id);

}
}

