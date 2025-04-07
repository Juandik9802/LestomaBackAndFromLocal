using LocalBackend.Data;
using LocalBackend.Helpers;
using LocalBackend.Repositories.Interfaces.Sistema;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Sistemas;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Sistema
{
    public class SistemaRepository :GenericRepository<ClsMSistema> , ISistemaRepository
    {
        private readonly DataContext _context;

        public SistemaRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMSistema>> GetAsync(Guid id)
        {
            var sistemas = await _context.Sistema
                .Include(c => c.AsignacionSistemas!)
                .ThenInclude(s => s.propiedadesSistemas)
                .FirstOrDefaultAsync(c => c.IdSistema == id);
            if (sistemas == null)
            {
                return new ActionResponse<ClsMSistema>
                {
                    WasSuccess = false,
                    Message = "Impacto no existe"
                };
            }
            return new ActionResponse<ClsMSistema>
            {
                WasSuccess = true,
                Result = sistemas
            };
        }

        public async Task<ActionResponse<IEnumerable<ClsMSistema>>> GetAsync()
        {
            var sistema = await _context.Sistema
                .Include(c => c.AsignacionSistemas)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMSistema>>
            {
                WasSuccess = true,
                Result = sistema
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMSistema>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.Sistema
                .Include(c => c.AsignacionSistemas)
                .AsQueryable();

            return new ActionResponse<IEnumerable<ClsMSistema>>
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