using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalShare.Responses;
using LocalShared.Entities.Elementos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Elementos
{
    public class TipoElementoRepository : GenericRepository<ClsMTipoElemento>, ITipoElementoRepository
    {
        private readonly DataContext _context;

        public TipoElementoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid id)
        {
            var Impacto = await _context.TipoElemento
                .Include(c => c.Elementos)
                .Include(c => c.AsignacionMedios)
                .FirstOrDefaultAsync(c => c.IdTipoElemento == id);
            if (Impacto == null)
            {
                return new ActionResponse<ClsMTipoElemento>
                {
                    WasSuccess = false,
                    Message = "Impacto no existe"
                };
            }

            return new ActionResponse<ClsMTipoElemento>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync()
        {
            var Impacto = await _context.TipoElemento
                .Include(c => c.Elementos)
                .Include(c => c.AsignacionMedios)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMTipoElemento>>
            {
                WasSuccess = true,
                Result = Impacto
            };
        }
    }
}
