﻿using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShare.Responses;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.UnitsOfWork.implementation
{
    public class TipoMedicionUnitOfWork : GenericUnitOfWork<ClsMTipoMedicion>, ITipoMedicionUnitOfWork
    {
        private readonly ITipoMedicionRepository _tipoMedidaRepository;

        public TipoMedicionUnitOfWork(IGenericRepository<ClsMTipoMedicion> repository, ITipoMedicionRepository tipoMedicionUnitOfWork) : 
            base(repository)
        {
            _tipoMedidaRepository = tipoMedicionUnitOfWork;
        }

        public override async Task<ActionResponse<ClsMTipoMedicion>> GetAsync(Guid Id) => await _tipoMedidaRepository.GetAsync(Id);

        public override async Task<ActionResponse<IEnumerable<ClsMTipoMedicion>>> GetAsync() => await _tipoMedidaRepository.GetAsync();
    }  
}
