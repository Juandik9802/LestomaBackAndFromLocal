using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalShare.Responses;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Elementos
{
    public class CantidadElementoRepository : GenericRepository<ClsMCantidadElemento>, ICantidadElementoRepository
    {
        private readonly DataContext _context;

        public CantidadElementoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMCantidadElemento>> GetAsync(Guid id)
        {
            var Impacto = await _context.CantidadElemento
                .Include(c => c.IdUnidadMedidaNavigation)
                .Include(c => c.IdAsignacionSistemaNavigation)
                .Include(c => c.IdElementoNavigation)
                .ThenInclude(s => s.Eventos)
                .FirstOrDefaultAsync(c => c.IdCantidadElemento == id);
            if (Impacto == null)
            {
                return new ActionResponse<ClsMCantidadElemento>
                {
                    WasSuccess = false,
                    Message = "Impacto no existe"
                };
            }

            return new ActionResponse<ClsMCantidadElemento>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMCantidadElemento>>> GetAsync()
        {
            var Impacto = await _context.CantidadElemento
                .Include(c => c.IdUnidadMedidaNavigation)
                .Include(c => c.IdAsignacionSistemaNavigation)
                .Include(c => c.IdElementoNavigation)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMCantidadElemento>>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }
    }
}
