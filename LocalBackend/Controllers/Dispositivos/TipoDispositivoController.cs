using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoDispositivoController : GenericController<ClsMTipoDispositivo>
    {
        public TipoDispositivoController(IGenericUnitOfWork<ClsMTipoDispositivo> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
