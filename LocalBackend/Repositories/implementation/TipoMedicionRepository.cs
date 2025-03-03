using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces;
using LocalShare.Responses;
using LocalShared.Entities.Medicion;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation
{
    public class TipoMedicionRepository : GenericRepository<ClsMTipoMedicion>, ITipoMedicionRepository
    {
        private readonly DataContext _context;

        public TipoMedicionRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMTipoMedicion>> GetAsync(Guid Id)
        {
            var TipoMedida = await _context.TipoMedicion
                .Include(c => c.UnidadMedida)
                .FirstOrDefaultAsync(c => c.IdTipoMedicion == Id);
            if (TipoMedida == null)
            {
                return new ActionResponse<ClsMTipoMedicion>
                {
                    WasSuccess = false,
                    Message = "Tipo de medicion no encontrado"
                };               
            }
            return new ActionResponse<ClsMTipoMedicion>
            {
                WasSuccess = true,
                Result = TipoMedida
            };
        }


        public override async Task<ActionResponse<IEnumerable<ClsMTipoMedicion>>> GetAsync()
        {
            var TipoMedida = await _context.TipoMedicion
                .Include(c => c.UnidadMedida)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMTipoMedicion>>
            {
                WasSuccess = true,
                Result = TipoMedida
            };
        }
    }
}
