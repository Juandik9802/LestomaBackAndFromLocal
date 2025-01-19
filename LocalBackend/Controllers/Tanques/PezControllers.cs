using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Cultivo;
using LocalShared.Entities.Tanques;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Tanques
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PezController : GenericController<ClsMPez>
    {
        public PezController(IGenericUnitOfWork<ClsMPez> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
