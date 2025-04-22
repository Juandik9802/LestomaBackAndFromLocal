using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Mediciones;
using LocalShare.Responses;
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
                .Include(s => s.Medicions)
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
                .Include(s => s.Medicions) // Corregido: Usar MMediciones en lugar de Medicion
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMUnidadMedida>>
            {
                WasSuccess = true,
                Result = unidadMedida
            };
        }
    }
}
