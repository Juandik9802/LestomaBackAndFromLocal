﻿using LocalShare.Responses;
using LocalShared.Entities.Medicion;
using System.Threading.Tasks;

namespace LocalBackend.Repositories.Interfaces
{
    public interface ITipoMedicionRepository
    {
        Task<ActionResponse<ClsMTipoMedicion>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMTipoMedicion>>> GetAsync();
    }
}
