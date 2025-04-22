using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Sistemas;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpaController : GenericController<ClsMUpa, UpaDTO>
    {
        public UpaController(IGenericUnitOfWork<ClsMUpa> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
