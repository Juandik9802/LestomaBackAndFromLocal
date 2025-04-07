using LocalBackend.Data;
using LocalBackend.Helpers;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Elementos
{
    public class ElementoRepository : GenericRepository<ClsMElemento>, IElementoRepository
    {
        private readonly DataContext _context;

        public ElementoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMElemento>> GetAsync(Guid id)
        {
            var tipoElemento = await _context.Elemento
                .Include(c => c.CantidadElementos!)
                .ThenInclude(s => s.AsignacionSistema)
                .FirstOrDefaultAsync(c => c.IdElemento == id);
            if (tipoElemento == null)
            {
                return new ActionResponse<ClsMElemento>
                {
                    WasSuccess = false,
                    Message = "El tipo de elemento no existe"
                };
            }

            return new ActionResponse<ClsMElemento>
            {
                WasSuccess = true,
                Result = tipoElemento
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync()
        {
            var tipoElemento = await _context.Elemento
                .Include(c => c.CantidadElementos)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMElemento>>
            {
                WasSuccess = true,
                Result = tipoElemento
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.Elemento
                .Include(c => c.CantidadElementos)
                .Where(x => x.TipoElemento!.IdTipoElemento == pagination.Id)
                .AsQueryable();

            return new ActionResponse<IEnumerable<ClsMElemento>>
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
            var queryable = _context.Elemento
                .Where(x => x.TipoElemento!.IdTipoElemento == pagination.Id)
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
