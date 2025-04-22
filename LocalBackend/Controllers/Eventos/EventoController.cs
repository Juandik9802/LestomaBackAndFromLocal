using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Eventos;
using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Eventos
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : GenericController<ClsMEvento,EventoDTO>
    {
        public EventoController(IGenericUnitOfWork<ClsMEvento> unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }
    }
}
