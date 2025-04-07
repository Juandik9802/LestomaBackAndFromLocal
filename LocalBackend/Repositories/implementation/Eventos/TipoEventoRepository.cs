using LocalBackend.Data;
using LocalBackend.Helpers;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
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
                .Include(s => s.eventos)
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
                .Include(s => s.eventos)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMTipoEvento>>
            {
                WasSuccess = true,
                Result = tipoMedicion
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMTipoEvento>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.TipoEvento
                .Include(c => c.Impacto)
                .Where(x => x.Impacto!.IdImpacto == pagination.Id)
                .AsQueryable();

            return new ActionResponse<IEnumerable<ClsMTipoEvento>>
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
            var queryable = _context.TipoEvento
                .Where(x => x.Impacto!.IdImpacto == pagination.Id)
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
