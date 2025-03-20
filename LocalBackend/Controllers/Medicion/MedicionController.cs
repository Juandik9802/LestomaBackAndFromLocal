using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.Entities.Medicion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Medicion
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicionController : GenericController<ClsMMedicion>
    {
        public MedicionController(IGenericUnitOfWork<ClsMMedicion> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
