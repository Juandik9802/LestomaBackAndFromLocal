using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalShare.Responses;
using LocalShared.Entities.Eventos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Eventos
{
    public class ImpactoRepository : GenericRepository<ClsMImpacto>, IImpactoRepository
    {
        private readonly DataContext _context;

        public ImpactoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMImpacto>> GetAsync(Guid id)
        {
            var Impacto = await _context.Impacto
                .Include(c => c.tipoEventos!)
                .ThenInclude(s => s.eventos)
                .FirstOrDefaultAsync(c => c.IdImpacto == id);
            if (Impacto == null)
            {
                return new ActionResponse<ClsMImpacto>
                {
                    WasSuccess = false,
                    Message = "Impacto no existe"
                };
            }

            return new ActionResponse<ClsMImpacto>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMImpacto>>> GetAsync()
        {
            var Impacto = await _context.Impacto
                .Include(c => c.tipoEventos)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMImpacto>>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }
    }
}
