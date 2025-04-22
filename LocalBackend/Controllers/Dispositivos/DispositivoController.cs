using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Dispositivos;
using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispositivoController : GenericController<ClsMDispositivo,DispositivoDTO>
    {
        public DispositivoController(IGenericUnitOfWork<ClsMDispositivo> unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }
    }
}
