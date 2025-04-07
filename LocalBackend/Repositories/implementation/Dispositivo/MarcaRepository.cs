using LocalBackend.Data;
using LocalBackend.Helpers;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Dispositivo
{
    public class MarcaRepository : GenericRepository<ClsMMarca>, IMarcaRepository
    {
        private readonly DataContext _context;

        public MarcaRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMMarca>> GetAsync(Guid id)
        {
            var Marca = await _context.Marca
                .Include(c => c.mDispositivos!)
                .ThenInclude(s => s.AsignacionSistema)
                .FirstOrDefaultAsync(c => c.IdMarca == id);
            if (Marca == null)
            {
                return new ActionResponse<ClsMMarca>
                {
                    WasSuccess = false,
                    Message = "Dispositivo no existe"
                };
            }

            return new ActionResponse<ClsMMarca>
            {
                WasSuccess = true,
                Result = Marca
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMMarca>>> GetAsync()
        {
            var Marca = await _context.Marca
                .Include(c => c.mDispositivos)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMMarca>>
            {
                WasSuccess = true,
                Result = Marca
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMMarca>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.Marca
                .Include(c => c.mDispositivos)
                .AsQueryable();

            return new ActionResponse<IEnumerable<ClsMMarca>>
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
