using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalShare.Responses;
using LocalShared.Entities.Eventos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Eventos
{
    public class TipoEventoRepository : GenericRepository<ClsMTipoEvento>, ITipoEventosRepository
    {
        private readonly DataContext _context;

        public TipoEventoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMTipoEvento>> GetAsync(Guid id)
        {
            var tipoMedicion = await _context.TipoEvento
                .Include(s => s.Eventos)
                .FirstOrDefaultAsync(s => s.IdTipoEvento == id);
            if (tipoMedicion == null)
            {
                return new ActionResponse<ClsMTipoEvento>
                {
                    WasSuccess = false,
                    Message = "Tipo de evento no existe "
                };
            }
            return new ActionResponse<ClsMTipoEvento>
            {
                WasSuccess = true,
                Result = tipoMedicion
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync()
        {
            var tipoMedicion = await _context.TipoEvento
                .Include(s => s.Eventos)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMTipoEvento>>
            {
                WasSuccess = true,
                Result = tipoMedicion
            };
        }
    }
}
