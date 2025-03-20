using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsignacionSistemaController : GenericController<ClsMAsignacionSistema>
    {
        public AsignacionSistemaController(IGenericUnitOfWork<ClsMAsignacionSistema> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
