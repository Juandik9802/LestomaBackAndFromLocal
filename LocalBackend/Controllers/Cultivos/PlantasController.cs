

using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Cultivo;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Cultivos
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PlantasController : GenericController<ClsMPlantas>
    {
        public PlantasController(IGenericUnitOfWork<ClsMPlantas> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
