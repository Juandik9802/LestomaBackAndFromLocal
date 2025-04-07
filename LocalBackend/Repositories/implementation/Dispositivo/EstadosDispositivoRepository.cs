using LocalBackend.Data;
using LocalBackend.Helpers;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Dispositivo
{
    public class EstadosDispositivoRepository : GenericRepository<ClsMEstadosDispositivo>, IEstadosDispositivoRepository
    {
        private readonly DataContext _context;

        public EstadosDispositivoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMEstadosDispositivo>> GetAsync(Guid id)
        {
            var Marca = await _context.EstadosDispositivo
                .Include(c => c.LogsEstados!)
                .ThenInclude(s => s.Dispositivo)
                .FirstOrDefaultAsync(c => c.IdEstadoDispositivo == id);
            if (Marca == null)
            {
                return new ActionResponse<ClsMEstadosDispositivo>
                {
                    WasSuccess = false,
                    Message = "Dispositivo no existe"
                };
            }

            return new ActionResponse<ClsMEstadosDispositivo>
            {
                WasSuccess = true,
                Result = Marca
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMEstadosDispositivo>>> GetAsync()
        {
            var Marca = await _context.EstadosDispositivo
                .Include(c => c.LogsEstados)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMEstadosDispositivo>>
            {
                WasSuccess = true,
                Result = Marca
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMEstadosDispositivo>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.EstadosDispositivo
                .Include(c => c.LogsEstados)
                .AsQueryable();

            return new ActionResponse<IEnumerable<ClsMEstadosDispositivo>>
            {
                WasSuccess = true,
                Result = await queryable
                    .OrderBy(x => x.Nombre)
                    .Paginate(pagination)
                    .ToListAsync()
            };
        }
    }
}
