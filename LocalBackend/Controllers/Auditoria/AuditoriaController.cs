using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Auditoria;
using LocalShared.Entities.Auditoria;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Auditoria
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuditoriaService : GenericController<ClsMAuditoria,AuditoriaDTO>
    {
        public AuditoriaService(IGenericUnitOfWork<ClsMAuditoria> unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }
    }
}
