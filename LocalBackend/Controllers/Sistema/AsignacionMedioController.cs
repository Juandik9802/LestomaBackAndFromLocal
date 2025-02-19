using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsignacionMedioController : GenericController<ClsMAsignacionMedios>
    {
        public AsignacionMedioController(IGenericUnitOfWork<ClsMAsignacionMedios> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
