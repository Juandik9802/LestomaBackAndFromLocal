using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Sistemas;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsignacionMedioController : GenericController<ClsMAsignacionMedio,AsignacionMedioDTO>
    {
        public AsignacionMedioController(IGenericUnitOfWork<ClsMAsignacionMedio> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
