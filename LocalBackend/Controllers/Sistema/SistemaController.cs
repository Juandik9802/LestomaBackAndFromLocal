using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class SistemaController : GenericController<ClsMSistema>
    {
        public SistemaController(IGenericUnitOfWork<ClsMSistema> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
