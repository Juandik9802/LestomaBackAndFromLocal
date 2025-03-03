﻿using LocalShare.Responses;
using LocalShared.Entities.Medicion;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces
{
    public interface IUnidadMedidaUnitOfWork
    {
        Task<ActionResponse<ClsMUnidadMedida>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMUnidadMedida>>> GetAsync();
    }
}
