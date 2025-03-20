using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Dispositivo
{
    public class TipoDispositivoRepository : GenericRepository<ClsMTipoDispositivo>, ITipoDispositivoRepository
    {
        private readonly DataContext _context;

        public TipoDispositivoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMTipoDispositivo>> GetAsync(Guid id)
        {
            var Impacto = await _context.TipoDispositivo
                .Include(c => c.mDispositivos!)
                .ThenInclude(s => s.marca)
                .FirstOrDefaultAsync(c => c.IdTipoDispositivo == id);
            if (Impacto == null)
            {
                return new ActionResponse<ClsMTipoDispositivo>
                {
                    WasSuccess = false,
                    Message = "Impacto no existe"
                };
            }

            return new ActionResponse<ClsMTipoDispositivo>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMTipoDispositivo>>> GetAsync()
        {
            var Impacto = await _context.TipoDispositivo
                .Include(c => c.mDispositivos)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMTipoDispositivo>>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }
    }
}
