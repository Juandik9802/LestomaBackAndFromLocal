using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Dispositivo
{
    public class DispositivoRepository : GenericRepository<ClsMDispositivo>, IDispositivoRepository
    {
        private readonly DataContext _context;

        public DispositivoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMDispositivo>> GetAsync(Guid id)
        {
            var dispositivo = await _context.Dispositivo
                .Include(c => c.LogsEstados!)
                .FirstOrDefaultAsync(c => c.IdDispisitivo == id);
            if (dispositivo == null)
            {
                return new ActionResponse<ClsMDispositivo>
                {
                    WasSuccess = false,
                    Message = "Dispositivo no existe"
                };
            }

            return new ActionResponse<ClsMDispositivo>
            {
                WasSuccess = true,
                Result = dispositivo
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMDispositivo>>> GetAsync()
        {
            var dispositivo = await _context.Dispositivo
                .Include(c => c.LogsEstados)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMDispositivo>>
            {
                WasSuccess = true,
                Result = dispositivo
            };
        }
    }
}
