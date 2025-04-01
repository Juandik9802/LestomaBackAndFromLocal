using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogsEstadoController : GenericController<ClsMLogsEstado>
    {
        public LogsEstadoController(IGenericUnitOfWork<ClsMLogsEstado> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
