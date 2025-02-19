using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Medicion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Medicion
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnidadMedidaController : GenericController<ClsMUnidadMedida>
    {
        public UnidadMedidaController(IGenericUnitOfWork<ClsMUnidadMedida> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
