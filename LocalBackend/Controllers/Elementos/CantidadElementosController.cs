using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class CantidadElementosController : GenericController<ClsMCantidadElementos>
    {
        public CantidadElementosController(IGenericUnitOfWork<ClsMCantidadElementos> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
