using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Sistemas;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class SistemaController : GenericController<ClsMSistema,SistemaDTO>
    {
        public SistemaController(IGenericUnitOfWork<ClsMSistema> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
