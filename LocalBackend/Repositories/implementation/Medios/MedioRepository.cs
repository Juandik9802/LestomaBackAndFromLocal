using LocalBackend.Data;
using LocalBackend.Helpers;
using LocalBackend.Repositories.Interfaces.Medio;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Eventos;
using LocalShared.Entities.Sistemas;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Medios
{
    public class MedioRepository : GenericRepository<ClsMMedio>, IMedioRepository
    {
        private readonly DataContext _context;

        public MedioRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMMedio>> GetAsync(Guid id)
        {
            var medio = await _context.Medio
                .Include(c => c.AsignacionMedios)
                .ThenInclude(s => s.TipoElemento)
                .FirstOrDefaultAsync(s => s.IdMedio == id);
            if (medio == null)
            {
                return new ActionResponse<ClsMMedio>
                {
                    WasSuccess = false,
                    Message = "Tipo de evento no existe "
                };
            }
            return new ActionResponse<ClsMMedio>
            {
                WasSuccess = true,
                Result = medio
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync()
        {
            var medio = await _context.Medio
                .Include(s => s.AsignacionMedios)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMMedio>>
            {
                WasSuccess = true,
                Result = medio
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMMedio>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.Medio  
                .Include(c => c.AsignacionMedios)
                .AsQueryable();

            return new ActionResponse<IEnumerable<ClsMMedio>>
            {
                WasSuccess = true,
                Result = await queryable
                    .OrderBy(x => x.Nombre)
                    .Paginate(pagination)
                    .ToListAsync()
            };
        }
    }
}
