using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropiedadSistemaController : GenericController<ClsMPropiedadesSistema>
    {
        public PropiedadSistemaController(IGenericUnitOfWork<ClsMPropiedadesSistema> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
