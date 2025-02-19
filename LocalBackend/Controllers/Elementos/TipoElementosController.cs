using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoElementosController : GenericController<ClsMTipoElementos>
    {
        public TipoElementosController(IGenericUnitOfWork<ClsMTipoElementos> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
