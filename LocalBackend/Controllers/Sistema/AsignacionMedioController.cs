using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsignacionMedioController : GenericController<ClsMAsignacionMedio>
    {
        public AsignacionMedioController(IGenericUnitOfWork<ClsMAsignacionMedio> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
