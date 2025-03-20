using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoElementoController : GenericController<ClsMTipoElemento>
    {
        public TipoElementoController(IGenericUnitOfWork<ClsMTipoElemento> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
