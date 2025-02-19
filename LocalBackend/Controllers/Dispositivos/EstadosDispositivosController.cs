using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadosDispositivosController : GenericController<ClsMEstadosDispositivos>
    {        
        public EstadosDispositivosController(IGenericUnitOfWork<ClsMEstadosDispositivos> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
