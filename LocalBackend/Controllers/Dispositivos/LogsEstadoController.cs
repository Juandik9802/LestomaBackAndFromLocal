using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Dispositivos;
using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogsEstadoController : GenericController<ClsMLogsEstado,LogsEstadoDTO>
    {
        public LogsEstadoController(IGenericUnitOfWork<ClsMLogsEstado> unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }
    }
}
