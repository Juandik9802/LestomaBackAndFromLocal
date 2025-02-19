using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Eventos
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImpactoController : GenericController<ClsMImpacto>
    {
        public ImpactoController(IGenericUnitOfWork<ClsMImpacto> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
