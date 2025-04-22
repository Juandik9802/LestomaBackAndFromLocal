using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalShare.Responses;
using LocalShared.Entities.Elementos;
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
            var Impacto = await _context.Elemento
                .Include(c => c.IdTipoElementoNavigation)
                .Include(c => c.Eventos)
                .FirstOrDefaultAsync(c => c.IdElemento == id);
            if (Impacto == null)
            {
                return new ActionResponse<ClsMElemento>
                {
                    WasSuccess = false,
                    Message = "Impacto no existe"
                };
            }

            return new ActionResponse<ClsMElemento>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMElemento>>> GetAsync()
        {
            var Impacto = await _context.Elemento
                .Include(c => c.IdTipoElementoNavigation)
                .Include(c => c.Eventos)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMElemento>>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }
    }
}
