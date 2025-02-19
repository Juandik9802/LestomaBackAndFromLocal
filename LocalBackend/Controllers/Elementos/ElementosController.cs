using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElementosController : GenericController<ClsMElementos>
    {
        public ElementosController(IGenericUnitOfWork<ClsMElementos> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
