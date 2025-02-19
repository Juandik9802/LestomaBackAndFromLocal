using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogsEstadosController : GenericController<ClsMLogsEstados>
    {
        public LogsEstadosController(IGenericUnitOfWork<ClsMLogsEstados> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
