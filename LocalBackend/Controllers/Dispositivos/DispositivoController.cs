using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispositivoController : GenericController<ClsMDispositivo>
    {
        public DispositivoController(IGenericUnitOfWork<ClsMDispositivo> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
