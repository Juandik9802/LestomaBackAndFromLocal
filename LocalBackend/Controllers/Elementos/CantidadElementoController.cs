using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class CantidadElementoController : GenericController<ClsMCantidadElemento>
    {
        public CantidadElementoController(IGenericUnitOfWork<ClsMCantidadElemento> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
