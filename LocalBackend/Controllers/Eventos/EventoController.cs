using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Eventos
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : GenericController<ClsMEvento>
    {
        public EventoController(IGenericUnitOfWork<ClsMEvento> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
