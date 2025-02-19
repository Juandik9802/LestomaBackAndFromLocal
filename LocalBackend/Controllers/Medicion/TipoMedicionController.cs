using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Medicion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Medicion
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoMedicionController : GenericController<ClsMTipoMedicion>
    {
        public TipoMedicionController(IGenericUnitOfWork<ClsMTipoMedicion> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
