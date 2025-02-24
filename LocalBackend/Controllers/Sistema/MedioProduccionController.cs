using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedioProduccionController : GenericController<ClsMMedio>
    {
        public MedioProduccionController(IGenericUnitOfWork<ClsMMedio> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
