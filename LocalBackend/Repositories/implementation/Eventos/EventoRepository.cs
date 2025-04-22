using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalShare.Responses;
using LocalShared.Entities.Eventos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Eventos
{
    public class EventoRepository : GenericRepository<ClsMEvento>, IEventoRepository
    {
        private readonly DataContext _context;

        public EventoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMEvento>> GetAsync(Guid id)
        {
            var Impacto = await _context.Evento
                .Include(c => c.IdAsignacionSistemaNavigation)
                .Include(c => c.IdTipoEventoNavigation)
                .Include(c => c.IdUnidadMedidaNavigation)
                .Include(c => c.IdElementoNavigation)
                .Include(c => c.IdAtributoSistemaNavigation)
                .FirstOrDefaultAsync(c => c.IdEvento == id);
            if (Impacto == null)
            {
                return new ActionResponse<ClsMEvento>
                {
                    WasSuccess = false,
                    Message = "Impacto no existe"
                };
            }

            return new ActionResponse<ClsMEvento>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMEvento>>> GetAsync()
        {
            var Impacto = await _context.Evento
                .Include(c => c.IdAsignacionSistemaNavigation)
                .Include(c => c.IdTipoEventoNavigation)
                .Include(c => c.IdUnidadMedidaNavigation)
                .Include(c => c.IdElementoNavigation)
                .Include(c => c.IdAtributoSistemaNavigation)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMEvento>>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }
    }
}
