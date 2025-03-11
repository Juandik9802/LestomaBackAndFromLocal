using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElementoController : GenericController<ClsMElemento>
    {
        public ElementoController(IGenericUnitOfWork<ClsMElemento> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
