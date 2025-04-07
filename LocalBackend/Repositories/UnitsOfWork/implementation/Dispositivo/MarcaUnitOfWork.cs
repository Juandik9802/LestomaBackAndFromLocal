using LocalBackend.Repositories.implementation.Dispositivo;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Dispositivo
{
    public class MarcaUnitOfWork : GenericUnitOfWork<ClsMMarca>, IMarcaUnitOfWork
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaUnitOfWork(IGenericRepository<ClsMMarca> repository, IMarcaRepository marcaRepository) : base(repository)
        {
            _marcaRepository = marcaRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMMarca>>> GetAsync() => await _marcaRepository.GetAsync();
        public override async Task<ActionResponse<ClsMMarca>> GetAsync(Guid id) => await _marcaRepository.GetAsync(id);
        public override async Task<ActionResponse<IEnumerable<ClsMMarca>>> GetAsync(PaginationDTO pagination) => await _marcaRepository.GetAsync(pagination);

    }
}
