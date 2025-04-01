using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalShare.Responses;
using LocalShared.Entities.Elementos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Elementos
{
    public class TipoElementoRepository : GenericRepository<ClsMTipoElemento>, ITipoElementosRepository
    {
        private readonly DataContext _context;

        public TipoElementoRepository(DataContext context) : base(context: context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMTipoElemento>> GetAsync(Guid id)
        {
            var tipoElemento = await _context.TipoElemento
                .Include(c => c.Elementos!)
                .ThenInclude(s => s.CantidadElementos)
                .FirstOrDefaultAsync(c => c.IdTipoElemento == id);
            if (tipoElemento == null)
            {
                return new ActionResponse<ClsMTipoElemento>
                {
                    WasSuccess = false,
                    Message = "El tipo de elemento no existe"
                };
            }

            return new ActionResponse<ClsMTipoElemento>
            {
                WasSuccess = true,
                Result = tipoElemento
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMTipoElemento>>> GetAsync()
        {
            var tipoElemento = await _context.TipoElemento
                .Include(c => c.Elementos)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMTipoElemento>>
            {
                WasSuccess = true,
                Result = tipoElemento
            };
        }
    }
}
