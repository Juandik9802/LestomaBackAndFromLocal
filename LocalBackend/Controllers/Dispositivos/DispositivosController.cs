using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispositivosController : GenericController<ClsMDispositivos>
    {
        public DispositivosController(IGenericUnitOfWork<ClsMDispositivos> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
