using LocalBackend.Data;
using LocalBackend.Helpers;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
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
                .ThenInclude(s => s.EstadoDipositivo)
                .FirstOrDefaultAsync(c => c.IdDispositivo == id);
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
                .OrderBy(c => c.Nombre)
                .Include(x => x.AsignacionSistema)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMDispositivo>>
            {
                WasSuccess = true,
                Result = dispositivo
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMDispositivo>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.Dispositivo
                .Include(c => c.Marca)
                .Where(x => x.TipoDispositivo!.IdTipoDispositivo == pagination.Id)
                .AsQueryable();

            return new ActionResponse<IEnumerable<ClsMDispositivo>>
            {
                WasSuccess = true,
                Result = await queryable
                    .OrderBy(x => x.Nombre)
                    .Paginate(pagination)
                    .ToListAsync()
            };
        }

        public async override Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination)
        {
            var queryable = _context.Dispositivo
                .Where(x => x.TipoDispositivo!.IdTipoDispositivo == pagination.Id)
                .AsQueryable();
            double count = await queryable.CountAsync();
            int totalpages = (int)Math.Ceiling(count / pagination.RecordsNumber);
            return new ActionResponse<int>
            {
                WasSuccess = true,
                Result = totalpages
            };
        }
    }
}
