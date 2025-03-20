using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadosDispositivoController : GenericController<ClsMEstadosDispositivo>
    {        
        public EstadosDispositivoController(IGenericUnitOfWork<ClsMEstadosDispositivo> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
