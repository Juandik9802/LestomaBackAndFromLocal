using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Eventos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoImpactoController : GenericController<ClsMTipoEvento>
    {
        public TipoImpactoController(IGenericUnitOfWork<ClsMTipoEvento> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
