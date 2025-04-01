using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class PuntoOptimoController : GenericController<ClsMPuntoOptimo>
    {
        public PuntoOptimoController(IGenericUnitOfWork<ClsMPuntoOptimo> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
