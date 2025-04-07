using LocalBackend.Data;
using LocalBackend.Helpers;
using LocalBackend.Repositories.Interfaces.Mediciones;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Eventos;
using LocalShared.Entities.Medicion;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Medicion
{
    public class UnidadMedidaRepository : GenericRepository<ClsMUnidadMedida>, IUnidadMedidaRepository
    {
        private readonly DataContext _context;

        public UnidadMedidaRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMUnidadMedida>> GetAsync(Guid Id)
        {
            var unidadMedida = await _context.UnidadMedida
                .Include(s => s.MMediciones)
                .FirstOrDefaultAsync(s => s.IdUnidadMedida == Id); // Usa FirstOrDefaultAsync, no ToListAsync
            if (unidadMedida == null)
            {
                return new ActionResponse<ClsMUnidadMedida>
                {
                    WasSuccess = false,
                    Message = "Unidad de medida no registrada"
                };
            }
            return new ActionResponse<ClsMUnidadMedida>
            {
                WasSuccess = true,
                Result = unidadMedida
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync()
        {
            var unidadMedida = await _context.UnidadMedida
                .Include(s => s.MMediciones) // Corregido: Usar MMediciones en lugar de Medicion
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMUnidadMedida>>
            {
                WasSuccess = true,
                Result = unidadMedida
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.UnidadMedida
                .Include(c => c.MMediciones)
                .Where(x => x.TipoMedicion!.IdTipoMedicion == pagination.Id)
                .AsQueryable();

            return new ActionResponse<IEnumerable<ClsMUnidadMedida>>
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
            var queryable = _context.UnidadMedida
                .Where(x => x.TipoMedicion!.IdTipoMedicion == pagination.Id)
                .AsQueryable();
            double count = await queryable.CountAsync();
            int totalPages = (int)Math.Ceiling(count / pagination.RecordsNumber);
            return new ActionResponse<int>
            {
                WasSuccess = true,
                Result = totalPages
            };
        }
    }
}
